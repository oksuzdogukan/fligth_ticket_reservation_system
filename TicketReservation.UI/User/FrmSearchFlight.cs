using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicketReservation.Business.Abstract;
using TicketReservation.Models;

namespace TicketReservation.UI
{
    public partial class FrmSearchFlight : Form
    {
        private readonly IUcusService _ucusService;
        private readonly IRezervasyonService _rezervasyonService;
        private readonly IKoltukService _koltukService;
        private readonly Musteri _musteri;

        private int _secilenUcusId = 0;
        private int _secilenKoltukNo = 0;

        public FrmSearchFlight(IUcusService ucusService, IRezervasyonService rezervasyonService, IKoltukService koltukService, Musteri musteri)
        {
            InitializeComponent();
            _ucusService = ucusService;
            _rezervasyonService = rezervasyonService;
            _koltukService = koltukService;
            _musteri = musteri;
        }

        private void FrmSearchFlight_Load(object sender, EventArgs e)
        {
            // Tüm uçuşları çekip şehirleri combobox'lara doldur
            var tumUcuslar = _ucusService.UcusListele();

            comboKalkis.Items.Clear();
            comboKalkis.Items.AddRange(tumUcuslar.Select(u => u.KalkisYeri).Distinct().ToArray());

            comboVaris.Items.Clear();
            comboVaris.Items.AddRange(tumUcuslar.Select(u => u.VarisYeri).Distinct().ToArray());
        }

        private void btnUcusAra_Click(object sender, EventArgs e)
        {
            if (comboKalkis.SelectedItem == null || comboVaris.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kalkış ve varış yeri seçiniz.");
                return;
            }

            string kalkis = comboKalkis.SelectedItem.ToString();
            string varis = comboVaris.SelectedItem.ToString();

            var sonucListesi = _rezervasyonService.MusteriUcusAra(kalkis, varis);

            if (sonucListesi.Count == 0)
            {
                MessageBox.Show("Kriterlere uygun uçuş bulunamadı.");
            }

            dgvFlights.DataSource = sonucListesi;

            // Gereksiz sütunları gizle
            if (dgvFlights.Columns["Ucak"] != null) dgvFlights.Columns["Ucak"].Visible = false;
            if (dgvFlights.Columns["TemelFiyat"] != null) dgvFlights.Columns["TemelFiyat"].Visible = false;
        }

        private void dgvFlights_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _secilenUcusId = Convert.ToInt32(dgvFlights.Rows[e.RowIndex].Cells["UcusId"].Value);

                var koltukListesi = _koltukService.GetByUcusId(_secilenUcusId);
                dgvKoltuklar.DataSource = koltukListesi;

                if (dgvKoltuklar.Columns["KoltukId"] != null) dgvKoltuklar.Columns["KoltukId"].Visible = false;
                if (dgvKoltuklar.Columns["UcusId"] != null) dgvKoltuklar.Columns["UcusId"].Visible = false;
            }
        }

        private void dgvKoltuklar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvKoltuklar.Columns[e.ColumnIndex].Name == "DoluMu" && e.Value != null)
            {
                bool doluMu = (bool)e.Value;
                DataGridViewRow row = dgvKoltuklar.Rows[e.RowIndex];

                if (doluMu)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60); // Kırmızı
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 76, 60);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113); // Yeşil
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 174, 96);
                }
            }
        }

        private void dgvKoltuklar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool doluMu = Convert.ToBoolean(dgvKoltuklar.Rows[e.RowIndex].Cells["DoluMu"].Value);
                if (doluMu)
                {
                    MessageBox.Show("Bu koltuk dolu, lütfen başka bir koltuk seçiniz.");
                    _secilenKoltukNo = 0;
                }
                else
                {
                    _secilenKoltukNo = Convert.ToInt32(dgvKoltuklar.Rows[e.RowIndex].Cells["KoltukNo"].Value);
                }
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (_secilenUcusId == 0 || _secilenKoltukNo == 0)
                {
                    MessageBox.Show("Lütfen önce bir uçuş ve ardından boş bir koltuk seçiniz.");
                    return;
                }

                if (_musteri == null)
                {
                    MessageBox.Show("Oturum hatası. Lütfen tekrar giriş yapınız.");
                    return;
                }

                Rezervasyon rezervasyon = new Rezervasyon
                {
                    UcusId = _secilenUcusId,
                    KoltukNo = _secilenKoltukNo,
                    MusteriId = _musteri.Id,
                };

                bool basarili = _rezervasyonService.RezervasyonYap(rezervasyon);

                if (basarili)
                {
                    MessageBox.Show($"Rezervasyonunuz başarıyla oluşturuldu!\nKoltuk No: {_secilenKoltukNo}");
                    dgvKoltuklar.DataSource = _koltukService.GetByUcusId(_secilenUcusId);
                    _secilenKoltukNo = 0;
                }
                else
                {
                    MessageBox.Show("Rezervasyon yapılamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // GERİ DÖN BUTONU
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // FrmHome zaten arkada açık (ShowDialog kullanıldığı için), kapatmak yeterli
        }
    }
}