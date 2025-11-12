using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Business.Abstract;
using TicketReservation.Data.Interfaces;
using TicketReservation.Models;

namespace TicketReservation.Business.Concrete
{
    public class KoltukManager : IKoltukService
    {

        private readonly IKoltukDal _koltukDal;
        public KoltukManager(IKoltukDal koltukDal)
        {
            _koltukDal = koltukDal;
        }

        public Koltuk GetById(int koltukId)
        {
            throw new NotImplementedException();
        }

        public List<Koltuk> GetByUcusId(int ucusId)
        {
            throw new NotImplementedException();
        }

        public void Update(Koltuk koltuk)
        {
            _koltukDal.KoltukDurumuGuncelle(koltuk.UcusId, koltuk.KoltukNo, koltuk.DoluMu);
        }
    }
}
