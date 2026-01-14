namespace StokSatisTakip.UI
{
    partial class SaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCustomers = new DataGridView();
            dgvProducts = new DataGridView();
            lblMusteriBilgi = new Label();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new TextBox();
            txtCustomerEmail = new TextBox();
            lblMusteriName = new Label();
            lblMusteriPhone = new Label();
            lblMusteriEmail = new Label();
            lglUrunBilgileri = new Label();
            txtProductName = new TextBox();
            txtStock = new TextBox();
            txtListPrice = new TextBox();
            lblUrunName = new Label();
            lblStock = new Label();
            lblListPrice = new Label();
            txtQuantity = new TextBox();
            txtSalePrice = new TextBox();
            lblSatısAdeti = new Label();
            lblSatısFiyatı = new Label();
            btnSell = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = Color.SkyBlue;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(32, 52);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(633, 322);
            dgvCustomers.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.SkyBlue;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(755, 52);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(597, 322);
            dgvProducts.TabIndex = 1;
            // 
            // lblMusteriBilgi
            // 
            lblMusteriBilgi.AutoSize = true;
            lblMusteriBilgi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMusteriBilgi.Location = new Point(32, 24);
            lblMusteriBilgi.Name = "lblMusteriBilgi";
            lblMusteriBilgi.Size = new Size(155, 25);
            lblMusteriBilgi.TabIndex = 2;
            lblMusteriBilgi.Text = "Müşteri Bilgileri :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(403, 438);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(176, 27);
            txtCustomerName.TabIndex = 3;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(403, 500);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(176, 27);
            txtCustomerPhone.TabIndex = 4;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(403, 559);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(176, 27);
            txtCustomerEmail.TabIndex = 5;
            // 
            // lblMusteriName
            // 
            lblMusteriName.AutoSize = true;
            lblMusteriName.Location = new Point(403, 415);
            lblMusteriName.Name = "lblMusteriName";
            lblMusteriName.Size = new Size(116, 20);
            lblMusteriName.TabIndex = 6;
            lblMusteriName.Text = "Müşterinin İsmi :";
            // 
            // lblMusteriPhone
            // 
            lblMusteriPhone.AutoSize = true;
            lblMusteriPhone.Location = new Point(403, 477);
            lblMusteriPhone.Name = "lblMusteriPhone";
            lblMusteriPhone.Size = new Size(185, 20);
            lblMusteriPhone.TabIndex = 7;
            lblMusteriPhone.Text = "Müşteri Telefon Numarası :";
            // 
            // lblMusteriEmail
            // 
            lblMusteriEmail.AutoSize = true;
            lblMusteriEmail.Location = new Point(403, 536);
            lblMusteriEmail.Name = "lblMusteriEmail";
            lblMusteriEmail.Size = new Size(130, 20);
            lblMusteriEmail.TabIndex = 8;
            lblMusteriEmail.Text = "Müşterinin Emaili :";
            // 
            // lglUrunBilgileri
            // 
            lglUrunBilgileri.AutoSize = true;
            lglUrunBilgileri.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lglUrunBilgileri.Location = new Point(761, 24);
            lglUrunBilgileri.Name = "lglUrunBilgileri";
            lglUrunBilgileri.Size = new Size(132, 25);
            lglUrunBilgileri.TabIndex = 9;
            lglUrunBilgileri.Text = "Ürün Bilgileri :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(831, 441);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(207, 27);
            txtProductName.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.BackColor = SystemColors.Window;
            txtStock.Location = new Point(831, 493);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(207, 27);
            txtStock.TabIndex = 11;
            // 
            // txtListPrice
            // 
            txtListPrice.BackColor = SystemColors.Window;
            txtListPrice.Location = new Point(831, 555);
            txtListPrice.Name = "txtListPrice";
            txtListPrice.ReadOnly = true;
            txtListPrice.Size = new Size(207, 27);
            txtListPrice.TabIndex = 12;
            // 
            // lblUrunName
            // 
            lblUrunName.AutoSize = true;
            lblUrunName.Location = new Point(831, 415);
            lblUrunName.Name = "lblUrunName";
            lblUrunName.Size = new Size(94, 20);
            lblUrunName.TabIndex = 13;
            lblUrunName.Text = "Ürünün İsmi :";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(832, 470);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(145, 20);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stokta Kalan Miktar :";
            // 
            // lblListPrice
            // 
            lblListPrice.AutoSize = true;
            lblListPrice.Location = new Point(832, 523);
            lblListPrice.Name = "lblListPrice";
            lblListPrice.Size = new Size(136, 20);
            lblListPrice.TabIndex = 15;
            lblListPrice.Text = "Ürünün Liste Fiyatı :";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(611, 438);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(168, 27);
            txtQuantity.TabIndex = 16;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(611, 497);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(168, 27);
            txtSalePrice.TabIndex = 17;
            // 
            // lblSatısAdeti
            // 
            lblSatısAdeti.AutoSize = true;
            lblSatısAdeti.Location = new Point(611, 415);
            lblSatısAdeti.Name = "lblSatısAdeti";
            lblSatısAdeti.Size = new Size(121, 20);
            lblSatısAdeti.TabIndex = 18;
            lblSatısAdeti.Text = "Satılacak Miktar :";
            // 
            // lblSatısFiyatı
            // 
            lblSatısFiyatı.AutoSize = true;
            lblSatısFiyatı.Location = new Point(611, 474);
            lblSatısFiyatı.Name = "lblSatısFiyatı";
            lblSatısFiyatı.Size = new Size(86, 20);
            lblSatısFiyatı.TabIndex = 19;
            lblSatısFiyatı.Text = "Satış Fiyatı :";
            // 
            // btnSell
            // 
            btnSell.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSell.Location = new Point(611, 549);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(168, 45);
            btnSell.TabIndex = 20;
            btnSell.Text = "SATIŞ YAP";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1364, 711);
            Controls.Add(btnSell);
            Controls.Add(lblSatısFiyatı);
            Controls.Add(lblSatısAdeti);
            Controls.Add(txtSalePrice);
            Controls.Add(txtQuantity);
            Controls.Add(lblListPrice);
            Controls.Add(lblStock);
            Controls.Add(lblUrunName);
            Controls.Add(txtListPrice);
            Controls.Add(txtStock);
            Controls.Add(txtProductName);
            Controls.Add(lglUrunBilgileri);
            Controls.Add(lblMusteriEmail);
            Controls.Add(lblMusteriPhone);
            Controls.Add(lblMusteriName);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerPhone);
            Controls.Add(txtCustomerName);
            Controls.Add(lblMusteriBilgi);
            Controls.Add(dgvProducts);
            Controls.Add(dgvCustomers);
            Name = "SaleForm";
            Text = "SaleForm";
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private DataGridView dgvProducts;
        private Label lblMusteriBilgi;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomerEmail;
        private Label lblMusteriName;
        private Label lblMusteriPhone;
        private Label lblMusteriEmail;
        private Label lglUrunBilgileri;
        private TextBox txtProductName;
        private TextBox txtStock;
        private TextBox txtListPrice;
        private Label lblUrunName;
        private Label lblStock;
        private Label lblListPrice;
        private TextBox txtQuantity;
        private TextBox txtSalePrice;
        private Label lblSatısAdeti;
        private Label lblSatısFiyatı;
        private Button btnSell;
    }
}