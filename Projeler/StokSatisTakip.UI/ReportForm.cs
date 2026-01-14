using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokSatisTakip.DAL.Concrete;


namespace StokSatisTakip.UI
{
    public partial class ReportForm : Form
    {
        private readonly ReportRepository _reportRepo = new ReportRepository();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Aylık Satış");
            cmbReportType.Items.Add("En Çok Satılan Ürünler");
            cmbReportType.Items.Add("Müşteri Bazlı Satış");
            cmbReportType.Items.Add("Kâr/Zarar (Günlük)");
            cmbReportType.Items.Add("Minimum Stok");

            cmbReportType.SelectedIndex = 0;

            dtpStart.Value = DateTime.Today.AddMonths(-1);
            dtpEnd.Value = DateTime.Today.AddDays(1);

            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.MultiSelect = false;
            dgvReport.ReadOnly = true;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.RowHeadersVisible = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem == null)
            {
                MessageBox.Show("Rapor tipi seçmelisin.");
                return;
            }

            string reportName = cmbReportType.SelectedItem.ToString();

            // Tarih aralığı:
            // end'e +1 gün ekliyoruz ki bitiş günü de rapora dahil olsun.
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date.AddDays(1);

            if (reportName != "Minimum Stok" && end <= start)
            {
                MessageBox.Show("Bitiş tarihi başlangıçtan büyük olmalı.");
                return;
            }

            try
            {
                System.Data.DataTable dt;

                switch (reportName)
                {
                    case "Aylık Satış":
                        dt = _reportRepo.GetMonthlySales(start, end);
                        break;

                    case "En Çok Satılan Ürünler":
                        dt = _reportRepo.GetTopProducts(start, end);
                        break;

                    case "Müşteri Bazlı Satış":
                        dt = _reportRepo.GetCustomerSales(start, end);
                        break;

                    case "Kâr/Zarar (Günlük)":
                        dt = _reportRepo.GetDailyProfit(start, end);
                        break;

                    case "Minimum Stok":
                        dt = _reportRepo.GetMinStockProducts();
                        break;

                    default:
                        MessageBox.Show("Bilinmeyen rapor tipi.");
                        return;
                }

                // Grid'e bas
                dgvReport.DataSource = dt;

                // Toplamları hesapla (sütun varsa toplar, yoksa 0 kalır)
                decimal totalRevenue = 0m;
                decimal totalDiscount = 0m;
                decimal totalProfit = 0m;

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    if (dt.Columns.Contains("TotalRevenue") && row["TotalRevenue"] != DBNull.Value)
                        totalRevenue += Convert.ToDecimal(row["TotalRevenue"]);

                    if (dt.Columns.Contains("TotalDiscount") && row["TotalDiscount"] != DBNull.Value)
                        totalDiscount += Convert.ToDecimal(row["TotalDiscount"]);

                    if (dt.Columns.Contains("TotalProfit") && row["TotalProfit"] != DBNull.Value)
                        totalProfit += Convert.ToDecimal(row["TotalProfit"]);
                }

                lblTotalRevenueValue.Text = totalRevenue.ToString("N2");
                lblTotalDiscountValue.Text = totalDiscount.ToString("N2");
                lblTotalProfitValue.Text = totalProfit.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor alınırken hata: " + ex.Message);
            }
        }
        private void SetTotals(System.Data.DataTable dt)
        {
            decimal totalRevenue = 0m;
            decimal totalDiscount = 0m;
            decimal totalProfit = 0m;

            // Bazı raporlarda sütun isimleri farklı olabilir.
            // O yüzden sütun varsa toplayacağız, yoksa 0 kalacak.

            foreach (System.Data.DataRow row in dt.Rows)
            {
                if (dt.Columns.Contains("TotalRevenue") && row["TotalRevenue"] != DBNull.Value)
                    totalRevenue += Convert.ToDecimal(row["TotalRevenue"]);

                // Monthly report'ta "TotalDiscount", customer report'ta "TotalDiscount" var
                if (dt.Columns.Contains("TotalDiscount") && row["TotalDiscount"] != DBNull.Value)
                    totalDiscount += Convert.ToDecimal(row["TotalDiscount"]);

                if (dt.Columns.Contains("TotalProfit") && row["TotalProfit"] != DBNull.Value)
                    totalProfit += Convert.ToDecimal(row["TotalProfit"]);
            }

            // TR formatlı gösterelim
            lblTotalRevenueValue.Text = totalRevenue.ToString("N2");
            lblTotalDiscountValue.Text = totalDiscount.ToString("N2");
            lblTotalProfitValue.Text = totalProfit.ToString("N2");
        }




    }
}
