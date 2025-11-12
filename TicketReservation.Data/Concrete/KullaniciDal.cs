using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TicketReservation.Data.Interfaces;
using TicketReservation.Models;

namespace TicketReservation.Data.Concrete
{
    public class KullaniciDal : IKullaniciDal
    {
        public Kullanici GirisYap(string email, string sifre)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open(); // baglantiyi ac

                    string query = "SELECT * FROM Kullanicilar WHERE Email=@email AND Sifre=@sifre";

                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        SqlDataReader reader = cmd.ExecuteReader(); // okuyucu

                        if (reader.Read()) // kullanici bulundu
                        {
                            string rol = reader["Rol"].ToString(); // rolunu al
                            Kullanici kullanici;

                            // Veritabanından 'M' geliyorsa MUSTERI nesnesi,
                            // 'A' geliyorsa ADMIN nesnesi oluşturuyoruz.

                            // Polimorfizim

                            if(rol == "M")
                            {
                                kullanici = new Musteri
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Ad = reader["Ad"].ToString(),
                                    Soyad = reader["Soyad"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Sifre = reader["Sifre"].ToString(),
                                    TcNo = reader["TcNo"].ToString() // Sadece Musteri'ye ozel
                                };
                            }
                            else if(rol == "A")
                            {
                                kullanici = new Admin
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Ad = reader["Ad"].ToString(),
                                    Soyad = reader["Soyad"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Sifre = reader["Sifre"].ToString()
                                    // Admin'in TcNo'su yok
                                };
                            }
                            else
                            {
                                return null;
                            }

                            return kullanici;
                        }

                        return null; // kullanici bulunamadi
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool MusteriKayitOl(Musteri musteri)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open(); // baglantiyi ac

                    string query = "INSERT INTO Kullanicilar (Ad, Soyad, Email, Sifre, Rol, TcNo) " +
                           "VALUES (@ad, @soyad, @email, @sifre, @rol, @tcNo)";


                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", musteri.Ad);
                        cmd.Parameters.AddWithValue("@soyad", musteri.Soyad);
                        cmd.Parameters.AddWithValue("@email", musteri.Email);
                        cmd.Parameters.AddWithValue("@sifre", musteri.Sifre); 
                        cmd.Parameters.AddWithValue("@rol", "M"); // Rol'u 'M' (Musteri) olarak kaydediyoruz
                        cmd.Parameters.AddWithValue("@tcNo", musteri.TcNo);


                        cmd.ExecuteNonQuery(); // 
                        return true; // Kayit basarili
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
