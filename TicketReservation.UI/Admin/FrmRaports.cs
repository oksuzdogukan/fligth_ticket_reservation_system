using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicketReservation.Business.Abstract;

namespace TicketReservation.UI.Admin
{
    public partial class FrmReports : Form
    {
        private readonly IRezervasyonService _rezervasyonService;

        public FrmReports(IRezervasyonService rezervasyonService)
        {
            InitializeComponent();
            _rezervasyonService = rezervasyonService;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                var veriler = _rezervasyonService.RaporGetir();

                lblRevenueVal.Text = veriler["ToplamGelir"].ToString() + " TL";
                lblRezVal.Text = veriler["ToplamRezervasyon"].ToString();
                lblFlightVal.Text = veriler["ToplamUcus"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata: " + ex.Message);
            }
        }

        
    }
}