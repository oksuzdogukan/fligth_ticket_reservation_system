using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models.Enums;

namespace TicketReservation.Models
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int MusteriId { get; set; }
        public int UcusId { get; set; }
        public int KoltukNo { get; set; }
        public RezervasyonDurumu Durum { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public Ucus Ucus { get; set; }
    }
}
