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

        public List<Koltuk> GetByUcusId(int ucusId)
        {
            return _koltukDal.KoltuklariGetir(ucusId);
        }

        // final
        public Koltuk GetById(int koltukId)
        {
            throw new NotImplementedException();
        }
    
        //final
        public void Update(Koltuk koltuk)
        {
            _koltukDal.KoltukDurumuGuncelle(koltuk.UcusId, koltuk.KoltukNo, koltuk.DoluMu);
        }
    }
}
