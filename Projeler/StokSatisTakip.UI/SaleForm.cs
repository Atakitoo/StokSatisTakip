using StokSatisTakip.DAL.Concrete;
using StokSatisTakip.Entities.Concrete;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace StokSatisTakip.UI
{
    public partial class SaleForm : Form
    {
        private readonly CustomerRepository _customerRepo = new CustomerRepository();
        private readonly ProductRepository _productRepo = new ProductRepository();
        private readonly SalesRepository _salesRepo = new SalesRepository();

        private int? _selectedCustomerId = null;
        private int? _selectedProductId = null;

        private decimal _selectedListPrice = 0m; // ürünün liste satış fiyatı (products.SatisFiyati)
        private decimal _selectedCostPrice = 0m; // ürünün alış fiyatı (products.AlisFiyati)

        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            // Grid ayarları
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.AutoGenerateColumns = true;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoGenerateColumns = true;

            // ReadOnly textboxlar
            txtCustomerName.ReadOnly = true;
            txtCustomerPhone.ReadOnly = true;
            txtCustomerEmail.ReadOnly = true;

            txtProductName.ReadOnly = true;
            txtStock.ReadOnly = true;
            txtListPrice.ReadOnly = true;

            LoadCustomers();
            LoadProducts();

            // Event önerisi: CellClick kullan
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            dgvProducts.CellClick += dgvProducts_CellClick;
        }

        private void LoadCustomers()
        {
            var customers = _customerRepo.GetAll();
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;
        }

        private void LoadProducts()
        {
            var products = _productRepo.GetAll();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }

        private void dgvCustomers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selected = dgvCustomers.Rows[e.RowIndex].DataBoundItem as Customer;
            if (selected == null) return;

            _selectedCustomerId = selected.Id;

            txtCustomerName.Text = $"{selected.FirstName} {selected.LastName}";
            txtCustomerPhone.Text = selected.Phone ?? "";
            txtCustomerEmail.Text = selected.Email ?? "";
        }

        private void dgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selected = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
            if (selected == null) return;

            _selectedProductId = selected.UrunId;

            txtProductName.Text = selected.UrunAdi;
            txtStock.Text = selected.Stok.ToString();

            _selectedCostPrice = selected.AlisFiyati;
            _selectedListPrice = selected.SatisFiyati;

            txtListPrice.Text = _selectedListPrice.ToString(CultureInfo.InvariantCulture);
            txtSalePrice.Text = _selectedListPrice.ToString(CultureInfo.InvariantCulture);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId == null)
            {
                MessageBox.Show("Önce bir müşteri seçmelisin.");
                return;
            }

            if (_selectedProductId == null)
            {
                MessageBox.Show("Önce bir ürün seçmelisin.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Satılacak miktar geçersiz.");
                return;
            }

            // Satış fiyatı parse (virgül/nokta)
            string salePriceText = txtSalePrice.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(salePriceText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal unitSalePrice) || unitSalePrice <= 0)
            {
                MessageBox.Show("Satış fiyatı geçersiz.");
                return;
            }

            try
            {
                int saleId = _salesRepo.CreateSingleSaleTransaction(
                    customerId: _selectedCustomerId.Value,
                    productId: _selectedProductId.Value,
                    quantity: qty,
                    unitListPrice: _selectedListPrice,
                    unitSalePrice: unitSalePrice,
                    unitCostPrice: _selectedCostPrice
                );

                int newStock = _salesRepo.GetCurrentStock(_selectedProductId.Value);
                int minStock = _salesRepo.GetMinStock(_selectedProductId.Value);

                string msg = $"Satış başarılı. SaleId: {saleId}\nYeni Stok: {newStock}";
                if (newStock <= minStock)
                    msg += $"\nUYARI: Stok minimum seviyenin altına indi! (MinStok: {minStock})";

                MessageBox.Show(msg);

                // ürünleri yenile (stok güncellensin)
                LoadProducts();

                // miktarı temizle, stok textbox güncelle
                txtQuantity.Clear();
                txtStock.Text = newStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış başarısız: " + ex.Message);
            }
        }
    }
}