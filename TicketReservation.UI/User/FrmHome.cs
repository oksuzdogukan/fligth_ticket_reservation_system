using System;
using System.Windows.Forms;
using TicketReservation.Business.Concrete;
using TicketReservation.Data.Concrete;
using TicketReservation.Models;

namespace TicketReservation.UI
{
    public partial class FrmHome : Form
    {
        private Musteri _girisYapanMusteri; // Giriş yapan kullanıcıyı burada tutacağız

        // Constructor'ı parametre alacak şekilde değiştiriyoruz
        public FrmHome(Musteri musteri = null)
        {
            InitializeComponent();
            _girisYapanMusteri = musteri;

            if (_girisYapanMusteri != null)
            {
                // İstersen başlığa ismini yazdırabilirsin
                // labelTitle.Text = "Hoşgeldiniz " + _girisYapanMusteri.Ad;
            }
        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            // FrmSearchFlight için gerekli bağımlılıklar
            var rezervasyonDal = new RezervasyonDal();
            var ucusDal = new UcusDal();
            var koltukDal = new KoltukDal();

            var ucusManager = new UcusManager(ucusDal, rezervasyonDal);
            var rezervasyonManager = new RezervasyonManager(rezervasyonDal, koltukDal, ucusDal);
            var koltukManager = new KoltukManager(koltukDal);

            FrmSearchFlight searchForm = new FrmSearchFlight(ucusManager, rezervasyonManager, koltukManager, _girisYapanMusteri);
            searchForm.ShowDialog();
        }

        private void btnMyReservations_Click(object sender, EventArgs e)
        {

            FrmViewRezervastion viewRezForm = new FrmViewRezervastion(_girisYapanMusteri);
            viewRezForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close(); // Login ekranına döner
        }
    }
}