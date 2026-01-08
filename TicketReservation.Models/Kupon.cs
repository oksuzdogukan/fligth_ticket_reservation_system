using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class Kupon
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public decimal IndirimOrani { get; set; } // 0.10 = %10
        public DateTime SonKullanimTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}
