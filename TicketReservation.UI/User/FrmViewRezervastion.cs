using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicketReservation.Business.Concrete;
using TicketReservation.Data.Concrete;
using TicketReservation.Models;

namespace TicketReservation.UI
{
    public partial class FrmViewRezervastion : Form
    {
        private readonly RezervasyonManager _rezervasyonManager;
        private readonly Musteri _musteri;

        // Constructor: Müşteri nesnesi zorunlu
        public FrmViewRezervastion(Musteri musteri)
        {
            InitializeComponent();

            // Bağımlılıkları oluştur
            var rezervasyonDal = new RezervasyonDal();
            var koltukDal = new KoltukDal();
            var ucusDal = new UcusDal();
            var kuponDal = new KuponDal();
            _rezervasyonManager = new RezervasyonManager(rezervasyonDal, koltukDal, ucusDal, kuponDal);

            _musteri = musteri;
        }

        // Hata vermemesi için boş constructor (ancak kullanılmamalı)
        public FrmViewRezervastion() { InitializeComponent(); }

        private void FrmViewRezervastion_Load(object sender, EventArgs e)
        {
            if (_musteri == null)
            {
                MessageBox.Show("Kullanıcı bilgisi alınamadı. Lütfen tekrar giriş yapın.");
                this.Close();
                return;
            }

            Listele();
        }

        private void Listele()
        {
            try
            {
                // Veritabanından bu müşteriye ait rezervasyonları çek
                var rezervasyonlar = _rezervasyonManager.RezervasyonGoruntule(_musteri.Id);

                // Veriyi DataGridView'da güzel görünecek şekilde düzleştir (Flatten)
                var listelenecekVeri = rezervasyonlar.Select(r => new
                {
                    r.RezervasyonId,
                    Ucus = r.Ucus != null ? $"{r.Ucus.KalkisYeri} -> {r.Ucus.VarisYeri}" : "Bilinmiyor",
                    Tarih = r.Ucus != null ? r.Ucus.Tarih.ToShortDateString() : "-",
                    Saat = r.Ucus != null ? r.Ucus.Saat.ToString(@"hh\:mm") : "-",
                    Koltuk = r.KoltukNo,
                    Fiyat = r.Fiyat.ToString("C2"), // Para birimi formatı
                    Durum = r.Durum.ToString()
                }).ToList();

                dgvReservations.DataSource = listelenecekVeri;

                // ID sütununu gizle
                if (dgvReservations.Columns["RezervasyonId"] != null)
                    dgvReservations.Columns["RezervasyonId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                // Seçili satırdan ID ve Durum bilgisini al
                int seciliRezId = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["RezervasyonID"].Value);
                string durum = dgvReservations.SelectedRows[0].Cells["Durum"].Value.ToString();

                if (durum == "IptalEdildi")
                {
                    MessageBox.Show("Bu rezervasyon zaten iptal edilmiş.");
                    return;
                }

                DialogResult cevap = MessageBox.Show("Rezervasyonu iptal etmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    bool sonuc = _rezervasyonManager.RezervasyonIptalEt(seciliRezId);
                    if (sonuc)
                    {
                        MessageBox.Show("Rezervasyon iptal edildi.");
                        Listele(); // Listeyi güncelle
                    }
                    else
                    {
                        MessageBox.Show("İptal işlemi başarısız oldu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen iptal etmek için listeden bir rezervasyon seçiniz.");
            }
        }
    }
}