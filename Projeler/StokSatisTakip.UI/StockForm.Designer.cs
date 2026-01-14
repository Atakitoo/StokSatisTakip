namespace StokSatisTakip.UI
{
    partial class StockForm
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
            label1 = new Label();
            txtUrunAdi = new TextBox();
            label2 = new Label();
            txtUrunId = new TextBox();
            label3 = new Label();
            txtAlisFiyati = new TextBox();
            label4 = new Label();
            txtSatisFiyati = new TextBox();
            label5 = new Label();
            txtAlinanMiktar = new TextBox();
            label6 = new Label();
            txtUrunTuru = new TextBox();
            btnEkleGuncelle = new Button();
            dgvUrunler = new DataGridView();
            dtpSatinAlinanTarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(48, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(48, 75);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(125, 27);
            txtUrunAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(48, 105);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 8;
            label2.Text = "Ürün ID :";
            // 
            // txtUrunId
            // 
            txtUrunId.Location = new Point(48, 133);
            txtUrunId.Name = "txtUrunId";
            txtUrunId.Size = new Size(241, 27);
            txtUrunId.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(48, 163);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 10;
            label3.Text = "Ürün Alış Fiyatı :";
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.Location = new Point(48, 191);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(241, 27);
            txtAlisFiyati.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(48, 221);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 12;
            label4.Text = "Ürün Satış Fiyatı :";
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Location = new Point(48, 249);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(241, 27);
            txtSatisFiyati.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(48, 279);
            label5.Name = "label5";
            label5.Size = new Size(185, 25);
            label5.TabIndex = 14;
            label5.Text = "Alınan Ürün Miktarı :";
            // 
            // txtAlinanMiktar
            // 
            txtAlinanMiktar.Location = new Point(48, 307);
            txtAlinanMiktar.Name = "txtAlinanMiktar";
            txtAlinanMiktar.Size = new Size(241, 27);
            txtAlinanMiktar.TabIndex = 15;
            txtAlinanMiktar.TextChanged += txtAlinanMiktar_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(48, 337);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 16;
            label6.Text = "Ürün Türü :";
            // 
            // txtUrunTuru
            // 
            txtUrunTuru.Location = new Point(48, 365);
            txtUrunTuru.Name = "txtUrunTuru";
            txtUrunTuru.Size = new Size(241, 27);
            txtUrunTuru.TabIndex = 17;
            txtUrunTuru.TextChanged += txtUrunTuru_TextChanged;
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkleGuncelle.Location = new Point(48, 422);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(241, 50);
            btnEkleGuncelle.TabIndex = 18;
            btnEkleGuncelle.Text = "Ekle/Güncelle";
            btnEkleGuncelle.UseVisualStyleBackColor = true;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrunler.BackgroundColor = Color.PowderBlue;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(441, 44);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(865, 443);
            dgvUrunler.TabIndex = 19;
            dgvUrunler.CellContentClick += dgvUrunler_CellClick;
            // 
            // dtpSatinAlinanTarih
            // 
            dtpSatinAlinanTarih.CustomFormat = "dd.MM.yyyy";
            dtpSatinAlinanTarih.Format = DateTimePickerFormat.Custom;
            dtpSatinAlinanTarih.Location = new Point(441, 511);
            dtpSatinAlinanTarih.Name = "dtpSatinAlinanTarih";
            dtpSatinAlinanTarih.Size = new Size(226, 27);
            dtpSatinAlinanTarih.TabIndex = 20;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1341, 683);
            Controls.Add(dtpSatinAlinanTarih);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkleGuncelle);
            Controls.Add(txtUrunTuru);
            Controls.Add(label6);
            Controls.Add(txtAlinanMiktar);
            Controls.Add(label5);
            Controls.Add(txtSatisFiyati);
            Controls.Add(label4);
            Controls.Add(txtAlisFiyati);
            Controls.Add(label3);
            Controls.Add(txtUrunId);
            Controls.Add(label2);
            Controls.Add(txtUrunAdi);
            Controls.Add(label1);
            Name = "StockForm";
            Text = "StockForm";
            Load += StockForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUrunAdi;
        private Label label2;
        private TextBox txtUrunId;
        private Label label3;
        private TextBox txtAlisFiyati;
        private Label label4;
        private TextBox txtSatisFiyati;
        private Label label5;
        private TextBox txtAlinanMiktar;
        private Label label6;
        private TextBox txtUrunTuru;
        private Button btnEkleGuncelle;
        private DataGridView dgvUrunler;
        private DateTimePicker dtpSatinAlinanTarih;
    }
}