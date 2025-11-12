using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TicketReservation.Business.Abstract;
using TicketReservation.Data.Interfaces;
using TicketReservation.Models;

namespace TicketReservation.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {

        private readonly IKullaniciDal _kullaniciDal; // (field) amac - katmanlar arasi bagimliligi azaltmak. Db farketmezsizin calismasini saglar
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public Kullanici GirisYap(string email, string sifre)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                throw new Exception("Email ve Sifre bos birakilamaz.");
            }

            return _kullaniciDal.GirisYap(email, sifre); // data katmanina gonder
        }

        public bool MusteriKayitOl(Musteri musteri)
        {
            if(string.IsNullOrEmpty(musteri.Ad)  || string.IsNullOrEmpty(musteri.Soyad))
            {
                throw new Exception("Ad ve Soyad bos birakilamaz.");
            }

            if(musteri.Sifre.Length < 8)
            {
                throw new Exception("Sifre en az 8 karakter olmalidir.");
            }

            if (!EmailFormatiDogrulama(musteri.Email))
            {
                throw new Exception("Lutfen gecerli bir email adresi giriniz.");
            }

            if(musteri.TcNo.Length != 11)
            {
                throw new Exception("Tc kimlik no 11 haneli olmalidir");
            }


            return _kullaniciDal.MusteriKayitOl(musteri); // data katmanina gonder
        }


        private bool EmailFormatiDogrulama(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // regex fonk.
        }
    }
}
