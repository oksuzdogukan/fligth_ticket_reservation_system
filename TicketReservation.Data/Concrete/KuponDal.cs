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
    public class KuponDal : IKuponDal
    {
        public Kupon KuponGetir(string kod)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Kuponlar WHERE Kod = @Kod AND AktifMi = 1 AND SonKullanimTarihi > @Tarih";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Kod", kod);
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Kupon
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Kod = reader["Kod"].ToString(),
                            IndirimOrani = Convert.ToDecimal(reader["IndirimOrani"]),
                            SonKullanimTarihi = Convert.ToDateTime(reader["SonKullanimTarihi"]),
                            AktifMi = Convert.ToBoolean(reader["AktifMi"])
                        };
                    }
                }
            }
            return null; // Kupon bulunamazsa veya süresi geçmişse null döner
        }
    }
}
