using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Data.Interfaces;
using TicketReservation.Models;
using TicketReservation.Models.Enums;

namespace TicketReservation.Data.Concrete
{
    public class RezervasyonDal : IRezervasyonDal
    {
        public bool RezervasyonYap(Rezervasyon rezervasyon)
        {
            // 1.REzervasyon tablosuna yeni kayit ekle
            // 2.Koltuklar tablosunda o koltuk DoluMu=1 olarak guncelle
            // Ikisinden biri basarisiz olursa ikiside geri alinmali o yuzden transaction kullanilmali

            using(SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    // 1 
                    string queryRez = "INSERT INTO Rezervasyonlar (MusteriId, UcusId, KoltukNo, RezervasyonTarihi, Fiyat, Durum)" + "VALUES (@musteriId, @ucusId, @koltukNo, @rezervasyonTarihi, @fiyat, @durum)";

                    using(SqlCommand cmdRez = new SqlCommand(queryRez, conn, transaction))
                    {
                        cmdRez.Parameters.AddWithValue("@musteriId", rezervasyon.MusteriId);
                        cmdRez.Parameters.AddWithValue("@ucusId", rezervasyon.UcusId);
                        cmdRez.Parameters.AddWithValue("@koltukNo", rezervasyon.KoltukNo);
                        cmdRez.Parameters.AddWithValue("@rezervasyonTarihi", DateTime.Now); // Suanki Tarih
                        cmdRez.Parameters.AddWithValue("@fiyat", rezervasyon.Fiyat);
                        cmdRez.Parameters.AddWithValue("@durum", "Aktif"); // Enum

                        cmdRez.ExecuteNonQuery();
                    }

                    // 2 koltuk dolu mu 

                    string queryKoltuk = "UPDATE Koltuklar SET DoluMu = 1" + "WHERE UcusNo = @ucusId AND KoltukNo = @koltukNo AND DoluMu = 0";

                    using(SqlCommand cmdKoltuk = new SqlCommand(queryKoltuk, conn, transaction))
                    {
                        cmdKoltuk.Parameters.AddWithValue("@ucusId", rezervasyon.UcusId);
                        cmdKoltuk.Parameters.AddWithValue("@koltukNo", rezervasyon.KoltukNo);

                        int affectedRows = cmdKoltuk.ExecuteNonQuery();

                        if(affectedRows == 0)
                        {
                            // 0 satir etkilendiyse bu koltuk ya yok ya da zaten doludur
                            // islemi geri al, hata ver

                            throw new Exception("Secilen Koltuk Rezerve Edilemedi.");

                        }

                    }

                    // iki islemde basariliysa transactioni onayla
                    transaction.Commit();
                    return true;

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

        }

        public bool RezervasyonIptalEt(int rezervasyonId)
        {
            // 1. Rezervasyonlar tablosunda Durum iptal edildi olmali
            // 2. Koltuklar tablosunda o kaltuk DoluMu=0 olmali
            // Ikisinden biri basarisiz olursa ikiside geri alinmali o yuzden transaction kullanilmali

            Rezervasyon iptalEdilecekRez = null;

            using(SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string queryInfo = "SELECT UcusId, KoltukNo, Durum FROM Rezervasyonlar WHERE RezervasyonID=@rezId"; // iptal edilcecek rez. bilgisini istegi

                try
                {
                    // iptal edilecek rezervasyon bilgilerini al
                    using(SqlCommand cmdInfo = new SqlCommand(queryInfo, conn))
                    {
                        cmdInfo.Parameters.AddWithValue("@rezId", rezervasyonId);

                        SqlDataReader reader = cmdInfo.ExecuteReader(); // okuyucu

                        if (reader.Read())
                        {
                            if (reader["Durum"].ToString() == "IptalEdildi")
                            {
                                throw new Exception("Bu rezervasyon zaten iptal edilmis");
                            }

                            iptalEdilecekRez = new Rezervasyon
                            {
                                RezervasyonId = rezervasyonId,
                                UcusId = Convert.ToInt32(reader["UcusId"]),
                                KoltukNo = Convert.ToInt32(reader["KoltukNo"])
                            };
                        }
                        reader.Close(); // reader i kapat
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }

                if (iptalEdilecekRez == null) return false; // rezervasyon bulunamadi


                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // rezervasyon durumunu guncelle
                    string queryRez = "UPDATE Rezervasyonlar SET Durum='IptalEdildi' WHERE RezervasyonId=@rezId";

                    using(SqlCommand cmdRez = new SqlCommand(queryRez, conn, transaction))
                    {
                        cmdRez.Parameters.AddWithValue("@rezId", rezervasyonId);
                        cmdRez.ExecuteNonQuery(); // update islemini gerceklestir

                    }

                    // koltugu bosalt
                    string queryKoltuk = "UPDATE Koltuklar SET Dolumu=0 WHERE UcusNo=@ucusID AND KoltukNo=@koltukNo";

                    using(SqlCommand cmdKoltuk = new SqlCommand(queryKoltuk, conn, transaction))
                    {
                        cmdKoltuk.Parameters.AddWithValue("@ucusId", iptalEdilecekRez.UcusId);
                        cmdKoltuk.Parameters.AddWithValue("@koltukNo", iptalEdilecekRez.KoltukNo);
                        cmdKoltuk.ExecuteNonQuery(); // Update islemini gerceklestir

                    }

                    transaction.Commit(); // her iki islemde basariliysa commit
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }

        // ucus silerken kontrol icin
        public bool AktifUcusRezervasyonuVarMi(int ucusId)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Rezervasyonlar WHERE UcusId=@ucusId AND Durum='Aktif'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ucusId", ucusId);

                        int sayi = (int)cmd.ExecuteScalar();
                        return sayi > 0; // Rezervasyon varsa
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

        }

        public List<Rezervasyon> RezervasyonGoruntule(int musteriId)
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Join işlemi ile Uçuş bilgilerini de alıyoruz ki ekranda Kalkış/Varış yeri görünsün
                    string query = @"
                        SELECT R.RezervasyonID, R.UcusId, R.KoltukNo, R.RezervasyonTarihi, R.Fiyat, R.Durum,
                               U.KalkisYeri, U.VarisYeri, U.Tarih, U.Saat
                        FROM Rezervasyonlar R
                        INNER JOIN Ucuslar U ON R.UcusId = U.UcusNo
                        WHERE R.MusteriId = @musteriId
                        ORDER BY R.RezervasyonTarihi DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@musteriId", musteriId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Rezervasyon rez = new Rezervasyon
                            {
                                RezervasyonId = Convert.ToInt32(reader["RezervasyonID"]),
                                UcusId = Convert.ToInt32(reader["UcusId"]),
                                KoltukNo = Convert.ToInt32(reader["KoltukNo"]),
                                RezervasyonTarihi = Convert.ToDateTime(reader["RezervasyonTarihi"]),
                                Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                                // Durum string olarak geliyor, Enum'a çevirebilir veya string kullanabiliriz.
                                // Modelindeki Durum tipi Enum ise çevirme işlemi gerekir, şimdilik string varsayımıyla devam edelim veya Enum.Parse yapalım:
                                // Durum = (RezervasyonDurumu)Enum.Parse(typeof(RezervasyonDurumu), reader["Durum"].ToString()),

                                // Uçuş detaylarını içine gömelim (UI'da göstermek için)
                                Ucus = new Ucus
                                {
                                    KalkisYeri = reader["KalkisYeri"].ToString(),
                                    VarisYeri = reader["VarisYeri"].ToString(),
                                    Tarih = Convert.ToDateTime(reader["Tarih"]),
                                    Saat = TimeSpan.Parse(reader["Saat"].ToString())
                                }
                            };

                            // Enum dönüşümü (Modelindeki yapıya göre):
                            string durumStr = reader["Durum"].ToString();
                            if (durumStr == "Aktif") rez.Durum = TicketReservation.Models.Enums.RezervasyonDurumu.Aktif;
                            else if (durumStr == "IptalEdildi") rez.Durum = TicketReservation.Models.Enums.RezervasyonDurumu.IptalEdildi;
                            else rez.Durum = TicketReservation.Models.Enums.RezervasyonDurumu.Tamamlandi;

                            rezervasyonlar.Add(rez);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return rezervasyonlar;
        }

        //raporlama
        public Dictionary<string, object> RaporVerileriniAl()
        {
            var veriler = new Dictionary<string, object>();
            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1. Toplam Gelir
                    string queryGelir = "SELECT SUM(Fiyat) FROM Rezervasyonlar WHERE Durum != 'IptalEdildi'";
                    using (SqlCommand cmd = new SqlCommand(queryGelir, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        veriler.Add("ToplamGelir", result != DBNull.Value ? Convert.ToDecimal(result) : 0m);
                    }

                    // 2. Toplam Rezervasyon
                    string queryRezSayisi = "SELECT COUNT(*) FROM Rezervasyonlar";
                    using (SqlCommand cmd = new SqlCommand(queryRezSayisi, conn))
                    {
                        veriler.Add("ToplamRezervasyon", Convert.ToInt32(cmd.ExecuteScalar()));
                    }

                    // 3. Toplam Uçuş Sayısı
                    string queryUcusSayisi = "SELECT COUNT(*) FROM Ucuslar";
                    using (SqlCommand cmd = new SqlCommand(queryUcusSayisi, conn))
                    {
                        veriler.Add("ToplamUcus", Convert.ToInt32(cmd.ExecuteScalar()));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return veriler;
        }
    }
}
