namespace TicketReservation.UI.Admin
{
    partial class FrmFlights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.UcusNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalkisYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarisYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemelFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddFlight = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteFlight = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateFlight = new Guna.UI2.WinForms.Guna2Button();
            this.txtUcusNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTemelFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKalkisYeri = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVarisYeri = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTarih = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtUcakId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSaat = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFlights.ColumnHeadersHeight = 30;
            this.dataGridViewFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcusNo,
            this.KalkisYeri,
            this.VarisYeri,
            this.Tarih,
            this.Saat,
            this.TemelFiyat,
            this.UcakId});
            this.dataGridViewFlights.Location = new System.Drawing.Point(203, 39);
            this.dataGridViewFlights.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.RowHeadersWidth = 51;
            this.dataGridViewFlights.RowTemplate.Height = 24;
            this.dataGridViewFlights.Size = new System.Drawing.Size(753, 319);
            this.dataGridViewFlights.TabIndex = 0;
            this.dataGridViewFlights.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFlights_CellMouseClick);
            // 
            // UcusNo
            // 
            this.UcusNo.DataPropertyName = "UcusId";
            this.UcusNo.HeaderText = "Ucus No";
            this.UcusNo.MinimumWidth = 6;
            this.UcusNo.Name = "UcusNo";
            // 
            // KalkisYeri
            // 
            this.KalkisYeri.DataPropertyName = "KalkisYeri";
            this.KalkisYeri.HeaderText = "Kalkis Yeri";
            this.KalkisYeri.MinimumWidth = 6;
            this.KalkisYeri.Name = "KalkisYeri";
            // 
            // VarisYeri
            // 
            this.VarisYeri.DataPropertyName = "VarisYeri";
            this.VarisYeri.HeaderText = "Varis Yeri";
            this.VarisYeri.MinimumWidth = 6;
            this.VarisYeri.Name = "VarisYeri";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            // 
            // Saat
            // 
            this.Saat.DataPropertyName = "Saat";
            this.Saat.HeaderText = "Saat";
            this.Saat.MinimumWidth = 6;
            this.Saat.Name = "Saat";
            // 
            // TemelFiyat
            // 
            this.TemelFiyat.DataPropertyName = "TemelFiyat";
            this.TemelFiyat.HeaderText = "TemelFiyat";
            this.TemelFiyat.MinimumWidth = 6;
            this.TemelFiyat.Name = "TemelFiyat";
            // 
            // UcakId
            // 
            this.UcakId.DataPropertyName = "UcakId";
            this.UcakId.HeaderText = "Ucak Id";
            this.UcakId.MinimumWidth = 6;
            this.UcakId.Name = "UcakId";
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BorderRadius = 10;
            this.btnAddFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFlight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddFlight.Location = new System.Drawing.Point(233, 468);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(135, 37);
            this.btnAddFlight.TabIndex = 1;
            this.btnAddFlight.Text = "Ucus Ekle";
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.BorderRadius = 10;
            this.btnDeleteFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteFlight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteFlight.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFlight.Location = new System.Drawing.Point(499, 468);
            this.btnDeleteFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(135, 37);
            this.btnDeleteFlight.TabIndex = 2;
            this.btnDeleteFlight.Text = "Ucusu Sil";
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // btnUpdateFlight
            // 
            this.btnUpdateFlight.BorderRadius = 10;
            this.btnUpdateFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateFlight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateFlight.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFlight.Location = new System.Drawing.Point(756, 468);
            this.btnUpdateFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateFlight.Name = "btnUpdateFlight";
            this.btnUpdateFlight.Size = new System.Drawing.Size(135, 37);
            this.btnUpdateFlight.TabIndex = 3;
            this.btnUpdateFlight.Text = "Ucusu Guncelle";
            this.btnUpdateFlight.Click += new System.EventHandler(this.btnUpdateFlight_Click);
            // 
            // txtUcusNo
            // 
            this.txtUcusNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUcusNo.DefaultText = "";
            this.txtUcusNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUcusNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUcusNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUcusNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUcusNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUcusNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUcusNo.ForeColor = System.Drawing.Color.Black;
            this.txtUcusNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUcusNo.Location = new System.Drawing.Point(286, 382);
            this.txtUcusNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUcusNo.Name = "txtUcusNo";
            this.txtUcusNo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtUcusNo.PlaceholderText = "Ucus No";
            this.txtUcusNo.ReadOnly = true;
            this.txtUcusNo.SelectedText = "";
            this.txtUcusNo.Size = new System.Drawing.Size(189, 24);
            this.txtUcusNo.TabIndex = 4;
            // 
            // txtTemelFiyat
            // 
            this.txtTemelFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTemelFiyat.DefaultText = "";
            this.txtTemelFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTemelFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTemelFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTemelFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTemelFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTemelFiyat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTemelFiyat.ForeColor = System.Drawing.Color.Black;
            this.txtTemelFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTemelFiyat.Location = new System.Drawing.Point(619, 422);
            this.txtTemelFiyat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTemelFiyat.Name = "txtTemelFiyat";
            this.txtTemelFiyat.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTemelFiyat.PlaceholderText = "Temel Fiyat";
            this.txtTemelFiyat.SelectedText = "";
            this.txtTemelFiyat.Size = new System.Drawing.Size(135, 24);
            this.txtTemelFiyat.TabIndex = 6;
            // 
            // txtKalkisYeri
            // 
            this.txtKalkisYeri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKalkisYeri.DefaultText = "";
            this.txtKalkisYeri.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKalkisYeri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKalkisYeri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKalkisYeri.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKalkisYeri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKalkisYeri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKalkisYeri.ForeColor = System.Drawing.Color.Black;
            this.txtKalkisYeri.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKalkisYeri.Location = new System.Drawing.Point(499, 382);
            this.txtKalkisYeri.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtKalkisYeri.Name = "txtKalkisYeri";
            this.txtKalkisYeri.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtKalkisYeri.PlaceholderText = "Kalkis Yeri";
            this.txtKalkisYeri.SelectedText = "";
            this.txtKalkisYeri.Size = new System.Drawing.Size(135, 24);
            this.txtKalkisYeri.TabIndex = 7;
            // 
            // txtVarisYeri
            // 
            this.txtVarisYeri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVarisYeri.DefaultText = "";
            this.txtVarisYeri.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVarisYeri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVarisYeri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVarisYeri.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVarisYeri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVarisYeri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVarisYeri.ForeColor = System.Drawing.Color.Black;
            this.txtVarisYeri.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVarisYeri.Location = new System.Drawing.Point(673, 382);
            this.txtVarisYeri.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVarisYeri.Name = "txtVarisYeri";
            this.txtVarisYeri.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtVarisYeri.PlaceholderText = "Varis Yeri";
            this.txtVarisYeri.SelectedText = "";
            this.txtVarisYeri.Size = new System.Drawing.Size(135, 24);
            this.txtVarisYeri.TabIndex = 8;
            // 
            // txtTarih
            // 
            this.txtTarih.Checked = true;
            this.txtTarih.FillColor = System.Drawing.Color.White;
            this.txtTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTarih.Location = new System.Drawing.Point(232, 426);
            this.txtTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(189, 20);
            this.txtTarih.TabIndex = 11;
            this.txtTarih.Value = new System.DateTime(2025, 11, 29, 14, 41, 22, 330);
            // 
            // txtUcakId
            // 
            this.txtUcakId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUcakId.DefaultText = "";
            this.txtUcakId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUcakId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUcakId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUcakId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUcakId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUcakId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUcakId.ForeColor = System.Drawing.Color.Black;
            this.txtUcakId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUcakId.Location = new System.Drawing.Point(768, 422);
            this.txtUcakId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUcakId.Name = "txtUcakId";
            this.txtUcakId.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtUcakId.PlaceholderText = "Ucak Id";
            this.txtUcakId.SelectedText = "";
            this.txtUcakId.Size = new System.Drawing.Size(135, 24);
            this.txtUcakId.TabIndex = 12;
            // 
            // txtSaat
            // 
            this.txtSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtSaat.Location = new System.Drawing.Point(439, 426);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(155, 20);
            this.txtSaat.TabIndex = 13;
            // 
            // FrmFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 541);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.txtUcakId);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtVarisYeri);
            this.Controls.Add(this.txtKalkisYeri);
            this.Controls.Add(this.txtTemelFiyat);
            this.Controls.Add(this.txtUcusNo);
            this.Controls.Add(this.btnUpdateFlight);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.dataGridViewFlights);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFlights";
            this.Load += new System.EventHandler(this.FrmFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private Guna.UI2.WinForms.Guna2Button btnAddFlight;
        private Guna.UI2.WinForms.Guna2Button btnDeleteFlight;
        private Guna.UI2.WinForms.Guna2Button btnUpdateFlight;
        private Guna.UI2.WinForms.Guna2TextBox txtUcusNo;
        private Guna.UI2.WinForms.Guna2TextBox txtTemelFiyat;
        private Guna.UI2.WinForms.Guna2TextBox txtKalkisYeri;
        private Guna.UI2.WinForms.Guna2TextBox txtVarisYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcusNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalkisYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarisYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemelFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcakId;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTarih;
        private Guna.UI2.WinForms.Guna2TextBox txtUcakId;
        private System.Windows.Forms.DateTimePicker txtSaat;
    }
}