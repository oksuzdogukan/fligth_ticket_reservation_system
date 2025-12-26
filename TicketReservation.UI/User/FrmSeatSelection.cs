using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TicketReservation.Models;
using Guna.UI2.WinForms; 

namespace TicketReservation.UI.UserUI
{
    public partial class FrmSeatSelection : Form
    {
        // Propertyler
        public int SelectedSeatNumber { get; private set; } = 0;
        public decimal FinalPrice { get; private set; } = 0;
        public bool IsConfirmed { get; private set; } = false;


        private readonly List<Koltuk> _koltuklar;
        private readonly decimal _basePrice;
        private Guna2Button _lastClickedButton = null;

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
            flowSeatPanel.Width = 460;

            foreach (var koltuk in _koltuklar)
            {
                Guna2Button btn = new Guna2Button();
                btn.Width = 50;
                btn.Height = 50;
                btn.BorderRadius = 8;
                btn.Text = koltuk.KoltukNo.ToString();
                btn.Tag = koltuk;
                btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);


                Padding margin = new Padding(5);


                if (koltuk.KoltukNo % 6 == 3)
                {
                    margin.Right = 60; // Orta koridor
                }

                btn.Margin = margin;

                if (koltuk.DoluMu)
                {
                    btn.FillColor = Color.FromArgb(231, 76, 60);
                    btn.Enabled = false;
                }
                else
                {
                    btn.Cursor = Cursors.Hand;
                    btn.FillColor = koltuk.IsBusiness ? Color.Gold : Color.FromArgb(94, 148, 255);
                    btn.ForeColor = koltuk.IsBusiness ? Color.Black : Color.White;
                    btn.Click += Seat_Click;
                }

                flowSeatPanel.Controls.Add(btn);
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Guna2Button clickedBtn = (Guna2Button)sender;
            Koltuk koltuk = (Koltuk)clickedBtn.Tag;

            // 1. Onceki secimi sifirla
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

            // 2. Yeni secimi isaretle
            _lastClickedButton = clickedBtn;
            clickedBtn.FillColor = Color.FromArgb(46, 204, 113); // Yeşil
            clickedBtn.ForeColor = Color.White;

            // 3. Verileri guncelle
            SelectedSeatNumber = koltuk.KoltukNo;

            // Fiyat Hesaplama: Business ise 1.5 kati
            decimal multiplier = koltuk.IsBusiness ? 1.5m : 1.0m;
            FinalPrice = _basePrice * multiplier;

            // 4. UI Bilgilendirme
            string type = koltuk.IsBusiness ? "Business" : "Ekonomi";
            lblSeatInfo.Text = $"Seçilen: Koltuk {SelectedSeatNumber} ({type})";
            lblTotalPrice.Text = $"{FinalPrice:C2}";

            // 5. Onay Butonunu Ac
            btnConfirm.Enabled = true;
            btnConfirm.FillColor = Color.FromArgb(100, 88, 255); // Guna Moru (Aktif)
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

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