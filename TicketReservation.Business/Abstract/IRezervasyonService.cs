using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Business.Abstract
{
    public interface IRezervasyonService
    {
        bool RezervasyonYap(Rezervasyon rezervasyon);

        List<Koltuk> KoltuklariGerit(int ucusId); // Koltuk secme ekrani icin

        bool RezervasyonIptalEt(int rezervasyonId);
        List<Rezervasyon> RezervasyonGoruntule(int musteriId); // musterinin tum rezervasyonlari

    }
}
