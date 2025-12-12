using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Business.Abstract
{
    public interface IKullaniciService
    {
        Kullanici GirisYap(string email, string sifre);
        bool KayitOl(Musteri musteri);

    }
}
