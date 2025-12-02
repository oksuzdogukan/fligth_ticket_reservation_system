using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TicketReservation.Business.Abstract;
using TicketReservation.Data.Interfaces;
using TicketReservation.Models;

namespace TicketReservation.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {

        private readonly IKullaniciDal _kullaniciDal; // (field) amac - katmanlar arasi bagimliligi azaltmak. Db farketmezsizin calismasini saglar
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

       
    }
}
