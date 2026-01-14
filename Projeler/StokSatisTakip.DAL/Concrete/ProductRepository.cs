using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using StokSatisTakip.DAL.Helpers;
using StokSatisTakip.Entities.Concrete;

namespace StokSatisTakip.DAL.Concrete
{
    public class ProductRepository
    {
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT UrunId, UrunAdi, AlisFiyati, SatisFiyati,
                                        Alinanmiktar, UrunTuru, SatinAlinanTarih, MinStok
                                 FROM products";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            UrunId = reader.GetInt32("UrunId"),
                            UrunAdi = reader.GetString("UrunAdi"),
                            AlisFiyati = reader.GetDecimal("AlisFiyati"),
                            SatisFiyati = reader.GetDecimal("SatisFiyati"),
                            Stok = reader.GetInt32("Alinanmiktar"),
                            UrunTuru = reader.GetString("UrunTuru"),
                            SatinAlinanTarih = reader.GetDateTime("SatinAlinanTarih"),
                            MinStok = reader.GetInt32("MinStok")
                        });
                    }
                }
            }

            return products;
        }

        public void Add(Product product)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO products
                                (UrunId, UrunAdi, AlisFiyati, SatisFiyati, Alinanmiktar, UrunTuru, SatinAlinanTarih, MinStok)
                                VALUES
                                (@UrunId, @UrunAdi, @AlisFiyati, @SatisFiyati, @Alinanmiktar, @UrunTuru, @SatinAlinanTarih, @MinStok)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UrunId", product.UrunId);
                    cmd.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
                    cmd.Parameters.AddWithValue("@AlisFiyati", product.AlisFiyati);
                    cmd.Parameters.AddWithValue("@SatisFiyati", product.SatisFiyati);
                    cmd.Parameters.AddWithValue("@Alinanmiktar", product.Stok);
                    cmd.Parameters.AddWithValue("@UrunTuru", product.UrunTuru);
                    cmd.Parameters.AddWithValue("@SatinAlinanTarih", product.SatinAlinanTarih.Date);
                    cmd.Parameters.AddWithValue("@MinStok", product.MinStok);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Product product)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE products SET
                                    UrunAdi = @UrunAdi,
                                    AlisFiyati = @AlisFiyati,
                                    SatisFiyati = @SatisFiyati,
                                    Alinanmiktar = @Alinanmiktar,
                                    UrunTuru = @UrunTuru,
                                    SatinAlinanTarih = @SatinAlinanTarih,
                                    MinStok = @MinStok
                                 WHERE UrunId = @UrunId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UrunId", product.UrunId);
                    cmd.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
                    cmd.Parameters.AddWithValue("@AlisFiyati", product.AlisFiyati);
                    cmd.Parameters.AddWithValue("@SatisFiyati", product.SatisFiyati);
                    cmd.Parameters.AddWithValue("@Alinanmiktar", product.Stok);
                    cmd.Parameters.AddWithValue("@UrunTuru", product.UrunTuru);
                    cmd.Parameters.AddWithValue("@SatinAlinanTarih", product.SatinAlinanTarih.Date);
                    cmd.Parameters.AddWithValue("@MinStok", product.MinStok);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int urunId)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM products WHERE UrunId = @UrunId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UrunId", urunId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}