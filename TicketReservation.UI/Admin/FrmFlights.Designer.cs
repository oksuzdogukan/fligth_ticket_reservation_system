namespace TicketReservation.UI.Admin
{
    partial class FrmFlights
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelInputs = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtUcusNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKalkisYeri = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVarisYeri = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpTarih = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.txtTemelFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUcakId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button(); // YENİ BUTON
            this.labelSaat = new System.Windows.Forms.Label();
            this.dgvFlights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panelInputs.Controls.Add(this.labelSaat);
            this.panelInputs.Controls.Add(this.btnClear);
            this.panelInputs.Controls.Add(this.btnDelete);
            this.panelInputs.Controls.Add(this.btnUpdate);
            this.panelInputs.Controls.Add(this.btnAdd);
            this.panelInputs.Controls.Add(this.btnBack); // Panele Ekle
            this.panelInputs.Controls.Add(this.txtUcakId);
            this.panelInputs.Controls.Add(this.txtTemelFiyat);
            this.panelInputs.Controls.Add(this.dtpSaat);
            this.panelInputs.Controls.Add(this.dtpTarih);
            this.panelInputs.Controls.Add(this.txtVarisYeri);
            this.panelInputs.Controls.Add(this.txtKalkisYeri);
            this.panelInputs.Controls.Add(this.txtUcusNo);
            this.panelInputs.Controls.Add(this.labelTitle);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInputs.Location = new System.Drawing.Point(0, 0);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(300, 600);
            this.panelInputs.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(163, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Uçuş Yönetimi";
            // 
            // txtUcusNo
            // 
            this.txtUcusNo.BorderRadius = 10;
            this.txtUcusNo.Enabled = false;
            this.txtUcusNo.Location = new System.Drawing.Point(25, 90);
            this.txtUcusNo.Name = "txtUcusNo";
            this.txtUcusNo.PlaceholderText = "Uçuş No (Otomatik)";
            this.txtUcusNo.Size = new System.Drawing.Size(250, 36);
            this.txtUcusNo.TabIndex = 1;
            // 
            // txtKalkisYeri
            // 
            this.txtKalkisYeri.BorderRadius = 10;
            this.txtKalkisYeri.Location = new System.Drawing.Point(25, 140);
            this.txtKalkisYeri.Name = "txtKalkisYeri";
            this.txtKalkisYeri.PlaceholderText = "Kalkış Yeri";
            this.txtKalkisYeri.Size = new System.Drawing.Size(250, 36);
            this.txtKalkisYeri.TabIndex = 2;
            // 
            // txtVarisYeri
            // 
            this.txtVarisYeri.BorderRadius = 10;
            this.txtVarisYeri.Location = new System.Drawing.Point(25, 190);
            this.txtVarisYeri.Name = "txtVarisYeri";
            this.txtVarisYeri.PlaceholderText = "Varış Yeri";
            this.txtVarisYeri.Size = new System.Drawing.Size(250, 36);
            this.txtVarisYeri.TabIndex = 3;
            // 
            // dtpTarih
            // 
            this.dtpTarih.BorderRadius = 10;
            this.dtpTarih.FillColor = System.Drawing.Color.White;
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTarih.Location = new System.Drawing.Point(25, 240);
            this.dtpTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(250, 36);
            this.dtpTarih.TabIndex = 4;
            this.dtpTarih.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // dtpSaat
            // 
            this.dtpSaat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(80, 290);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(195, 27);
            this.dtpSaat.TabIndex = 5;
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSaat.ForeColor = System.Drawing.Color.White;
            this.labelSaat.Location = new System.Drawing.Point(25, 294);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(42, 19);
            this.labelSaat.TabIndex = 6;
            this.labelSaat.Text = "Saat:";
            // 
            // txtTemelFiyat
            // 
            this.txtTemelFiyat.BorderRadius = 10;
            this.txtTemelFiyat.Location = new System.Drawing.Point(25, 330);
            this.txtTemelFiyat.Name = "txtTemelFiyat";
            this.txtTemelFiyat.PlaceholderText = "Temel Fiyat (TL)";
            this.txtTemelFiyat.Size = new System.Drawing.Size(250, 36);
            this.txtTemelFiyat.TabIndex = 7;
            // 
            // txtUcakId
            // 
            this.txtUcakId.BorderRadius = 10;
            this.txtUcakId.Location = new System.Drawing.Point(25, 380);
            this.txtUcakId.Name = "txtUcakId";
            this.txtUcakId.PlaceholderText = "Uçak ID (Örn: 1)";
            this.txtUcakId.Size = new System.Drawing.Size(250, 36);
            this.txtUcakId.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(160, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 40);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateFlight_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(25, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "SİL";
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 10;
            this.btnClear.FillColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(160, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "TEMİZLE";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack (YENİ)
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(25, 550);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(250, 40);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "GERİ DÖN";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvFlights
            // 
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlights.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFlights.Location = new System.Drawing.Point(320, 60);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersVisible = false;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.Size = new System.Drawing.Size(660, 520);
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
            this.dgvFlights.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFlights_CellMouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(950, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 15;
            // 
            // FrmFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.panelInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçuş Yönetimi";
            this.Load += new System.EventHandler(this.FrmFlights_Load);
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelInputs;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtUcusNo;
        private Guna.UI2.WinForms.Guna2TextBox txtKalkisYeri;
        private Guna.UI2.WinForms.Guna2TextBox txtVarisYeri;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTarih;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private Guna.UI2.WinForms.Guna2TextBox txtTemelFiyat;
        private Guna.UI2.WinForms.Guna2TextBox txtUcakId;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label labelSaat;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFlights;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
    }
}