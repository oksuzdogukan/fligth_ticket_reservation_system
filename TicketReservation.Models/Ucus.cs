 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class Ucus
    {
        public int UcusId { get; set; }
        public int UcakId { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        public DateTime Tarih { get; set; }
        public TimeSpan Saat { get; set; }
        public decimal TemelFiyat { get; set; }
        public Ucak Ucak { get; set; }

        public decimal SatisFiyati { get; set; } // DB icin degil, ekranda hesaplanan fiyati gostermek icin
    }
}
