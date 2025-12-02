namespace TicketReservation.UI
{
    partial class FrmViewRezervastion
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
            this.dataGridViewRezervastions = new System.Windows.Forms.DataGridView();
            this.UcusNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalkisYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarisYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervastions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezervastions
            // 
            this.dataGridViewRezervastions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRezervastions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervastions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcusNo,
            this.KalkisYeri,
            this.VarisYeri,
            this.Tarih,
            this.Saat,
            this.Fiyat});
            this.dataGridViewRezervastions.Location = new System.Drawing.Point(259, 38);
            this.dataGridViewRezervastions.Name = "dataGridViewRezervastions";
            this.dataGridViewRezervastions.RowHeadersWidth = 51;
            this.dataGridViewRezervastions.Size = new System.Drawing.Size(655, 252);
            this.dataGridViewRezervastions.TabIndex = 7;
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
            // FrmViewRezervastion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 541);
            this.Controls.Add(this.dataGridViewRezervastions);
            this.Name = "FrmViewRezervastion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchFlight";
            this.Load += new System.EventHandler(this.FrmViewRezervastion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervastions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezervastions;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcusNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalkisYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarisYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}