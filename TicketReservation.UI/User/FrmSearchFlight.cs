using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketReservation.Business.Abstract;
using TicketReservation.Models;

namespace TicketReservation.UI
{
    public partial class FrmSearchFlight : Form
    {

        private readonly IUcusService _ucusService; // business katmaniyla iletisim icin
        private readonly IRezervasyonService _rezervasyonService; // business katmaniyla iletisim icin
        private readonly IKoltukService _koltukService; // business katmaniyla iletisim icin

        // rezervasyon icin gerekenler
        private int _secilenUcusId = 0; 
        private int _secilenKoltukNo = 0;

        public FrmSearchFlight(IUcusService ucusService, IRezervasyonService rezervasyonService, IKoltukService koltukService)
        {
            _ucusService = ucusService;
            _rezervasyonService = rezervasyonService;
            _koltukService = koltukService;
            InitializeComponent();
        }

        private void FrmViewRezervation_Load(object sender, EventArgs e)
        {
            var tumUcuslar = _ucusService.UcusListele();

            // kalkis yerlerini comboBoxa koy
            comboBoxKalkisYeri.Items.Clear();
            comboBoxKalkisYeri.Items.AddRange(
                tumUcuslar.Select(u => u.KalkisYeri).Distinct().ToArray() // Distinc() ayni sehirleri tekrar gostermemek icin
                );

            // Varis yerlerini comboBoxa koy
            comboBoxVarisYeri.Items.Clear();
            comboBoxVarisYeri.Items.AddRange(
                tumUcuslar.Select(u => u.VarisYeri).Distinct().ToArray()
                );
        }

        // ucus arama butonu
        private void btnUcusAra_Click(object sender, EventArgs e)
        {

            // Secilen kriterlere gore ucuslari listele
            string kalkisYeri = comboBoxKalkisYeri.Text;
            string varisYeri = comboBoxVarisYeri.Text;

            var sonucListesi = _rezervasyonService.MusteriUcusAra(kalkisYeri, varisYeri);

            if(sonucListesi.Count == 0)
            {
                MessageBox.Show("Sectiginiz kriterlere gore ucus bulunamadi!!!");
            }

            dataGridViewFlights.DataSource = sonucListesi;
        }

        // rezervasyon yap butonu
        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            try
            {
                // secimleri kontrol et
                if (_secilenUcusId == 0 || _secilenKoltukNo == 0)
                {
                    MessageBox.Show("Lütfen önce uçuş ve koltuk seçiniz.");
                    return;
                }

                Rezervasyon rezervasyon = new Rezervasyon
                {
                    UcusId = _secilenUcusId,
                    KoltukNo = _secilenKoltukNo,
                    MusteriId = 1, // suanda musteri olmadigi icin el ile olusturulan deger
                    
                    // buraya diger veriler eklenecek
                };

                bool basarili = _rezervasyonService.RezervasyonYap(rezervasyon);

                if (basarili)
                {
                    MessageBox.Show($"Rezervasyon basarili!\nSecilen Koltuk No: {_secilenKoltukNo}");

                    dataGridViewKoltuklar.DataSource = _rezervasyonService.KoltuklariGetir(_secilenUcusId); // formu guncelle

                    _secilenKoltukNo = 0;
                }
                else
                {
                    MessageBox.Show("Rezervasyon yapilamadi Tekrar deneyiniz");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hata:" + ex.Message);
            }
        }

        // secilen ucusu alan method
        private void dataGridViewFlights_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // secilen ucusun idsini al
            _secilenUcusId = Convert.ToInt32(dataGridViewFlights.Rows[e.RowIndex].Cells["UcusNo"].Value);

            // secilen ucusua gore koltuklari getir
            var koltukListesi = _koltukService.GetByUcusId(_secilenUcusId);

            dataGridViewKoltuklar.DataSource = koltukListesi;

            if (dataGridViewKoltuklar.Columns["UcusId"] != null) dataGridViewKoltuklar.Columns["UcusId"].Visible = false;
            if (dataGridViewKoltuklar.Columns["KoltukId"] != null) dataGridViewKoltuklar.Columns["KoltukId"].Visible = false;

        }

        // secilen koltugu alan method
        private void dataGridViewKoltuklar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _secilenKoltukNo = Convert.ToInt32(dataGridViewKoltuklar.Rows[e.RowIndex].Cells["KoltukNo"].Value);


        }

        // koltuklarin doluluguna gore rengini duzenlemek icin
        private void dataGridViewKoltuklar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // sadece satirlar varken calis
            if(e.RowIndex >= 0)
            {
                var row = dataGridViewKoltuklar.Rows[e.RowIndex]; // satirin verisini al

                var koltuk = (Koltuk)row.DataBoundItem; // o satirin nesnesini al

                if(koltuk != null)
                {
                    if (koltuk.DoluMu)
                    {
                        // doluysa kirmizi
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    }
                    else
                    {
                        // bossa yesil
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.SelectionBackColor = Color.Green;
                    }
                }
            }
        }

    }
}
