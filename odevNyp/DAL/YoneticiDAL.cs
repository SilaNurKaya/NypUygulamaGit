using MySql.Data.MySqlClient;
using odev2.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static odev2.EntityLayer.YoneticiEntityLayer;

namespace odev2.DAL
{
    public class YoneticiDAL
    {
        public void YoneticiEkle(int yoneticiId, string kullaniciAdi, string sifre, string guvenlikSorusu, string guvenlikCevabi)
        {
            DbBaglanti dbBaglanti = new DbBaglanti();

            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "INSERT INTO Yonetici (kullanici_Adi, sifre, guvenlik_Sorusu, guvenlik_Cevabi) VALUES (@KullaniciAdi, @Sifre, @GuvenlikSousu, @GuvenlikCevabi)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);
                command.Parameters.AddWithValue("@GuvenlikSousu", guvenlikSorusu);
                command.Parameters.AddWithValue("@GuvenlikCevabi", guvenlikCevabi);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Yönetici eklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        public void YoneticiSil(int kullaniciAdi)
        {
            DbBaglanti dbBaglanti = new DbBaglanti();

            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "DELETE FROM Yonetici WHERE KullaniciAdi = @KullaniciAdi";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<YoneticiEntityLayer> YoneticiListele()
        {
            List<YoneticiEntityLayer> yoneticiler = new List<YoneticiEntityLayer>();

            using (var connection = DbBaglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Yonetici";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yoneticiler.Add(new YoneticiEntityLayer
                    {
                        KullaniciAdi = reader.GetString("kullanici_adi"),
                        Sifre = reader.GetString("sifre"),
                        GuvenlikSorusu = reader.GetString("guvenlik_sorusu"),
                        GuvenlikCevabi = reader.GetString("guvenlik_cevabi")
                    });
                }
            }

            return yoneticiler;
        }

        public void YoneticiGuncelle(YoneticiEntityLayer yonetici)
        {
            using (var connection = DbBaglanti.BaglantiGetir())
            {
                string query = "UPDATE Yonetici SET kullanici_adi = @KullaniciAdi, sifre = @Sifre, guvenlik_sorusu = @GuvenlikSorusu, guvenlik_cevabi = @GuvenlikCevabi WHERE id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", yonetici.KullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", yonetici.Sifre);
                command.Parameters.AddWithValue("@GuvenlikSorusu", yonetici.GuvenlikSorusu);
                command.Parameters.AddWithValue("@GuvenlikCevabi", yonetici.GuvenlikCevabi);
                command.Parameters.AddWithValue("@Id", yonetici.YoneticiId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
