using System;
using System.Windows.Forms;
using TicketReservation.Business.Concrete;
using TicketReservation.Data.Concrete;
using TicketReservation.Models;
using TicketReservation.UI.Admin;

namespace TicketReservation.UI
{
    public partial class FrmLogin : Form
    {
        private readonly KullaniciManager _kullaniciManager;

        public FrmLogin()
        {
            InitializeComponent();
            _kullaniciManager = new KullaniciManager(new KullaniciDal());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Kullanici kullanici = _kullaniciManager.GirisYap(email, password);

                if (kullanici != null)
                {
                    // Şifre alanını temizle
                    txtPassword.Clear();

                    // Login formunu gizle
                    this.Hide();

                    if (kullanici is TicketReservation.Models.Admin)
                    {
                        FrmAdminHome adminForm = new FrmAdminHome();
                        adminForm.ShowDialog(); // Form kapanana kadar burada bekler
                    }
                    else if (kullanici is Musteri)
                    {
                        FrmHome homeForm = new FrmHome((Musteri)kullanici);
                        homeForm.ShowDialog(); // Form kapanana kadar burada bekler
                    }

                    // Ana formlar kapandığında (Çıkış yapıldığında) buraya düşer
                    // Ve Login formunu tekrar gösteririz
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Email veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
                this.Show();
            }
        }

        private void btnGoToSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp signUpForm = new FrmSignUp();
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();
        }
    }
}