using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static odev2.EntityLayer.RezervasyonEntityLayer;

namespace odev2.DAL
{
    public class RezervasyonDAL
    {
        public void RezervasyonOlustur(int musteriId, int odaId, DateTime girisTarihi, DateTime cikisTarihi)
        {
            DbBaglanti dbBaglanti = new DbBaglanti();

            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "INSERT INTO Rezervasyonlar (musteri_id, oda_id, giris_tarihi, cıkıs_tarihi) VALUES (@MusteriId, @OdaId, @GirisTarihi, @CıkısTarihi)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@MusteriId", musteriId);
                command.Parameters.AddWithValue("@OdaId", odaId);
                command.Parameters.AddWithValue("@GirisTarihi", girisTarihi);
                command.Parameters.AddWithValue("@CıkısTarihi", cikisTarihi);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("rezervasyon oluşturulurken hata oluştu: " + ex.Message);
                }
            }
        }

        public List<Rezervasyon> RezervasyonListele()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            using (var connection = DbBaglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Rezervasyonlar";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {
                        MusteriId = Convert.ToInt32(reader["musteri_id"]),
                        OdaId = Convert.ToInt32(reader["oda_id"]),
                        GirisTarihi = Convert.ToDateTime(reader["giris_tarihi"]),
                        CikisTarihi = Convert.ToDateTime(reader["cikis_tarihi"]),
                    });
                }
            }

            return rezervasyonlar;
        }

        // rezervasyon id listede gözükmemeli bunu unutma
        public bool RezervasyonGuncelle(Rezervasyon guncellenenRezervasyon)
        {
            using (var connection = DbBaglanti.BaglantiGetir())
            {
                string query = @"UPDATE Rezervasyonlar SET musteri_id = @MusteriId, oda_id = @OdaId, giris_tarihi = @GirisTarihi, cikis_tarihi = @CikisTarihi,
                               WHERE rezervasyon_id = @RezervasyonId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@RezervasyonId", guncellenenRezervasyon.RezervasyonId);
                command.Parameters.AddWithValue("@MusteriId", guncellenenRezervasyon.MusteriId);
                command.Parameters.AddWithValue("@OdaId", guncellenenRezervasyon.OdaId);
                command.Parameters.AddWithValue("@GirisTarihi", guncellenenRezervasyon.GirisTarihi);
                command.Parameters.AddWithValue("@CikisTarihi", guncellenenRezervasyon.CikisTarihi);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        //iptal nedeni eklemeyi unutma
        public void RezervasyonSil(string TcNo)
        {
            using (var connection = DbBaglanti.BaglantiGetir())
            {
                string query = @"
            DELETE r 
            FROM Rezervasyonlar r
            INNER JOIN musteri m ON r.musteri_id = m.id
            WHERE m.musteri_tcNo = @TcNo";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TcNo", TcNo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
