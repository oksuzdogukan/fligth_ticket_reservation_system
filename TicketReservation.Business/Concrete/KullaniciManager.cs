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
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
                throw new Exception("Email ve Şifre boş olamaz!");

            return _kullaniciDal.GirisYap(email, sifre);
        }

        public bool KayitOl(Musteri musteri)
        {
            if (string.IsNullOrEmpty(musteri.Ad) || string.IsNullOrEmpty(musteri.Email))
                throw new Exception("Gerekli alanları doldurunuz.");

            // Şifre uzunluğu kontrolü vs. buraya eklenebilir.
            if (musteri.Sifre.Length < 3)
                throw new Exception("Şifre en az 3 karakter olmalı.");

            return _kullaniciDal.KayitOl(musteri);
        }
    }
}
