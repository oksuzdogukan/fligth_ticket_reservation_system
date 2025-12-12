using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketReservation.Business.Concrete;
using TicketReservation.Data.Concrete;
using TicketReservation.UI.Admin;

namespace TicketReservation.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var rezervasyonDal = new RezervasyonDal();
            //var ucusDal = new UcusDal();
            //var koltukDal = new KoltukDal();

            //var ucusManager = new UcusManager(ucusDal, rezervasyonDal);
            //var rezervasyonManager = new RezervasyonManager(rezervasyonDal, koltukDal, ucusDal);
            //var koltukManager = new KoltukManager(koltukDal);


            //Application.Run(new FrmFlights(ucusManager));
            //Application.Run(new FrmSearchFlight(ucusManager, rezervasyonManager, koltukManager));

            Application.Run(new FrmLogin());  
        }
    }
}
