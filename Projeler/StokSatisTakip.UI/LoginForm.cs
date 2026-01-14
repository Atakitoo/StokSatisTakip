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
using StokSatisTakip.Entities.Concrete;


namespace StokSatisTakip.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                UserService userService = new UserService();
                User user = userService.Login(email, password);

                // Rol kontrolü
                if (user.Role == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else if (user.Role == "Sales")
                {
                    SalesForm salesForm = new SalesForm();
                    salesForm.Show();
                }
                else if (user.Role == "Warehouse")
                {
                    WarehouseForm warehouseForm = new WarehouseForm();
                    warehouseForm.Show();
                }
                else
                {
                    MessageBox.Show("Tanımsız rol!");
                    return;
                }

                this.Hide(); // LoginForm kapanır
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Giriş Hatası",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            var r = p.ClientRectangle;
            r.Inflate(-1, -1);

            using var pen = new Pen(Color.FromArgb(220, 220, 220));
            e.Graphics.DrawRectangle(pen, r);
        }
    }
}

