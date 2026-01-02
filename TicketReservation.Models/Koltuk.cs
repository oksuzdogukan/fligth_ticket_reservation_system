using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class Koltuk
    {
        public int KoltukId { get; set; }
        public int UcusId { get; set; }
        public int KoltukNo { get; set; }
        public bool DoluMu { get; set; }

        public bool IsBusiness { get; set; }

        public override string ToString()
        {
            return $"Koltuk No: {KoltukNo} ({DoluMu})";
        }
    }
}
