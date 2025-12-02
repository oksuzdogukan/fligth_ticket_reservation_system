using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Business.Abstract
{
    public interface IUcusService
    {
        // Admin islemleri
        bool UcusEkle(Ucus ucus); 
        bool UcusGuncelle(Ucus ucus); 
        bool UcusSil(int ucusId);

        // Ortak islemler
        List<Ucus> UcusListele(); 
        Ucus UcusGetir(int ucusId); // final

    }
}
