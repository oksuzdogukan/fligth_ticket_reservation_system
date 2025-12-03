using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketReservation.Business.Abstract;
using TicketReservation.Business.Concrete;
using TicketReservation.Models;

namespace TicketReservation.UI.Admin
{
    public partial class FrmFlights : Form
    {
        private readonly IUcusService _ucusService; // business katmaniyla iletisim icin

      

        public FrmFlights(IUcusService ucusService)
        {
            InitializeComponent();
            _ucusService = ucusService;
        }

        // form yuklendiginde verileri listele
        private void FrmFlights_Load(object sender, EventArgs e)
        {
            dataGridViewFlights.DataSource = _ucusService.UcusListele();

            // dataGridView da Ucak column gorunmesin
            dataGridViewFlights.Columns["Ucak"].Visible = false;
            dataGridViewFlights.Columns["SatisFiyati"].Visible = false;
        }

        // secilen satirin verilerini doldurma
        private void dataGridViewFlights_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridViewFlights.SelectedRows[0]; // en basta secilen ilk satir

                Ucus ucus = new Ucus
                {
                    UcusId = Convert.ToInt32(selectedRow.Cells["UcusNo"].Value.ToString()),
                    KalkisYeri = selectedRow.Cells["KalkisYeri"].Value.ToString(),
                    VarisYeri = selectedRow.Cells["VarisYeri"].Value.ToString(),
                    Tarih = Convert.ToDateTime(selectedRow.Cells["Tarih"].Value),
                    Saat = TimeSpan.Parse(selectedRow.Cells["Saat"].Value.ToString()),
                    TemelFiyat = Convert.ToDecimal(selectedRow.Cells["TemelFiyat"].Value),
                    UcakId = Convert.ToInt32(selectedRow.Cells["UcakId"].Value),
                };

                txtUcusNo.Text = ucus.UcusId.ToString();
                txtKalkisYeri.Text = ucus.KalkisYeri.ToString();
                txtVarisYeri.Text = ucus.VarisYeri.ToString();
                txtTarih.Text = ucus.Tarih.ToString();
                txtSaat.Text = ucus.Saat.ToString();
                txtTemelFiyat.Text = ucus.TemelFiyat.ToString();
                txtUcakId.Text = ucus.UcakId.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        // ucus ekleme butonu
        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            try
            {
                Ucus ucus = new Ucus
                {
                    // girilen yeni ucus bilgilerini al
                    KalkisYeri = txtKalkisYeri.Text,
                    VarisYeri = txtVarisYeri.Text,
                    Tarih = txtTarih.Value.Date,
                    Saat = txtSaat.Value.TimeOfDay,
                    TemelFiyat = Convert.ToDecimal(txtTemelFiyat.Text),
                    UcakId = Convert.ToInt32(txtUcakId.Text)
                };
                // ucusu ekle
                bool basarili = _ucusService.UcusEkle(ucus);

                if (basarili)
                {
                    dataGridViewFlights.DataSource = null;
                    dataGridViewFlights.DataSource = _ucusService.UcusListele();
                }
                else
                {
                    MessageBox.Show("Ucus Eklenirken Sorun Olustu");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("hata:" + ex.Message);
            }
            
        }

        // ucus silme butonu
        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow selectedRow = dataGridViewFlights.SelectedRows[0];
                int ucusId = Convert.ToInt32(selectedRow.Cells["UcusNo"].Value.ToString());

                bool basarili = _ucusService.UcusSil(ucusId);

                if (basarili)
                {
                    MessageBox.Show("Ucus Silindi");
                    dataGridViewFlights.DataSource = _ucusService.UcusListele();
                }
                else
                {
                    MessageBox.Show("Ucus Silinirken Hata");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }

            
        }

        // ucus guncelleme butonu
        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            try
            {
                Ucus ucus = new Ucus
                {
                    // girilen yeni ucus bilgilerini al
                    UcusId = Convert.ToInt32(txtUcusNo.Text),
                    KalkisYeri = txtKalkisYeri.Text,
                    VarisYeri = txtVarisYeri.Text,
                    Tarih = txtTarih.Value.Date,
                    Saat = txtSaat.Value.TimeOfDay,
                    TemelFiyat = Convert.ToDecimal(txtTemelFiyat.Text),
                    UcakId = Convert.ToInt32(txtUcakId.Text)
                };
                // ucusu ekle
                bool basarili = _ucusService.UcusGuncelle(ucus);

                if (basarili)
                {
                    dataGridViewFlights.DataSource = null;
                    dataGridViewFlights.DataSource = _ucusService.UcusListele();
                }
                else
                {
                    MessageBox.Show("Ucus Guncellenirken Sorun Olustu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata:" + ex.Message);
            }
        }
    }
}
