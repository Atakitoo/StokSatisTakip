namespace StokSatisTakip.UI
{
    partial class WarehouseForm
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
            Krypton.Toolkit.KryptonMonthCalendar kryptonMonthCalendar1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseForm));
            btnStock = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            lblDepoGorev = new Label();
            panel2 = new Panel();
            lblDesc = new Label();
            lblTemp = new Label();
            lblCity = new Label();
            pictureBoxWeather = new PictureBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            lblHeader = new Label();
            kryptonMonthCalendar1 = new Krypton.Toolkit.KryptonMonthCalendar();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonMonthCalendar1
            // 
            kryptonMonthCalendar1.Location = new Point(701, 448);
            kryptonMonthCalendar1.MaxSelectionCount = 1;
            kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            kryptonMonthCalendar1.Size = new Size(293, 218);
            kryptonMonthCalendar1.TabIndex = 3;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(8, 30);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(201, 33);
            btnStock.TabIndex = 4;
            btnStock.Text = "Stok Formuna Git";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1395, 753);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Moccasin;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lblDepoGorev);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16);
            panel1.Size = new Size(274, 745);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-22, 661);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 108);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnStock);
            panel3.Location = new Point(19, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 96);
            panel3.TabIndex = 1;
            // 
            // lblDepoGorev
            // 
            lblDepoGorev.AutoSize = true;
            lblDepoGorev.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDepoGorev.Location = new Point(19, 16);
            lblDepoGorev.Name = "lblDepoGorev";
            lblDepoGorev.Size = new Size(211, 38);
            lblDepoGorev.TabIndex = 0;
            lblDepoGorev.Text = "Depo Görevlisi ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cornsilk;
            panel2.Controls.Add(lblDesc);
            panel2.Controls.Add(lblTemp);
            panel2.Controls.Add(lblCity);
            panel2.Controls.Add(pictureBoxWeather);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(kryptonMonthCalendar1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lblHeader);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(285, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 745);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Location = new Point(306, 595);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(15, 20);
            lblDesc.TabIndex = 13;
            lblDesc.Text = "-";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTemp.Location = new Point(306, 524);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(90, 54);
            lblTemp.TabIndex = 12;
            lblTemp.Text = "- °C";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCity.ForeColor = Color.Black;
            lblCity.Location = new Point(306, 480);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(83, 25);
            lblCity.TabIndex = 11;
            lblCity.Text = "Eskişehir";
            // 
            // pictureBoxWeather
            // 
            pictureBoxWeather.BackColor = Color.Transparent;
            pictureBoxWeather.BackgroundImage = (Image)resources.GetObject("pictureBoxWeather.BackgroundImage");
            pictureBoxWeather.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxWeather.Location = new Point(83, 480);
            pictureBoxWeather.Name = "pictureBoxWeather";
            pictureBoxWeather.Size = new Size(171, 150);
            pictureBoxWeather.TabIndex = 10;
            pictureBoxWeather.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Location = new Point(56, 448);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 218);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(701, 179);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(16);
            panel4.Size = new Size(293, 214);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblHeader.Location = new Point(19, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(235, 46);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Hoş Geldiniz";
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1395, 753);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WarehouseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Depo Görevlisi Formu";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnStock;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lblDepoGorev;
        private Panel panel2;
        private Panel panel3;
        private Label lblHeader;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxWeather;
        private Label lblCity;
        private Label lblTemp;
        private Label lblDesc;
        private PictureBox pictureBox2;
    }
}