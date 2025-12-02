using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Business.Abstract;
using TicketReservation.Data.Interfaces;
using TicketReservation.Models;

namespace TicketReservation.Business.Concrete
{
    public class RezervasyonManager : IRezervasyonService
    {

        private readonly IRezervasyonDal _rezervasyonDal; // field ornekle
        private readonly IKoltukDal _koltukDal; // koltuklari almak icin
        private readonly IUcusDal _ucusDal; // ucusu kontrol etmek icin
        

        public RezervasyonManager(IRezervasyonDal rezervasyonDal, IKoltukDal koltukDal, IUcusDal ucusDal)
        {
            _rezervasyonDal = rezervasyonDal;
            _koltukDal = koltukDal;
            _ucusDal = ucusDal;
        }

        public List<Koltuk> KoltuklariGetir(int ucusId)
        {
            return _koltukDal.KoltuklariGetir(ucusId); 
        }

       

        public bool RezervasyonIptalEt(int rezervasyonId)
        {
            return _rezervasyonDal.RezervasyonIptalEt(rezervasyonId);
        }

        public bool RezervasyonYap(Rezervasyon rezervasyon)
        {
            // koltuk bos mu?
            List<Koltuk> koltuklar = _koltukDal.KoltuklariGetir(rezervasyon.UcusId);
            Koltuk secilenKoltuk = koltuklar.FirstOrDefault(k => k.KoltukNo == rezervasyon.KoltukNo); // kosulu saglayan dizinin ilk ogesini dondurur

            if(secilenKoltuk == null)
            {
                throw new Exception("Gecersiz Koltuk numarasi!!");
            }
            if (secilenKoltuk.DoluMu)
            {
                throw new Exception("Secilen Koltuk Dolu");
            }

            // ucus bilgilerini al
            Ucus ucus = _ucusDal.UcusGetir(rezervasyon.UcusId);

            if(ucus == null)
            {
                throw new Exception("REzervasyon yapmak istenen ucus bulunamadi.");
            }
            if(ucus.Tarih < DateTime.Now)
            {
                throw new Exception("Gecmis tarihli ucusa rezervasyon yapilamaz");
            }

            // dinamik fiyatlandirma
            decimal sonFiyat = DinamikFiyatHesapla(ucus, koltuklar);

            rezervasyon.Fiyat = sonFiyat; // fiyati guncelle

            return _rezervasyonDal.RezervasyonYap(rezervasyon);

        }

        public List<Ucus> MusteriUcusAra(string kalkis, string varis)
        {
            List<Ucus> bulunanUcuslar = _ucusDal.UcusAra(kalkis, varis);

            foreach (var ucus in bulunanUcuslar)
            {
                List<Koltuk> koltuklar = _koltukDal.KoltuklariGetir(ucus.UcusId);

                decimal hesaplananFiyat = DinamikFiyatHesapla(ucus, koltuklar);

                ucus.SatisFiyati = hesaplananFiyat;
            }

            return bulunanUcuslar;
        }

        private decimal DinamikFiyatHesapla(Ucus ucus, List<Koltuk> koltuklar)
        {
            decimal temelFiyat = ucus.TemelFiyat;

            // KURAL: DOLULUK ORANINA GORE FIYAT HESAPLA
            int toplamKoltuk = koltuklar.Count();
            int doluKoltuk = koltuklar.Count(k => k.DoluMu == true);
            double dolulukOrani = (double)doluKoltuk / toplamKoltuk;

            if(dolulukOrani > 0.80) // ucak %80 den fazla doluysa
            {
                temelFiyat *= 1.40m; // fiyata %40 ekle
            }
            if(dolulukOrani > 0.50) // ucak %50 den fazla doluysa
            {
                temelFiyat *= 1.20m; // fiyata %20 ekle
            }

            return Math.Round(temelFiyat, 2);
        }
    }
}
