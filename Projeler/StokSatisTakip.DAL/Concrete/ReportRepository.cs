using MySql.Data.MySqlClient;
using StokSatisTakip.DAL.Helpers;
using System;
using System.Data;

namespace StokSatisTakip.DAL.Concrete
{
    public class ReportRepository
    {
        // Parametreli sorgular için
        private DataTable ExecuteTable(string sql, Action<MySqlCommand> paramBinder)
        {
            var dt = new DataTable();

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (paramBinder != null)
                    paramBinder(cmd);

                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        // Parametresiz sorgular için (MinStock gibi)
        private DataTable ExecuteTable(string sql)
        {
            return ExecuteTable(sql, null);
        }

        // 1) Aylık Satış: satış sayısı + ciro + indirim + kâr
        public DataTable GetMonthlySales(DateTime start, DateTime end)
        {
            string sql = @"
                SELECT 
                    DATE_FORMAT(SaleDate, '%Y-%m') AS Month,
                    COUNT(*) AS SaleCount,
                    SUM(TotalAmount) AS TotalRevenue,
                    SUM(TotalDiscount) AS TotalDiscount,
                    SUM(TotalProfit) AS TotalProfit
                FROM sales
                WHERE SaleDate >= @start AND SaleDate < @end
                GROUP BY DATE_FORMAT(SaleDate, '%Y-%m')
                ORDER BY Month;
            ";

            return ExecuteTable(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
            });
        }

        // 2) En çok satılan ürünler (adet + ciro + kâr)
        public DataTable GetTopProducts(DateTime start, DateTime end)
        {
            string sql = @"
                SELECT
                    p.UrunId,
                    p.UrunAdi,
                    SUM(si.Quantity) AS TotalSold,
                    SUM(si.LineTotal) AS TotalRevenue,
                    SUM(si.LineProfit) AS TotalProfit
                FROM sale_items si
                INNER JOIN sales s ON s.SaleId = si.SaleId
                INNER JOIN products p ON p.UrunId = si.ProductId
                WHERE s.SaleDate >= @start AND s.SaleDate < @end
                GROUP BY p.UrunId, p.UrunAdi
                ORDER BY TotalSold DESC;
            ";

            return ExecuteTable(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
            });
        }

        // 3) Müşteri bazlı satış (kaç satış + toplam ciro + toplam kâr + toplam indirim)
        public DataTable GetCustomerSales(DateTime start, DateTime end)
        {
            string sql = @"
                SELECT
                    c.Id AS CustomerId,
                    CONCAT(c.FirstName, ' ', c.LastName) AS CustomerName,
                    COUNT(s.SaleId) AS SaleCount,
                    SUM(s.TotalAmount) AS TotalSpent,
                    SUM(s.TotalDiscount) AS TotalDiscount,
                    SUM(s.TotalProfit) AS TotalProfit
                FROM sales s
                INNER JOIN customers c ON c.Id = s.CustomerId
                WHERE s.SaleDate >= @start AND s.SaleDate < @end
                GROUP BY c.Id, c.FirstName, c.LastName
                ORDER BY TotalSpent DESC;
            ";

            return ExecuteTable(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
            });
        }

        // 4) Kâr/Zarar (günlük özet)
        public DataTable GetDailyProfit(DateTime start, DateTime end)
        {
            string sql = @"
                SELECT
                    DATE(s.SaleDate) AS Day,
                    SUM(s.TotalAmount) AS TotalRevenue,
                    SUM(s.TotalCost) AS TotalCost,
                    SUM(s.TotalProfit) AS TotalProfit,
                    SUM(s.TotalDiscount) AS TotalDiscount
                FROM sales s
                WHERE s.SaleDate >= @start AND s.SaleDate < @end
                GROUP BY DATE(s.SaleDate)
                ORDER BY Day;
            ";

            return ExecuteTable(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
            });
        }

        // 5) Minimum stok altı ürünler
        public DataTable GetMinStockProducts()
        {
            string sql = @"
                SELECT
                    UrunId,
                    UrunAdi,
                    Alinanmiktar AS Stok,
                    MinStok
                FROM products
                WHERE Alinanmiktar <= MinStok
                ORDER BY (Alinanmiktar - MinStok) ASC;
            ";

            return ExecuteTable(sql);
        }
    }
}