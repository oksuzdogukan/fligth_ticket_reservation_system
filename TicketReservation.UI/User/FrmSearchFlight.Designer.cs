namespace TicketReservation.UI
{
    partial class FrmSearchFlight
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
            this.comboBoxKalkisYeri = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxVarisYeri = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRezervasyonYap = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.btnUcusAra = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewKoltuklar = new System.Windows.Forms.DataGridView();
            this.KoltukNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoluMu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcusNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalkisYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarisYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoltuklar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKalkisYeri
            // 
            this.comboBoxKalkisYeri.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxKalkisYeri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxKalkisYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKalkisYeri.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxKalkisYeri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxKalkisYeri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxKalkisYeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxKalkisYeri.ItemHeight = 30;
            this.comboBoxKalkisYeri.Location = new System.Drawing.Point(51, 92);
            this.comboBoxKalkisYeri.Name = "comboBoxKalkisYeri";
            this.comboBoxKalkisYeri.Size = new System.Drawing.Size(140, 36);
            this.comboBoxKalkisYeri.TabIndex = 0;
            // 
            // comboBoxVarisYeri
            // 
            this.comboBoxVarisYeri.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxVarisYeri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxVarisYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVarisYeri.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxVarisYeri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxVarisYeri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxVarisYeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxVarisYeri.ItemHeight = 30;
            this.comboBoxVarisYeri.Location = new System.Drawing.Point(274, 92);
            this.comboBoxVarisYeri.Name = "comboBoxVarisYeri";
            this.comboBoxVarisYeri.Size = new System.Drawing.Size(140, 36);
            this.comboBoxVarisYeri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kalkis Yeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(305, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Varis Yeri";
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BorderRadius = 10;
            this.btnRezervasyonYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRezervasyonYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRezervasyonYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRezervasyonYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(928, 313);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(135, 37);
            this.btnRezervasyonYap.TabIndex = 5;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcusNo,
            this.KalkisYeri,
            this.VarisYeri,
            this.Tarih,
            this.Saat,
            this.Fiyat});
            this.dataGridViewFlights.Location = new System.Drawing.Point(500, 22);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.RowHeadersWidth = 51;
            this.dataGridViewFlights.Size = new System.Drawing.Size(653, 252);
            this.dataGridViewFlights.TabIndex = 6;
            this.dataGridViewFlights.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFlights_CellMouseClick);
            // 
            // btnUcusAra
            // 
            this.btnUcusAra.BorderRadius = 10;
            this.btnUcusAra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUcusAra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUcusAra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUcusAra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUcusAra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUcusAra.ForeColor = System.Drawing.Color.White;
            this.btnUcusAra.Location = new System.Drawing.Point(170, 176);
            this.btnUcusAra.Name = "btnUcusAra";
            this.btnUcusAra.Size = new System.Drawing.Size(135, 37);
            this.btnUcusAra.TabIndex = 7;
            this.btnUcusAra.Text = "Ucus Ara";
            this.btnUcusAra.Click += new System.EventHandler(this.btnUcusAra_Click);
            // 
            // dataGridViewKoltuklar
            // 
            this.dataGridViewKoltuklar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKoltuklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKoltuklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KoltukNo,
            this.DoluMu});
            this.dataGridViewKoltuklar.Location = new System.Drawing.Point(500, 291);
            this.dataGridViewKoltuklar.Name = "dataGridViewKoltuklar";
            this.dataGridViewKoltuklar.RowHeadersWidth = 51;
            this.dataGridViewKoltuklar.Size = new System.Drawing.Size(355, 152);
            this.dataGridViewKoltuklar.TabIndex = 8;
            this.dataGridViewKoltuklar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewKoltuklar_CellFormatting);
            this.dataGridViewKoltuklar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKoltuklar_CellMouseClick);
            // 
            // KoltukNo
            // 
            this.KoltukNo.DataPropertyName = "KoltukNo";
            this.KoltukNo.HeaderText = "Koltuk No";
            this.KoltukNo.MinimumWidth = 6;
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.Width = 150;
            // 
            // DoluMu
            // 
            this.DoluMu.DataPropertyName = "DoluMu";
            this.DoluMu.HeaderText = "Doluluk Durumu";
            this.DoluMu.MinimumWidth = 6;
            this.DoluMu.Name = "DoluMu";
            this.DoluMu.Width = 150;
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
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "SatisFiyati";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            // 
            // FrmSearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 541);
            this.Controls.Add(this.dataGridViewKoltuklar);
            this.Controls.Add(this.btnUcusAra);
            this.Controls.Add(this.dataGridViewFlights);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVarisYeri);
            this.Controls.Add(this.comboBoxKalkisYeri);
            this.Name = "FrmSearchFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViewRezervation";
            this.Load += new System.EventHandler(this.FrmViewRezervation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoltuklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxKalkisYeri;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxVarisYeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnRezervasyonYap;
        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private Guna.UI2.WinForms.Guna2Button btnUcusAra;
        private System.Windows.Forms.DataGridView dataGridViewKoltuklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoltukNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoluMu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcusNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalkisYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarisYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}