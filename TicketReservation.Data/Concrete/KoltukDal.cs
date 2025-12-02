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
    public class KoltukDal : IKoltukDal
    {
        public List<Koltuk> KoltuklariGetir(int ucusId)
        {
            List<Koltuk> koltuklar = new List<Koltuk>();

            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Koltuklar WHERE UcusNo=@ucusNo";

                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ucusNo", ucusId);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Koltuk koltuk = new Koltuk
                            {
                                KoltukId = Convert.ToInt32(reader["KoltukId"]),
                                UcusId = Convert.ToInt32(reader["UcusNo"]),
                                KoltukNo = Convert.ToInt32(reader["KoltukNo"]),
                                DoluMu = Convert.ToBoolean(reader["DoluMu"])
                            };
                            koltuklar.Add(koltuk);
                        }
                        return koltuklar;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null; // koltuk bulunamadi
                }
            }
        }

        // final
        public bool KoltukDurumuGuncelle(int ucusId, int koltukNo, bool doluMu)
        {
            // Rezervasyon yapildiginda koltugu 'Dolu' (true)
            // Rezervasyon iptal edildiginde koltugu 'Bos' (false) yapar

            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Koltuklar SET DoluMu=@doluMu" + "WHERE UcusId=@ucusId AND KoltukNo=@koltukNo";

                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doluMu", doluMu);
                        cmd.Parameters.AddWithValue("@ucusId", ucusId);
                        cmd.Parameters.AddWithValue("@koltukNo", koltukNo);

                        int affectedRows = cmd.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

    }
}
