using System;
using System.Windows.Forms;
using TicketReservation.Business.Concrete;
using TicketReservation.Data.Concrete;
using TicketReservation.UI.Admin; // FrmFlights burada

namespace TicketReservation.UI
{
    public partial class FrmAdminHome : Form
    {
        public FrmAdminHome()
        {
            InitializeComponent();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            // FrmFlights'ı açmak için gerekli bağımlılıkları oluştur
            var ucusDal = new UcusDal();
            var rezervasyonDal = new RezervasyonDal(); // Uçuş silerken kontrol için lazım
            var ucusManager = new UcusManager(ucusDal, rezervasyonDal);

            FrmFlights frmFlights = new FrmFlights(ucusManager);
            frmFlights.ShowDialog(); // Formu aç
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var rezDal = new RezervasyonDal();
            var koltukDal = new KoltukDal();
            var ucusDal = new UcusDal();
            var kuponDal = new KuponDal();
            var rezManager = new RezervasyonManager(rezDal, koltukDal, ucusDal, kuponDal);

            FrmReports reportForm = new FrmReports(rezManager);
            reportForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Ana ekrana veya login'e döner
        }
    }
}