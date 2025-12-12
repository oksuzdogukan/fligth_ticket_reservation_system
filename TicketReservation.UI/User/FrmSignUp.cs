using System;
using System.Windows.Forms;
using TicketReservation.Business.Concrete;
using TicketReservation.Data.Concrete;
using TicketReservation.Models;

namespace TicketReservation.UI
{
    public partial class FrmSignUp : Form
    {
        private readonly KullaniciManager _kullaniciManager;

        public FrmSignUp()
        {
            InitializeComponent();
            _kullaniciManager = new KullaniciManager(new KullaniciDal());
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) ||
                   string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text) ||
                   string.IsNullOrEmpty(txtTcNo.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                Musteri yeniMusteri = new Musteri
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Email = txtEmail.Text,
                    Sifre = txtSifre.Text,
                    TcNo = txtTcNo.Text
                };

                bool sonuc = _kullaniciManager.KayitOl(yeniMusteri);

                if (sonuc)
                {
                    MessageBox.Show("Kayıt başarılı! Giriş ekranına yönlendiriliyorsunuz.");
                    this.Close(); // Formu kapat, login formuna dön
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız! Email adresi kullanılıyor olabilir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}