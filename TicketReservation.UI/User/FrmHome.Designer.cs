namespace TicketReservation.UI
{
    partial class FrmHome
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
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSearchFlight = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnMyReservations = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(800, 70);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(24, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(252, 32);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Bilet Satış Platformu";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(743, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 1;
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.BorderRadius = 15;
            this.btnSearchFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchFlight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSearchFlight.ForeColor = System.Drawing.Color.White;
            this.btnSearchFlight.Location = new System.Drawing.Point(135, 149);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Size = new System.Drawing.Size(200, 180);
            this.btnSearchFlight.TabIndex = 1;
            this.btnSearchFlight.Text = "Bilet Ara\r\n&\r\nRezervasyon Yap";
            this.btnSearchFlight.Click += new System.EventHandler(this.btnSearchFlight_Click);
            // 
            // btnMyReservations
            // 
            this.btnMyReservations.BorderRadius = 15;
            this.btnMyReservations.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyReservations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyReservations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyReservations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyReservations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnMyReservations.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMyReservations.ForeColor = System.Drawing.Color.White;
            this.btnMyReservations.Location = new System.Drawing.Point(465, 149);
            this.btnMyReservations.Name = "btnMyReservations";
            this.btnMyReservations.Size = new System.Drawing.Size(200, 180);
            this.btnMyReservations.TabIndex = 2;
            this.btnMyReservations.Text = "Rezervasyonlarım";
            this.btnMyReservations.Click += new System.EventHandler(this.btnMyReservations_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 10;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(325, 400);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 45);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(321, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yapmak istediğiniz işlem";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMyReservations);
            this.Controls.Add(this.btnSearchFlight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2TileButton btnMyReservations;
        private Guna.UI2.WinForms.Guna2TileButton btnSearchFlight;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.Label label1;
    }
}