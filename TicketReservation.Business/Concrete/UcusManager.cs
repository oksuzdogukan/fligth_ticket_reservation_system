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
    public class UcusManager : IUcusService
    {
        private readonly IUcusDal _ucusDal;

        private readonly IRezervasyonDal _rezervasyonDal; // ucus sil icin


        public UcusManager(IUcusDal ucusDal, IRezervasyonDal rezervasyonDal)
        {
            _ucusDal = ucusDal;
            _rezervasyonDal = rezervasyonDal;
        }

        // ADMIN ISLEMLERI
        public bool UcusEkle(Ucus ucus)
        {
            if(string.IsNullOrEmpty(ucus.KalkisYeri) || string.IsNullOrEmpty(ucus.VarisYeri))
            {
                throw new Exception("Kalkis ve Varis yeri secmelisiniz");
            }

            if(ucus.KalkisYeri.ToLower() == ucus.VarisYeri.ToLower())
            {
                throw new Exception("Kalkis ve Varis yeri ayni olamaz");
            }

            if(ucus.Tarih < DateTime.Today)
            {
                throw new Exception("Gecmis Tarihli Ucus Eklenemez");
            }

            if(ucus.TemelFiyat <= 0)
            {
                throw new Exception("Gecerli bir fiyat giriniz");
            }

            return _ucusDal.UcusEkle(ucus);
        }

        public bool UcusGuncelle(Ucus ucus)
        {
            if (string.IsNullOrEmpty(ucus.KalkisYeri) || string.IsNullOrEmpty(ucus.VarisYeri))
            {
                throw new Exception("Kalkis ve Varis yeri secmelisiniz");
            }

            if (ucus.TemelFiyat <= 0)
            {
                throw new Exception("Gecerli bir fiyat giriniz");
            }

            return _ucusDal.UcusGuncelle(ucus);

        }

        public bool UcusSil(int ucusId)
        {
            // Ucusa ait aktif rezervasyon varsa ucus silinemez

            if (_rezervasyonDal.AktifUcusRezervasyonuVarMi(ucusId))
            {
                throw new Exception("Bu Ucusa ait 'Aktif' durumda rezervasyon bulunmaktadir. Silinemez");
            }

            return _ucusDal.UcusSil(ucusId);
        }

        public List<Ucus> UcusListele()
        {
            return _ucusDal.UcusListele();
        }

        // ORTAK ISLEMLERI
        public Ucus UcusGetir(int ucusId)
        {
            return _ucusDal.UcusGetir(ucusId);
        }
    }
}
