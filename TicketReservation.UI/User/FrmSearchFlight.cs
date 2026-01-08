using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicketReservation.Business.Abstract;
using TicketReservation.Business.Concrete;
using TicketReservation.Models;
using TicketReservation.UI.UserUI;

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

        private void btnPickSeat_Click(object sender, EventArgs e)
        {
            // 1. Grid'den bir uçuş seçilmiş mi kontrol et
            if (dgvFlights.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen önce listeden bir uçuş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Seçili satırdan UcusNo ve TemelFiyat'ı al
                // Not: Grid sütun isimlerin UcusNo ve TemelFiyat olmalı
                int ucusNo = Convert.ToInt32(dgvFlights.SelectedRows[0].Cells["UcusId"].Value);
                decimal temelFiyat = Convert.ToDecimal(dgvFlights.SelectedRows[0].Cells["TemelFiyat"].Value);

                // 3. O uçuşun koltuklarını veritabanından çek
                var koltuklar = _rezervasyonService.KoltuklariGetir(ucusNo);
                

                // 4. Görsel Koltuk Seçim Formunu (FrmSeatSelection) aç
                using (var frmSeat = new FrmSeatSelection(koltuklar, temelFiyat, _rezervasyonService))
                {
                    frmSeat.ShowDialog(); // Formu modal olarak aç (seçim yapana kadar bekler)

                    // 5. Kullanıcı "Onayla" dediyse işlemi bitir
                    if (frmSeat.IsConfirmed)
                    {
                        int secilenKoltuk = frmSeat.SelectedSeatNumber;
                        decimal sonFiyat = frmSeat.FinalPrice; // Business farkı dahil fiyat

                        // 6. Rezervasyonu veritabanına kaydet
                        RezervasyonuBitir(ucusNo, secilenKoltuk, sonFiyat);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void RezervasyonuBitir(int ucusNo, int koltukNo, decimal fiyat)
        {
            var yeniRez = new Rezervasyon
            {
                MusteriId = _musteri.Id,
                UcusId = ucusNo,
                KoltukNo = koltukNo,
                RezervasyonTarihi = DateTime.Now,
                Fiyat = fiyat,
                Durum = Models.Enums.RezervasyonDurumu.Aktif
            };

            if (_rezervasyonService.RezervasyonYap(yeniRez))
            {
                MessageBox.Show($"Rezervasyonunuz Başarıyla Tamamlandı!\nKoltuk: {koltukNo}\nToplam Tutar: {fiyat:C2}",
                                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile (Koltuk dolduğu için güncelleme gerekebilir)
                // btnSearch_Click(null, null); 
            }
            else
            {
                MessageBox.Show("Rezervasyon yapılamadı! Koltuk dolmuş olabilir.");
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
                    //dgvKoltuklar.DataSource = _koltukService.GetByUcusId(_secilenUcusId);
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