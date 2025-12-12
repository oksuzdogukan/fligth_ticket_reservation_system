using System;
using System.Windows.Forms;
using TicketReservation.Business.Abstract;
using TicketReservation.Models;

namespace TicketReservation.UI.Admin
{
    public partial class FrmFlights : Form
    {
        private readonly IUcusService _ucusService;

        public FrmFlights(IUcusService ucusService)
        {
            InitializeComponent();
            _ucusService = ucusService;
        }

        private void FrmFlights_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dgvFlights.DataSource = _ucusService.UcusListele();

            // Gereksiz sütunları gizle
            if (dgvFlights.Columns["Ucak"] != null) dgvFlights.Columns["Ucak"].Visible = false;
            if (dgvFlights.Columns["SatisFiyati"] != null) dgvFlights.Columns["SatisFiyati"].Visible = false;
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            try
            {
                Ucus ucus = new Ucus
                {
                    KalkisYeri = txtKalkisYeri.Text,
                    VarisYeri = txtVarisYeri.Text,
                    Tarih = dtpTarih.Value.Date,
                    Saat = dtpSaat.Value.TimeOfDay,
                    TemelFiyat = Convert.ToDecimal(txtTemelFiyat.Text),
                    UcakId = Convert.ToInt32(txtUcakId.Text)
                };

                bool basarili = _ucusService.UcusEkle(ucus);

                if (basarili)
                {
                    MessageBox.Show("Uçuş başarıyla eklendi.");
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Uçuş eklenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUcusNo.Text)) return;

                Ucus ucus = new Ucus
                {
                    UcusId = Convert.ToInt32(txtUcusNo.Text),
                    KalkisYeri = txtKalkisYeri.Text,
                    VarisYeri = txtVarisYeri.Text,
                    Tarih = dtpTarih.Value.Date,
                    Saat = dtpSaat.Value.TimeOfDay,
                    TemelFiyat = Convert.ToDecimal(txtTemelFiyat.Text),
                    UcakId = Convert.ToInt32(txtUcakId.Text)
                };

                bool basarili = _ucusService.UcusGuncelle(ucus);

                if (basarili)
                {
                    MessageBox.Show("Uçuş güncellendi.");
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUcusNo.Text))
                {
                    MessageBox.Show("Silmek için listeden bir uçuş seçiniz.");
                    return;
                }

                int ucusId = Convert.ToInt32(txtUcusNo.Text);

                if (MessageBox.Show("Bu uçuşu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool basarili = _ucusService.UcusSil(ucusId);
                    if (basarili)
                    {
                        MessageBox.Show("Uçuş silindi.");
                        Listele();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Uçuş silinemedi (Aktif rezervasyon olabilir).");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // FrmAdminHome zaten arkada açık, burayı kapatınca orası görünecek.
        }
        private void dataGridViewFlights_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvFlights.Rows[e.RowIndex];
                    txtUcusNo.Text = row.Cells["UcusId"].Value.ToString();
                    txtKalkisYeri.Text = row.Cells["KalkisYeri"].Value.ToString();
                    txtVarisYeri.Text = row.Cells["VarisYeri"].Value.ToString();
                    dtpTarih.Value = Convert.ToDateTime(row.Cells["Tarih"].Value);

                    // TimeSpan dönüşümü
                    TimeSpan ts = (TimeSpan)row.Cells["Saat"].Value;
                    dtpSaat.Value = DateTime.Today.Add(ts);

                    txtTemelFiyat.Text = row.Cells["TemelFiyat"].Value.ToString();
                    txtUcakId.Text = row.Cells["UcakId"].Value.ToString();
                }
                catch { }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtUcusNo.Clear();
            txtKalkisYeri.Clear();
            txtVarisYeri.Clear();
            txtTemelFiyat.Clear();
            txtUcakId.Clear();
            dtpTarih.Value = DateTime.Now;
            dtpSaat.Value = DateTime.Now;
        }
    }
}