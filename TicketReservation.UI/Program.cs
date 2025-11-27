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

            var rezervasyonDal = new RezervasyonDal();
            var ucusDal = new UcusDal();

            var ucusManager = new UcusManager(ucusDal, rezervasyonDal);


            Application.Run(new FrmFlights(ucusManager));


            // Program tamamlaninca
            //Application.Run(new FrmLogin());  
        }
    }
}
