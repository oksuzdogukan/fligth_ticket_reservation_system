namespace TicketReservation.UI.UserUI
{
    partial class FrmSeatSelection
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
            this.panelLegend = new Guna.UI2.WinForms.Guna2Panel();
            this.labelLegend1 = new System.Windows.Forms.Label();
            this.boxBusiness = new Guna.UI2.WinForms.Guna2Panel();
            this.labelLegend2 = new System.Windows.Forms.Label();
            this.boxEconomy = new Guna.UI2.WinForms.Guna2Panel();
            this.labelLegend3 = new System.Windows.Forms.Label();
            this.boxFull = new Guna.UI2.WinForms.Guna2Panel();
            this.labelLegend4 = new System.Windows.Forms.Label();
            this.boxSelected = new Guna.UI2.WinForms.Guna2Panel();
            this.flowSeatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSeatInfo = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            this.guna2Elipse1.BorderRadius = 15;

            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(500, 60);
            this.panelTop.TabIndex = 0;

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(133, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Koltuk Seçimi";

            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(443, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 0;

            // 
            // panelLegend (Bilgi Çubuğu)
            // 
            this.panelLegend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLegend.Controls.Add(this.labelLegend4);
            this.panelLegend.Controls.Add(this.boxSelected);
            this.panelLegend.Controls.Add(this.labelLegend3);
            this.panelLegend.Controls.Add(this.boxFull);
            this.panelLegend.Controls.Add(this.labelLegend2);
            this.panelLegend.Controls.Add(this.boxEconomy);
            this.panelLegend.Controls.Add(this.labelLegend1);
            this.panelLegend.Controls.Add(this.boxBusiness);
            this.panelLegend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLegend.Location = new System.Drawing.Point(0, 60);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(500, 40);
            this.panelLegend.TabIndex = 1;

            // Legend Items (Renk kutucukları)
            this.boxBusiness.BackColor = System.Drawing.Color.Gold;
            this.boxBusiness.Location = new System.Drawing.Point(20, 12);
            this.boxBusiness.Size = new System.Drawing.Size(15, 15);

            this.labelLegend1.AutoSize = true;
            this.labelLegend1.Location = new System.Drawing.Point(40, 12);
            this.labelLegend1.Text = "Business";

            this.boxEconomy.BackColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.boxEconomy.Location = new System.Drawing.Point(110, 12);
            this.boxEconomy.Size = new System.Drawing.Size(15, 15);

            this.labelLegend2.AutoSize = true;
            this.labelLegend2.Location = new System.Drawing.Point(130, 12);
            this.labelLegend2.Text = "Ekonomi";

            this.boxFull.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.boxFull.Location = new System.Drawing.Point(200, 12);
            this.boxFull.Size = new System.Drawing.Size(15, 15);

            this.labelLegend3.AutoSize = true;
            this.labelLegend3.Location = new System.Drawing.Point(220, 12);
            this.labelLegend3.Text = "Dolu";

            this.boxSelected.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.boxSelected.Location = new System.Drawing.Point(270, 12);
            this.boxSelected.Size = new System.Drawing.Size(15, 15);

            this.labelLegend4.AutoSize = true;
            this.labelLegend4.Location = new System.Drawing.Point(290, 12);
            this.labelLegend4.Text = "Seçili";

            // 
            // flowSeatPanel
            // 
            this.flowSeatPanel.AutoScroll = true;
            this.flowSeatPanel.BackColor = System.Drawing.Color.White;
            this.flowSeatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSeatPanel.Location = new System.Drawing.Point(0, 100);
            this.flowSeatPanel.Padding = new System.Windows.Forms.Padding(35, 20, 0, 20); // Ortalama
            this.flowSeatPanel.Name = "flowSeatPanel";
            this.flowSeatPanel.Size = new System.Drawing.Size(500, 500);
            this.flowSeatPanel.TabIndex = 2;

            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnConfirm);
            this.panelBottom.Controls.Add(this.lblTotalPrice);
            this.panelBottom.Controls.Add(this.lblSeatInfo);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 600);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(500, 100);
            this.panelBottom.TabIndex = 3;

            // 
            // lblSeatInfo
            // 
            this.lblSeatInfo.AutoSize = true;
            this.lblSeatInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSeatInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSeatInfo.Location = new System.Drawing.Point(20, 15);
            this.lblSeatInfo.Name = "lblSeatInfo";
            this.lblSeatInfo.Size = new System.Drawing.Size(149, 19);
            this.lblSeatInfo.TabIndex = 0;
            this.lblSeatInfo.Text = "Lütfen bir koltuk seçiniz.";

            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 45);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(71, 30);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "0.00 ₺";

            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.FillColor = System.Drawing.Color.Gray;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(320, 30);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 45);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "ONAYLA";
            this.btnConfirm.Enabled = false; // Başta pasif
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // 
            // FrmSeatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.flowSeatPanel);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelLegend);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeatSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koltuk Seçimi";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLegend.ResumeLayout(false);
            this.panelLegend.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel panelLegend;
        private Guna.UI2.WinForms.Guna2Panel boxBusiness;
        private System.Windows.Forms.Label labelLegend1;
        private Guna.UI2.WinForms.Guna2Panel boxEconomy;
        private System.Windows.Forms.Label labelLegend2;
        private Guna.UI2.WinForms.Guna2Panel boxFull;
        private System.Windows.Forms.Label labelLegend3;
        private Guna.UI2.WinForms.Guna2Panel boxSelected;
        private System.Windows.Forms.Label labelLegend4;
        private System.Windows.Forms.FlowLayoutPanel flowSeatPanel;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSeatInfo;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
    }
}