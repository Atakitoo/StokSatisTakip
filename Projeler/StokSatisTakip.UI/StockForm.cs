using StokSatisTakip.DAL.Concrete;
using StokSatisTakip.Entities.Concrete;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace StokSatisTakip.UI
{
    public partial class StockForm : Form
    {
        // DB işlemleri
        private readonly ProductRepository _productRepository = new ProductRepository();

        // null => ekle modundayız, dolu => güncelle modundayız
        private int? _selectedUrunId = null;

        public StockForm()
        {
            InitializeComponent();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // DateTimePicker format (hatasız tarih)
            dtpSatinAlinanTarih.Format = DateTimePickerFormat.Custom;
            dtpSatinAlinanTarih.CustomFormat = "dd.MM.yyyy";
            dtpSatinAlinanTarih.Value = DateTime.Today;

            // DataGridView ayarları
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.MultiSelect = false;
            dgvUrunler.ReadOnly = true;
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.RowHeadersVisible = false;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Şimdilik otomatik kolon üretsin:
            dgvUrunler.AutoGenerateColumns = true;

            LoadGridFromDb();
            FormModunuEkleyeAl();
        }

        private void LoadGridFromDb()
        {
            var products = _productRepository.GetAll();
            dgvUrunler.DataSource = null;
            dgvUrunler.DataSource = products;
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (!TryReadForm(out Product? product, out string error) || product is null)
            {
                MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_selectedUrunId == null)
                {
                    // EKLE
                    _productRepository.Add(product);
                    MessageBox.Show("Ürün eklendi.", "Bilgi");
                }
                else
                {
                    // GÜNCELLE
                    _productRepository.Update(product);
                    MessageBox.Show("Ürün güncellendi.", "Bilgi");
                }

                LoadGridFromDb();
                Temizle();
                FormModunuEkleyeAl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında hata: " + ex.Message, "Hata");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selected = dgvUrunler.Rows[e.RowIndex].DataBoundItem as Product;
            if (selected == null) return;

            // Soldaki alanları doldur
            txtUrunId.Text = selected.UrunId.ToString();
            txtUrunAdi.Text = selected.UrunAdi;
            txtAlisFiyati.Text = selected.AlisFiyati.ToString(CultureInfo.InvariantCulture);
            txtSatisFiyati.Text = selected.SatisFiyati.ToString(CultureInfo.InvariantCulture);

            // DB: Alinanmiktar => Entity: Stok
            txtAlinanMiktar.Text = selected.Stok.ToString();

            txtUrunTuru.Text = selected.UrunTuru;

            dtpSatinAlinanTarih.Value = selected.SatinAlinanTarih;

            // Mod değiştir
            _selectedUrunId = selected.UrunId;
            FormModunuGuncellemeyeAl();
        }

        private bool TryReadForm(out Product? product, out string error)
        {
            product = null;
            error = "";

            // Ürün ID
            if (!int.TryParse(txtUrunId.Text.Trim(), out int urunId))
            {
                error = "Ürün ID sayı olmalı.";
                return false;
            }

            // Ürün adı
            string urunAdi = txtUrunAdi.Text.Trim();
            if (string.IsNullOrWhiteSpace(urunAdi))
            {
                error = "Ürün İsmi boş olamaz.";
                return false;
            }

            // Fiyatlar (TR yazımda virgül gelebilir)
            string alisText = txtAlisFiyati.Text.Trim().Replace(',', '.');
            string satisText = txtSatisFiyati.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(alisText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal alis))
            {
                error = "Alış Fiyatı geçersiz. Örn: 1200 veya 1200.50";
                return false;
            }

            if (!decimal.TryParse(satisText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal satis))
            {
                error = "Satış Fiyatı geçersiz. Örn: 1500 veya 1500.50";
                return false;
            }

            // Stok (DB: Alinanmiktar)
            if (!int.TryParse(txtAlinanMiktar.Text.Trim(), out int stok))
            {
                error = "Alınan Miktar (stok) sayı olmalı.";
                return false;
            }

            if (stok < 0)
            {
                error = "Stok negatif olamaz.";
                return false;
            }

            // Tür
            string tur = txtUrunTuru.Text.Trim();
            if (string.IsNullOrWhiteSpace(tur))
            {
                error = "Ürün Türü boş olamaz.";
                return false;
            }

            if (satis < alis)
            {
                error = "Satış fiyatı alış fiyatından küçük olamaz.";
                return false;
            }

            product = new Product
            {
                UrunId = urunId,
                UrunAdi = urunAdi,
                AlisFiyati = alis,
                SatisFiyati = satis,
                Stok = stok,
                UrunTuru = tur,
                SatinAlinanTarih = dtpSatinAlinanTarih.Value.Date,

                // StockForm'da MinStok textbox yoksa varsayılan:
                MinStok = 5
            };

            return true;
        }

        private void Temizle()
        {
            txtUrunId.Clear();
            txtUrunAdi.Clear();
            txtAlisFiyati.Clear();
            txtSatisFiyati.Clear();
            txtAlinanMiktar.Clear();
            txtUrunTuru.Clear();
            dtpSatinAlinanTarih.Value = DateTime.Today;

            dgvUrunler.ClearSelection();
        }

        private void FormModunuEkleyeAl()
        {
            btnEkleGuncelle.Text = "EKLE";
            _selectedUrunId = null;
            txtUrunId.Enabled = true;
        }

        private void FormModunuGuncellemeyeAl()
        {
            btnEkleGuncelle.Text = "GÜNCELLE";
            txtUrunId.Enabled = false; // PK gibi davransın
        }

        private void txtUrunTuru_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlinanMiktar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}