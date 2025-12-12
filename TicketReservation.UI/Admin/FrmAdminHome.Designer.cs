namespace TicketReservation.UI
{
    partial class FrmAdminHome
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
            this.panelSide = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnFlights = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.labelAdminTitle = new System.Windows.Forms.Label();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelSide.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panelSide.Controls.Add(this.btnExit);
            this.panelSide.Controls.Add(this.btnFlights);
            this.panelSide.Controls.Add(this.btnReports);
            this.panelSide.Controls.Add(this.labelAdminTitle);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(267, 615);
            this.panelSide.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 10;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(31, 533);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFlights
            // 
            this.btnFlights.BorderRadius = 10;
            this.btnFlights.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFlights.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFlights.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFlights.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFlights.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFlights.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFlights.ForeColor = System.Drawing.Color.White;
            this.btnFlights.Location = new System.Drawing.Point(31, 161);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(207, 55);
            this.btnFlights.TabIndex = 1;
            this.btnFlights.Text = "Uçuş İşlemleri";
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // btnReports
            // 
            this.btnReports.BorderRadius = 10;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(31, 235);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(207, 55);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Uçuş Raporları";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // labelAdminTitle
            // 
            this.labelAdminTitle.AutoSize = true;
            this.labelAdminTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelAdminTitle.ForeColor = System.Drawing.Color.White;
            this.labelAdminTitle.Location = new System.Drawing.Point(23, 42);
            this.labelAdminTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdminTitle.Name = "labelAdminTitle";
            this.labelAdminTitle.Size = new System.Drawing.Size(221, 41);
            this.labelAdminTitle.TabIndex = 0;
            this.labelAdminTitle.Text = "Yönetici Modu";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(267, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 62);
            this.panelTop.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcome.ForeColor = System.Drawing.Color.Gray;
            this.lblWelcome.Location = new System.Drawing.Point(28, 18);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(327, 28);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Uçuş Yönetim Sistemine Hoşgeldiniz";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(724, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 36);
            this.btnClose.TabIndex = 1;
            // 
            // FrmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelSide;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnFlights;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private System.Windows.Forms.Label labelAdminTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblWelcome;
    }
}