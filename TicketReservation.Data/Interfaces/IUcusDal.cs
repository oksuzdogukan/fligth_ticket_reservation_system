using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Data.Interfaces
{
    public interface IUcusDal
    {
        // Admin islemleri
        bool UcusEkle(Ucus ucus);
        bool UcusGuncelle(Ucus ucus);
        bool UcusSil(int ucusId);

        // Ortak islemler
        List<Ucus> UcusListele();
        

        // Musteri islemleri
        List<Ucus> UcusAra(string kalkis, string varis);
        Ucus UcusGetir(int ucusId);
    }
}
