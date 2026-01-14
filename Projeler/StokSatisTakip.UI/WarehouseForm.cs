using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokSatisTakip.UI
{
    public partial class WarehouseForm : Form
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
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

            StockForm form = new StockForm();
            this.Hide();

            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            var r = p.ClientRectangle;
            r.Inflate(-1, -1);
            using var pen = new Pen(Color.FromArgb(220, 220, 220));
            e.Graphics.DrawRectangle(pen, r);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

