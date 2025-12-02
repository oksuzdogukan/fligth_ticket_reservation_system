using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Data.Interfaces
{
    public interface IKoltukDal
    {
        List<Koltuk> KoltuklariGetir(int ucusId);

    }
}
