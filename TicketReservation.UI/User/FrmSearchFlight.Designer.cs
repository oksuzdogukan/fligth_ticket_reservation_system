namespace TicketReservation.UI
{
    partial class FrmSearchFlight
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPickSeat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboKalkis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboVaris = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUcusAra = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.labelKalkis = new System.Windows.Forms.Label();
            this.labelVaris = new System.Windows.Forms.Label();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvFlights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelUcuslar = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPickSeat
            // 
            this.btnPickSeat.BorderRadius = 10;
            this.btnPickSeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPickSeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPickSeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPickSeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPickSeat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPickSeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPickSeat.ForeColor = System.Drawing.Color.White;
            this.btnPickSeat.Location = new System.Drawing.Point(400, 597);
            this.btnPickSeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPickSeat.Name = "btnPickSeat";
            this.btnPickSeat.Size = new System.Drawing.Size(293, 62);
            this.btnPickSeat.TabIndex = 10;
            this.btnPickSeat.Text = "KOLTUK SEÇ";
            this.btnPickSeat.Click += new System.EventHandler(this.btnPickSeat_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panelLeft.Controls.Add(this.labelBrand);
            this.panelLeft.Controls.Add(this.comboKalkis);
            this.panelLeft.Controls.Add(this.comboVaris);
            this.panelLeft.Controls.Add(this.btnUcusAra);
            this.panelLeft.Controls.Add(this.btnBack);
            this.panelLeft.Controls.Add(this.labelKalkis);
            this.panelLeft.Controls.Add(this.labelVaris);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(333, 738);
            this.panelLeft.TabIndex = 17;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelBrand.ForeColor = System.Drawing.Color.White;
            this.labelBrand.Location = new System.Drawing.Point(27, 37);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(170, 37);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "Uçuş Arama";
            // 
            // comboKalkis
            // 
            this.comboKalkis.BackColor = System.Drawing.Color.Transparent;
            this.comboKalkis.BorderRadius = 10;
            this.comboKalkis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboKalkis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKalkis.FocusedColor = System.Drawing.Color.Empty;
            this.comboKalkis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboKalkis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboKalkis.ItemHeight = 30;
            this.comboKalkis.Location = new System.Drawing.Point(33, 148);
            this.comboKalkis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboKalkis.Name = "comboKalkis";
            this.comboKalkis.Size = new System.Drawing.Size(265, 36);
            this.comboKalkis.TabIndex = 1;
            // 
            // comboVaris
            // 
            this.comboVaris.BackColor = System.Drawing.Color.Transparent;
            this.comboVaris.BorderRadius = 10;
            this.comboVaris.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboVaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVaris.FocusedColor = System.Drawing.Color.Empty;
            this.comboVaris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboVaris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboVaris.ItemHeight = 30;
            this.comboVaris.Location = new System.Drawing.Point(33, 234);
            this.comboVaris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboVaris.Name = "comboVaris";
            this.comboVaris.Size = new System.Drawing.Size(265, 36);
            this.comboVaris.TabIndex = 2;
            // 
            // btnUcusAra
            // 
            this.btnUcusAra.BorderRadius = 10;
            this.btnUcusAra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUcusAra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUcusAra.ForeColor = System.Drawing.Color.White;
            this.btnUcusAra.Location = new System.Drawing.Point(33, 308);
            this.btnUcusAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUcusAra.Name = "btnUcusAra";
            this.btnUcusAra.Size = new System.Drawing.Size(267, 55);
            this.btnUcusAra.TabIndex = 3;
            this.btnUcusAra.Text = "UÇUŞ BUL";
            this.btnUcusAra.Click += new System.EventHandler(this.btnUcusAra_Click);
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(33, 652);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(267, 55);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "GERİ DÖN";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelKalkis
            // 
            this.labelKalkis.AutoSize = true;
            this.labelKalkis.ForeColor = System.Drawing.Color.LightGray;
            this.labelKalkis.Location = new System.Drawing.Point(29, 123);
            this.labelKalkis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKalkis.Name = "labelKalkis";
            this.labelKalkis.Size = new System.Drawing.Size(70, 16);
            this.labelKalkis.TabIndex = 5;
            this.labelKalkis.Text = "Kalkış Yeri";
            // 
            // labelVaris
            // 
            this.labelVaris.AutoSize = true;
            this.labelVaris.ForeColor = System.Drawing.Color.LightGray;
            this.labelVaris.Location = new System.Drawing.Point(29, 209);
            this.labelVaris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVaris.Name = "labelVaris";
            this.labelVaris.Size = new System.Drawing.Size(65, 16);
            this.labelVaris.TabIndex = 6;
            this.labelVaris.Text = "Varış Yeri";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.labelPageTitle);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(333, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1267, 62);
            this.panelTop.TabIndex = 16;
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelPageTitle.ForeColor = System.Drawing.Color.Gray;
            this.labelPageTitle.Location = new System.Drawing.Point(360, 18);
            this.labelPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(317, 28);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "Müsait Uçuşlar ve Koltuk Seçimi";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(1520, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 36);
            this.btnClose.TabIndex = 1;
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlights.ColumnHeadersHeight = 30;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlights.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFlights.Location = new System.Drawing.Point(360, 117);
            this.dgvFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersVisible = false;
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.Size = new System.Drawing.Size(800, 246);
            this.dgvFlights.TabIndex = 14;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFlights.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlights.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFlights.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFlights.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFlights.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFlights.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFlights.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFlights.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvFlights.ThemeStyle.ReadOnly = true;
            this.dgvFlights.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlights.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFlights.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFlights.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFlights.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFlights.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFlights.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // labelUcuslar
            // 
            this.labelUcuslar.AutoSize = true;
            this.labelUcuslar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelUcuslar.Location = new System.Drawing.Point(360, 86);
            this.labelUcuslar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUcuslar.Name = "labelUcuslar";
            this.labelUcuslar.Size = new System.Drawing.Size(138, 23);
            this.labelUcuslar.TabIndex = 15;
            this.labelUcuslar.Text = "Bulunan Uçuşlar";
            // 
            // FrmSearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 738);
            this.Controls.Add(this.btnPickSeat);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.labelUcuslar);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSearchFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçuş Arama";
            this.Load += new System.EventHandler(this.FrmSearchFlight_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPickSeat;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label labelBrand;
        private Guna.UI2.WinForms.Guna2ComboBox comboKalkis;
        private Guna.UI2.WinForms.Guna2ComboBox comboVaris;
        private Guna.UI2.WinForms.Guna2Button btnUcusAra;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label labelKalkis;
        private System.Windows.Forms.Label labelVaris;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label labelPageTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFlights;
        private System.Windows.Forms.Label labelUcuslar;
    }
}