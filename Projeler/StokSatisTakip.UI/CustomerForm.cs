using StokSatisTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokSatisTakip.BLL.Concrete;

namespace StokSatisTakip.UI
{

    public partial class CustomerForm : Form
    {
        CustomerService service = new CustomerService();
        int selectedCustomerId = 0;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            dgvCustomers.CellClick += dgvCustomers_CellClick;
        }
        void LoadCustomers()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = service.GetAll();
        }
        private void dgvCustomers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selected = dgvCustomers.Rows[e.RowIndex].DataBoundItem as Customer;
            if (selected == null) return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new StokSatisTakip.Entities.Concrete.Customer
            {
                Id = selectedCustomerId,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                CustomerType = txtType.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            service.Save(customer);

            MessageBox.Show(selectedCustomerId == 0 ? "Kayıt eklendi" : "Kayıt güncellendi");

            ClearFields();
            LoadCustomers();
        }
        void ClearFields()
        {
            selectedCustomerId = 0;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtType.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            btnSave.Text = "Kayıt Yap";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var list = service.GetAll();
            dgvCustomers.DataSource = list
                .Where(x => x.FirstName.Contains(txtSearch.Text))
                .ToList();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header'a tıklayınca patlamasın

            // En sağlam yöntem: satırın DataBoundItem'ını Customer olarak almak
            var customer = dgvCustomers.Rows[e.RowIndex].DataBoundItem as StokSatisTakip.Entities.Concrete.Customer;
            if (customer == null) return;

            selectedCustomerId = customer.Id;
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtType.Text = customer.CustomerType;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;

            btnSave.Text = "Güncelle";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Seçili müşteriyi silmek istiyor musunuz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                service.Delete(selectedCustomerId);

                MessageBox.Show("Müşteri silindi");

                ClearFields();
                LoadCustomers();
            }
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }
    }
}
