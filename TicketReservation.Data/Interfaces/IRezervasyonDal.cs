using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Data.Interfaces
{
    public interface IRezervasyonDal
    {
        bool RezervasyonYap(Rezervasyon rezervasyon);
        bool RezervasyonIptalEt(int rezervasyonId);
        List<Rezervasyon> RezervasyonGoruntule(int musteriId); // musterinin tum rezervasyonlari

        bool AktifUcusRezervasyonuVarMi(int ucusId);
    }
}
