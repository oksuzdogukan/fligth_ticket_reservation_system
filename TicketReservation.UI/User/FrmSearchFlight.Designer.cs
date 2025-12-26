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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();

            this.btnPickSeat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboKalkis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboVaris = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUcusAra = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button(); // YENİ BUTON
            this.labelKalkis = new System.Windows.Forms.Label();
            this.labelVaris = new System.Windows.Forms.Label();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvFlights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvKoltuklar = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRezervasyonYap = new Guna.UI2.WinForms.Guna2Button();
            this.labelUcuslar = new System.Windows.Forms.Label();
            this.labelKoltuklar = new System.Windows.Forms.Label();

            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoltuklar)).BeginInit();
            this.SuspendLayout();

            // 
            // btnPickSeat (KOLTUK SEÇ BUTONU)
            // 
            this.btnPickSeat.BorderRadius = 10;
            this.btnPickSeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPickSeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPickSeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPickSeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPickSeat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPickSeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPickSeat.ForeColor = System.Drawing.Color.White;
            this.btnPickSeat.Location = new System.Drawing.Point(300, 485);
            this.btnPickSeat.Name = "btnPickSeat";
            this.btnPickSeat.Size = new System.Drawing.Size(220, 50);
            this.btnPickSeat.TabIndex = 10;
            this.btnPickSeat.Text = "KOLTUK SEÇ";
            this.btnPickSeat.Click += new System.EventHandler(this.btnPickSeat_Click);

            // guna2Elipse1
            this.guna2Elipse1.TargetControl = this;

            // panelLeft
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(42, 54, 80);
            this.panelLeft.Controls.Add(this.labelBrand);
            this.panelLeft.Controls.Add(this.comboKalkis);
            this.panelLeft.Controls.Add(this.comboVaris);
            this.panelLeft.Controls.Add(this.btnUcusAra);
            this.panelLeft.Controls.Add(this.btnBack); // Panele ekle
            this.panelLeft.Controls.Add(this.labelKalkis);
            this.panelLeft.Controls.Add(this.labelVaris);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Size = new System.Drawing.Size(250, 600);

            // labelBrand
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelBrand.ForeColor = System.Drawing.Color.White;
            this.labelBrand.Location = new System.Drawing.Point(20, 30);
            this.labelBrand.Text = "Uçuş Arama";

            // labelKalkis
            this.labelKalkis.AutoSize = true;
            this.labelKalkis.ForeColor = System.Drawing.Color.LightGray;
            this.labelKalkis.Location = new System.Drawing.Point(22, 100);
            this.labelKalkis.Text = "Kalkış Yeri";

            // comboKalkis
            this.comboKalkis.BorderRadius = 10;
            this.comboKalkis.Location = new System.Drawing.Point(25, 120);
            this.comboKalkis.Size = new System.Drawing.Size(200, 36);

            // labelVaris
            this.labelVaris.AutoSize = true;
            this.labelVaris.ForeColor = System.Drawing.Color.LightGray;
            this.labelVaris.Location = new System.Drawing.Point(22, 170);
            this.labelVaris.Text = "Varış Yeri";

            // comboVaris
            this.comboVaris.BorderRadius = 10;
            this.comboVaris.Location = new System.Drawing.Point(25, 190);
            this.comboVaris.Size = new System.Drawing.Size(200, 36);

            // btnUcusAra
            // 
            this.btnUcusAra.BorderRadius = 10;
            this.btnUcusAra.FillColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnUcusAra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUcusAra.ForeColor = System.Drawing.Color.White;
            this.btnUcusAra.Location = new System.Drawing.Point(25, 250);
            this.btnUcusAra.Size = new System.Drawing.Size(200, 45);
            this.btnUcusAra.Text = "UÇUŞ BUL";
            this.btnUcusAra.Click += new System.EventHandler(this.btnUcusAra_Click);

            // btnBack (YENİ BUTON)
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(25, 530); // En alta koyduk
            this.btnBack.Size = new System.Drawing.Size(200, 45);
            this.btnBack.Text = "GERİ DÖN";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // panelTop ve diğer bileşenler aynı...
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.labelPageTitle);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(950, 50);

            // labelPageTitle
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelPageTitle.ForeColor = System.Drawing.Color.Gray;
            this.labelPageTitle.Location = new System.Drawing.Point(270, 15);
            this.labelPageTitle.Text = "Müsait Uçuşlar ve Koltuk Seçimi";

            // btnClose
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(1140, 10);

            // labelUcuslar
            this.labelUcuslar.AutoSize = true;
            this.labelUcuslar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelUcuslar.Location = new System.Drawing.Point(270, 70);
            this.labelUcuslar.Text = "Bulunan Uçuşlar";

            // dgvFlights
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlights.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            this.dgvFlights.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlights.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvFlights.Location = new System.Drawing.Point(270, 95);
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersVisible = false;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.Size = new System.Drawing.Size(600, 200);
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFlights.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFlights.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlights.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvFlights.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            this.dgvFlights.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFlights.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFlights.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFlights.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFlights.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvFlights.ThemeStyle.ReadOnly = true;
            this.dgvFlights.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlights.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFlights.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFlights.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            this.dgvFlights.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFlights.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvFlights.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            //this.dgvFlights.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFlights_CellMouseClick);

            // labelKoltuklar
            this.labelKoltuklar.AutoSize = true;
            this.labelKoltuklar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelKoltuklar.Location = new System.Drawing.Point(270, 310);
            this.labelKoltuklar.Text = "Koltuk Seçimi (Yeşil: Boş, Kırmızı: Dolu)";

            // dgvKoltuklar
            this.dgvKoltuklar.AllowUserToAddRows = false;
            this.dgvKoltuklar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvKoltuklar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKoltuklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKoltuklar.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKoltuklar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKoltuklar.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvKoltuklar.Location = new System.Drawing.Point(270, 335);
            this.dgvKoltuklar.ReadOnly = true;
            this.dgvKoltuklar.RowHeadersVisible = false;
            this.dgvKoltuklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKoltuklar.Size = new System.Drawing.Size(350, 200);
            //this.dgvKoltuklar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKoltuklar_CellFormatting);
            //this.dgvKoltuklar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKoltuklar_CellMouseClick);

            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BorderRadius = 10;
            this.btnRezervasyonYap.FillColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(650, 485);
            this.btnRezervasyonYap.Size = new System.Drawing.Size(220, 50);
            this.btnRezervasyonYap.Text = "REZERVASYONU TAMAMLA";
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnPickSeat);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.dgvKoltuklar);
            this.Controls.Add(this.labelKoltuklar);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.labelUcuslar);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSearchFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçuş Arama";
            this.Load += new System.EventHandler(this.FrmSearchFlight_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoltuklar)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvKoltuklar;
        private Guna.UI2.WinForms.Guna2Button btnRezervasyonYap;
        private System.Windows.Forms.Label labelUcuslar;
        private System.Windows.Forms.Label labelKoltuklar;
    }
}