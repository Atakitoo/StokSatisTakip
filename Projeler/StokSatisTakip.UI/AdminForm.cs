using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokSatisTakip.UI;
using System.Net.Http;
using System.Text.Json;

namespace StokSatisTakip.UI
{
    public partial class AdminForm : Form
    {
        private const string ApiKey = "7b7acaed31867aa23708b688998f7f7f";
        private static readonly HttpClient Http = new HttpClient();

        private async void AdminForm_Load(object sender, EventArgs e)
        {
            await LoadCurrentWeatherAsync("Eskişehir");
        }

        private async Task LoadCurrentWeatherAsync(string city)
        {
            var url =
                $"https://api.openweathermap.org/data/2.5/weather?q={Uri.EscapeDataString(city)}&appid={ApiKey}&units=metric&lang=tr";

            string json = await Http.GetStringAsync(url);

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            string cityName = root.GetProperty("name").GetString() ?? city;
            double temp = root.GetProperty("main").GetProperty("temp").GetDouble();
            string desc = root.GetProperty("weather")[0].GetProperty("description").GetString() ?? "-";
            string icon = root.GetProperty("weather")[0].GetProperty("icon").GetString() ?? "";

            lblCity.Text = cityName;
            lblTemp.Text = $"{temp:0} °C";
            lblDesc.Text = desc;

            // ikon (opsiyonel)
            if (!string.IsNullOrWhiteSpace(icon) && pictureBoxWeather != null)
            {
                // ikon formatı: https://openweathermap.org/img/wn/10d@2x.png :contentReference[oaicite:2]{index=2}
                pictureBoxWeather.Load($"https://openweathermap.org/img/wn/{icon}@2x.png");
            }
        }
        public AdminForm()
        {
            InitializeComponent();
        }





        private void button3_Click(object sender, EventArgs e)
        {
            StockForm form = new StockForm();
            this.Hide();

            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            this.Hide();

            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }



        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            this.Hide();

            saleForm.FormClosed += (s, args) => this.Show();
            saleForm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            this.Hide();

            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonMonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxWeather_Click(object sender, EventArgs e)
        {

        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
