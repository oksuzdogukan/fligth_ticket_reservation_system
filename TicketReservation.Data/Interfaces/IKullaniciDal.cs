using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Data.Interfaces
{
    public interface IKullaniciDal
    {

        Kullanici GirisYap(string email, string sifre);

        bool KayitOl(Musteri musteri);
    }
}
