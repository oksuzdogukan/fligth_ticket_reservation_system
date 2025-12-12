using System;
using System.Data.SqlClient;
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
                    conn.Open();
                    // Rol bilgisini de çekiyoruz ki admin mi müşteri mi anlayalım
                    string query = "SELECT * FROM Kullanicilar WHERE Email=@email AND Sifre=@sifre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string rol = reader["Rol"].ToString();

                            // Polimorfizm için uygun nesneyi döndürüyoruz
                            Kullanici kullanici;
                            if (rol == "A") // Veritabanında Admin için 'A' tuttuğunu varsayalım
                            {
                                kullanici = new Admin();
                            }
                            else
                            {
                                kullanici = new Musteri
                                {
                                    TcNo = reader["TcNo"].ToString()
                                };
                            }

                            kullanici.Id = Convert.ToInt32(reader["Id"]);
                            kullanici.Ad = reader["Ad"].ToString();
                            kullanici.Soyad = reader["Soyad"].ToString();
                            kullanici.Email = reader["Email"].ToString();
                            kullanici.Sifre = reader["Sifre"].ToString();

                            return kullanici;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return null;
            }
        }

        public bool KayitOl(Musteri musteri)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Kullanicilar (Ad, Soyad, Email, Sifre, Rol, TcNo) VALUES (@ad, @soyad, @email, @sifre, 'M', @tcno)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", musteri.Ad);
                        cmd.Parameters.AddWithValue("@soyad", musteri.Soyad);
                        cmd.Parameters.AddWithValue("@email", musteri.Email);
                        cmd.Parameters.AddWithValue("@sifre", musteri.Sifre);
                        cmd.Parameters.AddWithValue("@tcno", musteri.TcNo);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Email unique constraint hatası olabilir
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}