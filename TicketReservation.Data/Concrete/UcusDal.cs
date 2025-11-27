using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Data.Interfaces;
using TicketReservation.Models;

namespace TicketReservation.Data.Concrete
{
    public class UcusDal : IUcusDal
    {
        public List<Ucus> UcusAra(string kalkis, string varis, DateTime tarih)
        {
            List<Ucus> ucuslar = new List<Ucus>();

            using(SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT U.*, Uc.Model FROM Ucuslar U " +/*
                                   "INNER JOIN Ucaklar Uc ON U.UcakId = Uc.UcakId " +*/
                                   "WHERE U.KalkisYeri = @kalkis AND U.VarisYeri = @varis AND U.Tarih = @tarih";
                    
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kalkis", kalkis);
                        cmd.Parameters.AddWithValue("@varis", varis);
                        cmd.Parameters.AddWithValue("@tarih", tarih.Date);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Ucus ucus = new Ucus
                            {
                                UcusId = Convert.ToInt32(reader["UcusNo"]),
                                KalkisYeri = reader["KalkisYeri"].ToString(),
                                VarisYeri = reader["VarisYeri"].ToString(),
                                Tarih = Convert.ToDateTime(reader["Tarih"]),
                                Saat = TimeSpan.Parse(reader["Saat"].ToString()),
                                TemelFiyat = Convert.ToDecimal(reader["TemelFiyat"]),
                                UcakId = Convert.ToInt32(reader["UcakId"]),
                            };
                            ucuslar.Add(ucus);

                        }
                        return ucuslar;
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool UcusEkle(Ucus ucus)
        {
            using(SqlConnection conn = Database.GetConnection())
            {
                conn.Open(); // baglantiyi ac

                // Transaction : islemlerin hepsi basarılı olursa kaydet, biri bile hata verirse hepsini iptal et
                SqlTransaction transaction = conn.BeginTransaction(); // transaction i baslat
                

                try
                {
                    // 1. Ucusu Ekle
                    string ucusEkleQuery = "INSERT INTO Ucuslar (KalkisYeri, VarisYeri, Tarih, Saat, TemelFiyat, UcakId) " +
                                       "VALUES (@kalkis, @varis, @tarih, @saat, @fiyat, @ucakId); " +
                                       "SELECT SCOPE_IDENTITY();"; // Eklenen son UcusId'yi geri al

                    int yeniUcusId;

                    using (SqlCommand cmdUcus = new SqlCommand(ucusEkleQuery, conn, transaction))
                    {
                        cmdUcus.Parameters.AddWithValue("@kalkis", ucus.KalkisYeri);
                        cmdUcus.Parameters.AddWithValue("@varis", ucus.VarisYeri);
                        cmdUcus.Parameters.AddWithValue("@tarih", ucus.Tarih.Date);
                        cmdUcus.Parameters.AddWithValue("@saat", ucus.Saat);
                        cmdUcus.Parameters.AddWithValue("@fiyat", ucus.TemelFiyat);
                        cmdUcus.Parameters.AddWithValue("@ucakId", ucus.UcakId);


                        yeniUcusId = Convert.ToInt32(cmdUcus.ExecuteScalar());
                    }

                    // 2.Ucagin Kapasitesini Ogren
                    string kapasiteQuery = "SELECT Kapasite FROM Ucaklar WHERE UcakId=@ucakId";
                    int ucakKapasitesi;

                    using(SqlCommand cmdKapasite = new SqlCommand(kapasiteQuery, conn, transaction))
                    {
                        cmdKapasite.Parameters.AddWithValue("@ucakId", ucus.UcakId);
                        ucakKapasitesi = Convert.ToInt32(cmdKapasite.ExecuteScalar());
                    }

                    // Koltuk ekleme dongusu

                    string koltukEkleQuery = "INSERT INTO Koltuklar (UcusNo, KoltukNo, DoluMu) " +
                                         "VALUES (@ucusNo, @koltukNo, @doluMu)";
                    for (int i=1; i<=ucakKapasitesi; i++)
                    {
                        using(SqlCommand cmdKoltuk = new SqlCommand(koltukEkleQuery, conn, transaction))
                        {
                            cmdKoltuk.Parameters.AddWithValue("@ucusNo", yeniUcusId);
                            cmdKoltuk.Parameters.AddWithValue("@koltukNo", i);
                            cmdKoltuk.Parameters.AddWithValue("@doluMu", false); // Bos

                            cmdKoltuk.ExecuteNonQuery();
                        }
                    }

                    // hersey basariliysa transaction i onayla (Commit)
                    transaction.Commit();
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

        public Ucus UcusGetir(int ucusId)
        {
            using(SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Ucuslar WHERE UcusNo = @ucusNo";

                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ucusNo", ucusId);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            Ucus ucus = new Ucus
                            {
                                UcusId = Convert.ToInt32(reader["UcusNo"]),
                                KalkisYeri = reader["KalkisYeri"].ToString(),
                                VarisYeri = reader["VarisYeri"].ToString(),
                                Tarih = Convert.ToDateTime(reader["Tarih"]),
                                Saat = TimeSpan.Parse(reader["Saat"].ToString()),
                                TemelFiyat = Convert.ToDecimal(reader["TemelFiyat"]),
                                UcakId = Convert.ToInt32(reader["UcakId"])
                            };
                            return ucus;
                        }
                        return null; // Ucus bulunmadi
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;

                }
            }
        }

        public bool UcusGuncelle(Ucus ucus)
        {
            using(SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Ucuslar SET KalkisYeri = @kalkis, VarisYeri = @varis, " +
                                   "Tarih = @tarih, Saat = @saat, TemelFiyat = @fiyat, UcakId = @ucakId " +
                                   "WHERE UcusId = @ucusId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ucusId", ucus.UcusId); // Hangi ucusun guncellenecegi
                        cmd.Parameters.AddWithValue("@kalkis", ucus.KalkisYeri);
                        cmd.Parameters.AddWithValue("@varis", ucus.VarisYeri);
                        cmd.Parameters.AddWithValue("@tarih", ucus.Tarih.Date);
                        cmd.Parameters.AddWithValue("@saat", ucus.Saat);
                        cmd.Parameters.AddWithValue("@fiyat", ucus.TemelFiyat);
                        cmd.Parameters.AddWithValue("@ucakId", ucus.UcakId);

                        int affectedRows = cmd.ExecuteNonQuery();
                        return affectedRows > 0; // guncellenen satir varsa true don
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public List<Ucus> UcusListele()
        {
            List<Ucus> ucuslar = new List<Ucus>();

            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    //string query = "SELECT U.*, Uc.model FROM Ucuslar U " + "INNER JOIN Ucaklar Uc ON U.UcakId = Uc.UcakId";
                    string query = @"
                                    SELECT 
                                        UcusNo,
                                        KalkisYeri,
                                        VarisYeri,
                                        Tarih,
                                        Saat,
                                        TemelFiyat,
                                         U.UcakId AS UcusUcakId,
                                        Uc.Model AS UcakModel,
                                        Uc.Kapasite AS UcakKapasite
                                    FROM Ucuslar U
                                    INNER JOIN Ucaklar Uc ON U.UcakId = Uc.UcakId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Ucus ucus = new Ucus
                            {
                                UcusId = Convert.ToInt32(reader["UcusNo"]),
                                KalkisYeri = reader["KalkisYeri"].ToString(),
                                VarisYeri = reader["VarisYeri"].ToString(),
                                Tarih = Convert.ToDateTime(reader["Tarih"]),
                                Saat = TimeSpan.Parse(reader["Saat"].ToString()),
                                TemelFiyat = Convert.ToDecimal(reader["TemelFiyat"]),
                                UcakId = Convert.ToInt32(reader["UcusUcakId"]),

                                Ucak = new Ucak
                                {
                                    UcakId = Convert.ToInt32(reader["UcusUcakId"]),
                                    Model = reader["UcakModel"].ToString(),
                                    Kapasite = Convert.ToInt32(reader["UcakKapasite"])
                                }
                            };
                            ucuslar.Add(ucus);
                        }
                        return ucuslar;
                    }
                }
                catch(Exception ex)
                { 
                //{
                //    Console.WriteLine(ex.Message);
                //    return null;
                    throw new Exception("Veri cekilirken hata: " + ex.Message);
                }
            }
        }

        public bool UcusSil(int ucusId)
        {
            // eger silmem isteniler ucusa ait rezeryazson varsa ucusun silinmemesi gerekir
            using(SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Ucuslar WHERE UcusNo=@ucusNo";

                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ucusNo", ucusId);

                        int affectedRows = cmd.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

        }
    }
}
