using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TicketReservation.Models;
using Guna.UI2.WinForms; // Guna UI Kütüphanesi

namespace TicketReservation.UI.UserUI
{
    public partial class FrmSeatSelection : Form
    {
        // Propertyler (Dışarı veri aktarmak için)
        public int SelectedSeatNumber { get; private set; } = 0;
        public decimal FinalPrice { get; private set; } = 0;
        public bool IsConfirmed { get; private set; } = false;

        // İç değişkenler
        private readonly List<Koltuk> _koltuklar;
        private readonly decimal _basePrice;
        private Guna2Button _lastClickedButton = null; // Seçimi takip etmek için

        public FrmSeatSelection(List<Koltuk> koltuklar, decimal basePrice)
        {
            InitializeComponent();
            _koltuklar = koltuklar;
            _basePrice = basePrice;

            LoadSeats();
            UpdatePriceLabel();
        }

        private void UpdatePriceLabel()
        {
            lblTotalPrice.Text = $"{_basePrice:C2}";
        }

        private void LoadSeats()
        {
            flowSeatPanel.Controls.Clear();

            foreach (var koltuk in _koltuklar)
            {
                // Guna Button Oluşturma (Dinamik)
                Guna2Button btn = new Guna2Button();
                btn.Width = 50;
                btn.Height = 50;
                btn.BorderRadius = 10;
                btn.Margin = new Padding(8); // Butonlar arası boşluk
                btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Text = koltuk.KoltukNo.ToString();
                btn.Tag = koltuk; // Koltuk nesnesini butonun içine sakla

                // Durumuna göre Renk ve Özellik Ayarı
                if (koltuk.DoluMu)
                {
                    btn.FillColor = Color.FromArgb(231, 76, 60); // Kırmızı (Dolu)
                    btn.Enabled = false;
                    btn.Cursor = Cursors.No;
                }
                else
                {
                    btn.Cursor = Cursors.Hand;
                    btn.Click += Seat_Click; // Tıklama Olayı

                    if (koltuk.IsBusiness)
                    {
                        btn.FillColor = Color.Gold; // Business
                        btn.ForeColor = Color.Black;
                    }
                    else
                    {
                        btn.FillColor = Color.FromArgb(94, 148, 255); // Ekonomi (Guna Mavisi)
                    }
                }

                flowSeatPanel.Controls.Add(btn);

                // Koridor Boşluğu (Görsel Düzenleme)
                // Her 2 koltukta bir, eğer satır sonu değilse (4) boşluk bırak
                if (koltuk.KoltukNo % 2 == 0 && koltuk.KoltukNo % 4 != 0)
                {
                    btn.Margin = new Padding(8, 8, 60, 8); // Sağdan ekstra boşluk
                }
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Guna2Button clickedBtn = (Guna2Button)sender;
            Koltuk koltuk = (Koltuk)clickedBtn.Tag;

            // 1. Önceki seçimi sıfırla (Rengini eski haline döndür)
            if (_lastClickedButton != null)
            {
                Koltuk eskiKoltuk = (Koltuk)_lastClickedButton.Tag;
                if (eskiKoltuk.IsBusiness)
                {
                    _lastClickedButton.FillColor = Color.Gold;
                    _lastClickedButton.ForeColor = Color.Black;
                }
                else
                {
                    _lastClickedButton.FillColor = Color.FromArgb(94, 148, 255);
                    _lastClickedButton.ForeColor = Color.White;
                }
            }

            // 2. Yeni seçimi işaretle (Yeşil)
            _lastClickedButton = clickedBtn;
            clickedBtn.FillColor = Color.FromArgb(46, 204, 113); // Yeşil
            clickedBtn.ForeColor = Color.White;

            // 3. Verileri Güncelle
            SelectedSeatNumber = koltuk.KoltukNo;

            // Fiyat Hesaplama: Business ise 1.5 katı
            decimal multiplier = koltuk.IsBusiness ? 1.5m : 1.0m;
            FinalPrice = _basePrice * multiplier;

            // 4. UI Bilgilendirme
            string type = koltuk.IsBusiness ? "Business" : "Ekonomi";
            lblSeatInfo.Text = $"Seçilen: Koltuk {SelectedSeatNumber} ({type})";
            lblTotalPrice.Text = $"{FinalPrice:C2}";

            // 5. Onay Butonunu Aç
            btnConfirm.Enabled = true;
            btnConfirm.FillColor = Color.FromArgb(100, 88, 255); // Guna Moru (Aktif)
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Kullanıcıya son bir soru
            DialogResult dr = MessageBox.Show(
                $"Koltuk: {SelectedSeatNumber}\nTutar: {FinalPrice:C2}\n\nOnaylıyor musunuz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                IsConfirmed = true;
                this.Close();
            }
        }
    }
}