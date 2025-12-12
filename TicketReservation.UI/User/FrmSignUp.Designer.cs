namespace TicketReservation.UI
{
    partial class FrmSignUp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTcNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKayitOl = new Guna.UI2.WinForms.Guna2Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.labelTitle.Location = new System.Drawing.Point(120, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(193, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Hesap Oluştur";
            // 
            // txtAd
            // 
            this.txtAd.BorderRadius = 10;
            this.txtAd.PlaceholderText = "Adınız";
            this.txtAd.Location = new System.Drawing.Point(85, 90);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(260, 36);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderRadius = 10;
            this.txtSoyad.PlaceholderText = "Soyadınız";
            this.txtSoyad.Location = new System.Drawing.Point(85, 140);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(260, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.PlaceholderText = "E-Mail Adresi";
            this.txtEmail.Location = new System.Drawing.Point(85, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 36);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.BorderRadius = 10;
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.Location = new System.Drawing.Point(85, 240);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(260, 36);
            this.txtSifre.TabIndex = 4;
            // 
            // txtTcNo
            // 
            this.txtTcNo.BorderRadius = 10;
            this.txtTcNo.PlaceholderText = "TC Kimlik No";
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Location = new System.Drawing.Point(85, 290);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(260, 36);
            this.txtTcNo.TabIndex = 5;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BorderRadius = 10;
            this.btnKayitOl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(85, 350);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(260, 45);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(390, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 7;
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtAd;
        private Guna.UI2.WinForms.Guna2TextBox txtSoyad;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtTcNo;
        private Guna.UI2.WinForms.Guna2Button btnKayitOl;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
    }
}