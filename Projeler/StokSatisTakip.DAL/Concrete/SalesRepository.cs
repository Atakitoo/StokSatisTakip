using MySql.Data.MySqlClient;
using System;
using StokSatisTakip.DAL.Helpers;

namespace StokSatisTakip.DAL.Concrete
{
    public class SalesRepository
    {
        public int CreateSingleSaleTransaction(
            int customerId,
            int productId,
            int quantity,
            decimal unitListPrice,
            decimal unitSalePrice,
            decimal unitCostPrice)
        {
            decimal discount = Math.Max(0, (unitListPrice - unitSalePrice) * quantity);
            decimal lineTotal = unitSalePrice * quantity;
            decimal lineProfit = (unitSalePrice - unitCostPrice) * quantity;
            decimal totalCost = unitCostPrice * quantity;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlTransaction tx = conn.BeginTransaction())
            {
                try
                {
                    // stok kilitle + kontrol
                    int currentStock;
                    using (var stockCmd = new MySqlCommand(
                        "SELECT Alinanmiktar FROM products WHERE UrunId=@pid FOR UPDATE;", conn, tx))
                    {
                        stockCmd.Parameters.AddWithValue("@pid", productId);
                        object result = stockCmd.ExecuteScalar();
                        currentStock = result == null ? 0 : Convert.ToInt32(result);
                    }

                    if (quantity > currentStock)
                        throw new Exception($"Yetersiz stok! Mevcut: {currentStock}, İstenen: {quantity}");

                    // sales insert
                    int saleId;
                    using (var saleCmd = new MySqlCommand(
                        @"INSERT INTO sales (CustomerId, SaleDate, TotalAmount, TotalDiscount, TotalCost, TotalProfit)
                          VALUES (@CustomerId, NOW(), @TotalAmount, @TotalDiscount, @TotalCost, @TotalProfit);
                          SELECT LAST_INSERT_ID();", conn, tx))
                    {
                        saleCmd.Parameters.AddWithValue("@CustomerId", customerId);
                        saleCmd.Parameters.AddWithValue("@TotalAmount", lineTotal);
                        saleCmd.Parameters.AddWithValue("@TotalDiscount", discount);
                        saleCmd.Parameters.AddWithValue("@TotalCost", totalCost);
                        saleCmd.Parameters.AddWithValue("@TotalProfit", lineProfit);

                        saleId = Convert.ToInt32(saleCmd.ExecuteScalar());
                    }

                    // sale_items insert
                    using (var itemCmd = new MySqlCommand(
                        @"INSERT INTO sale_items
                          (SaleId, ProductId, Quantity, UnitListPrice, UnitSalePrice, UnitCostPrice,
                           DiscountAmount, LineTotal, LineProfit)
                          VALUES
                          (@SaleId, @ProductId, @Quantity, @UnitListPrice, @UnitSalePrice, @UnitCostPrice,
                           @DiscountAmount, @LineTotal, @LineProfit);", conn, tx))
                    {
                        itemCmd.Parameters.AddWithValue("@SaleId", saleId);
                        itemCmd.Parameters.AddWithValue("@ProductId", productId);
                        itemCmd.Parameters.AddWithValue("@Quantity", quantity);
                        itemCmd.Parameters.AddWithValue("@UnitListPrice", unitListPrice);
                        itemCmd.Parameters.AddWithValue("@UnitSalePrice", unitSalePrice);
                        itemCmd.Parameters.AddWithValue("@UnitCostPrice", unitCostPrice);
                        itemCmd.Parameters.AddWithValue("@DiscountAmount", discount);
                        itemCmd.Parameters.AddWithValue("@LineTotal", lineTotal);
                        itemCmd.Parameters.AddWithValue("@LineProfit", lineProfit);

                        itemCmd.ExecuteNonQuery();
                    }

                    // stok düş
                    using (var updateStockCmd = new MySqlCommand(
                        @"UPDATE products
                          SET Alinanmiktar = Alinanmiktar - @qty
                          WHERE UrunId=@pid;", conn, tx))
                    {
                        updateStockCmd.Parameters.AddWithValue("@qty", quantity);
                        updateStockCmd.Parameters.AddWithValue("@pid", productId);
                        updateStockCmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return saleId;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public int GetCurrentStock(int productId)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand("SELECT Alinanmiktar FROM products WHERE UrunId=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@id", productId);
                object result = cmd.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }

        public int GetMinStock(int productId)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand("SELECT MinStok FROM products WHERE UrunId=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@id", productId);
                object result = cmd.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }
    }
}
