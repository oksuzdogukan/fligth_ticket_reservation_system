namespace TicketReservation.UI.Admin
{
    partial class FrmReports
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cardRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRevenueVal = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.cardRez = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRezVal = new System.Windows.Forms.Label();
            this.lblRezTitle = new System.Windows.Forms.Label();
            this.cardFlight = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFlightVal = new System.Windows.Forms.Label();
            this.lblFlightTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.cardRez.SuspendLayout();
            this.cardFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(205, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Uçuş Raporları";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(740, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 1;
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.Transparent;
            this.cardRevenue.BorderRadius = 20;
            this.cardRevenue.Controls.Add(this.lblRevenueVal);
            this.cardRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.cardRevenue.Location = new System.Drawing.Point(30, 100);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Size = new System.Drawing.Size(220, 150);
            this.cardRevenue.TabIndex = 0;
            // 
            // lblRevenueVal
            // 
            this.lblRevenueVal.AutoSize = true;
            this.lblRevenueVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRevenueVal.ForeColor = System.Drawing.Color.White;
            this.lblRevenueVal.Location = new System.Drawing.Point(20, 60);
            this.lblRevenueVal.Name = "lblRevenueVal";
            this.lblRevenueVal.Size = new System.Drawing.Size(76, 41);
            this.lblRevenueVal.TabIndex = 0;
            this.lblRevenueVal.Text = "0 TL";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.White;
            this.lblRevenueTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(132, 28);
            this.lblRevenueTitle.TabIndex = 1;
            this.lblRevenueTitle.Text = "Toplam Gelir";
            // 
            // cardRez
            // 
            this.cardRez.BackColor = System.Drawing.Color.Transparent;
            this.cardRez.BorderRadius = 20;
            this.cardRez.Controls.Add(this.lblRezVal);
            this.cardRez.Controls.Add(this.lblRezTitle);
            this.cardRez.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cardRez.Location = new System.Drawing.Point(280, 100);
            this.cardRez.Name = "cardRez";
            this.cardRez.Size = new System.Drawing.Size(220, 150);
            this.cardRez.TabIndex = 1;
            // 
            // lblRezVal
            // 
            this.lblRezVal.AutoSize = true;
            this.lblRezVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRezVal.ForeColor = System.Drawing.Color.White;
            this.lblRezVal.Location = new System.Drawing.Point(20, 60);
            this.lblRezVal.Name = "lblRezVal";
            this.lblRezVal.Size = new System.Drawing.Size(35, 41);
            this.lblRezVal.TabIndex = 0;
            this.lblRezVal.Text = "0";
            // 
            // lblRezTitle
            // 
            this.lblRezTitle.AutoSize = true;
            this.lblRezTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRezTitle.ForeColor = System.Drawing.Color.White;
            this.lblRezTitle.Location = new System.Drawing.Point(10, 20);
            this.lblRezTitle.Name = "lblRezTitle";
            this.lblRezTitle.Size = new System.Drawing.Size(207, 28);
            this.lblRezTitle.TabIndex = 1;
            this.lblRezTitle.Text = "Toplam Rezervasyon";
            // 
            // cardFlight
            // 
            this.cardFlight.BackColor = System.Drawing.Color.Transparent;
            this.cardFlight.BorderRadius = 20;
            this.cardFlight.Controls.Add(this.lblFlightVal);
            this.cardFlight.Controls.Add(this.lblFlightTitle);
            this.cardFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.cardFlight.Location = new System.Drawing.Point(530, 100);
            this.cardFlight.Name = "cardFlight";
            this.cardFlight.Size = new System.Drawing.Size(220, 150);
            this.cardFlight.TabIndex = 2;
            // 
            // lblFlightVal
            // 
            this.lblFlightVal.AutoSize = true;
            this.lblFlightVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFlightVal.ForeColor = System.Drawing.Color.White;
            this.lblFlightVal.Location = new System.Drawing.Point(20, 60);
            this.lblFlightVal.Name = "lblFlightVal";
            this.lblFlightVal.Size = new System.Drawing.Size(35, 41);
            this.lblFlightVal.TabIndex = 0;
            this.lblFlightVal.Text = "0";
            // 
            // lblFlightTitle
            // 
            this.lblFlightTitle.AutoSize = true;
            this.lblFlightTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFlightTitle.ForeColor = System.Drawing.Color.White;
            this.lblFlightTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFlightTitle.Name = "lblFlightTitle";
            this.lblFlightTitle.Size = new System.Drawing.Size(132, 28);
            this.lblFlightTitle.TabIndex = 1;
            this.lblFlightTitle.Text = "Toplam Uçuş";
            // 
            // FrmReports
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardRevenue);
            this.Controls.Add(this.cardRez);
            this.Controls.Add(this.cardFlight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.cardRez.ResumeLayout(false);
            this.cardRez.PerformLayout();
            this.cardFlight.ResumeLayout(false);
            this.cardFlight.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel cardRevenue;
        private System.Windows.Forms.Label lblRevenueVal;
        private System.Windows.Forms.Label lblRevenueTitle;
        private Guna.UI2.WinForms.Guna2Panel cardRez;
        private System.Windows.Forms.Label lblRezVal;
        private System.Windows.Forms.Label lblRezTitle;
        private Guna.UI2.WinForms.Guna2Panel cardFlight;
        private System.Windows.Forms.Label lblFlightVal;
        private System.Windows.Forms.Label lblFlightTitle;
    }
}