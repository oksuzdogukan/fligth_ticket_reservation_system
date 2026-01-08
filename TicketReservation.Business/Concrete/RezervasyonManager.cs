using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        private readonly IKuponDal _kuponDal;
        

        public RezervasyonManager(IRezervasyonDal rezervasyonDal, IKoltukDal koltukDal, IUcusDal ucusDal, IKuponDal kuponDal)
        {
            _rezervasyonDal = rezervasyonDal;
            _koltukDal = koltukDal;
            _ucusDal = ucusDal;
            _kuponDal = kuponDal;
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

            bool isBusiness = secilenKoltuk.IsBusiness;
            //rezervasyon.Fiyat = DinamikFiyatHesapla(ucus, koltuklar, secilenKoltuk.IsBusiness);

            return _rezervasyonDal.RezervasyonYap(rezervasyon);
        }

        public List<Rezervasyon> RezervasyonGoruntule(int musteriId)
        {
            return _rezervasyonDal.RezervasyonGoruntule(musteriId);
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

        public decimal DinamikFiyatHesapla(Ucus ucus, List<Koltuk> koltuklar, bool isBusiness = false, string kuponKodu = null)
        {
            decimal temelFiyat = ucus.TemelFiyat;
            decimal sonFiyat = temelFiyat;

            // 1. KURAL: DOLULUK ORANI
            int toplamKoltuk = koltuklar.Count();
            int doluKoltuk = koltuklar.Count(k => k.DoluMu == true);

            // Sıfıra bölünme hatasını önle
            double dolulukOrani = toplamKoltuk > 0 ? (double)doluKoltuk / toplamKoltuk : 0;

            if (dolulukOrani > 0.80)
                sonFiyat += temelFiyat * 0.50m; // %50 zam
            else if (dolulukOrani > 0.50)
                sonFiyat += temelFiyat * 0.20m; // %20 zam

            // 2. KURAL: UÇUŞA KALAN GÜN (Erken alan ucuza alır)
            TimeSpan kalanSure = ucus.Tarih - DateTime.Now;
            if (kalanSure.TotalDays < 3)
            {
                sonFiyat += temelFiyat * 0.30m; // Son 3 gün kala %30 zam
            }

            // 3. KURAL: HAFTA SONU UÇUŞU (Pazar günü daha pahalı)
            if (ucus.Tarih.DayOfWeek == DayOfWeek.Sunday)
            {
                sonFiyat += temelFiyat * 0.15m;
            }

            // 4. KURAL: DONEME GORE (HAZIRAN TEMMUZ AGUSTOS ta %20 zam)
            int ay = ucus.Tarih.Month;
            if(ay == 6 || ay==7 || ay == 8)
            {
                sonFiyat += temelFiyat * 0.20m;
            }

            //5. Kural: Business koltuk
            if (isBusiness)
            {
                sonFiyat *= 1.5m;
            }
            // 6.KURAL: KUPON INDIRIMI
            if (!string.IsNullOrEmpty(kuponKodu))
            {
                var kupon = _kuponDal.KuponGetir(kuponKodu);
                if(kupon != null)
                {
                    sonFiyat -= sonFiyat * kupon.IndirimOrani;

                }
            }

            return Math.Round(sonFiyat, 2);
        }

        public decimal KoltukFiyatiHesapla(decimal temelFiyat, bool isBusiness)
        {
            return isBusiness ? temelFiyat *= 1.5m : temelFiyat; 
        }

        public decimal KuponIndirimiHesapla(string kuponKodu, decimal guncelFiyat)
        {
            var kupon = _kuponDal.KuponGetir(kuponKodu);
            if (kupon != null)
            {
                return guncelFiyat - (guncelFiyat * kupon.IndirimOrani);
            }
            return guncelFiyat;
        }

        // raporlama
        public Dictionary<string, object> RaporGetir()
        {
            return _rezervasyonDal.RaporVerileriniAl();
        }
    }
}
