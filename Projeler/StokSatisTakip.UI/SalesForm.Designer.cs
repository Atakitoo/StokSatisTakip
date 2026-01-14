namespace StokSatisTakip.UI
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            btnProduct = new Button();
            btnCustomer = new Button();
            tlpMain = new TableLayoutPanel();
            pnlMenu = new Panel();
            pictureBox2 = new PictureBox();
            lblSatısGorev = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlContent = new Panel();
            lblDesc = new Label();
            lblTemp = new Label();
            lblCity = new Label();
            pictureBoxWeather = new PictureBox();
            panel1 = new Panel();
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            kryptonMonthCalendar1 = new Krypton.Toolkit.KryptonMonthCalendar();
            tlpMain.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonMonthCalendar1
            // 
            kryptonMonthCalendar1.Location = new Point(489, 370);
            kryptonMonthCalendar1.MaxSelectionCount = 1;
            kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            kryptonMonthCalendar1.Size = new Size(293, 218);
            kryptonMonthCalendar1.TabIndex = 0;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(3, 3);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(220, 33);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Satış Formuna Git";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(3, 42);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(220, 33);
            btnCustomer.TabIndex = 8;
            btnCustomer.Text = "Müşteri Formuna Git";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlMenu, 0, 0);
            tlpMain.Controls.Add(pnlContent, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(1077, 603);
            tlpMain.TabIndex = 9;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.PaleGoldenrod;
            pnlMenu.Controls.Add(pictureBox2);
            pnlMenu.Controls.Add(lblSatısGorev);
            pnlMenu.Controls.Add(flowLayoutPanel1);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(3, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Padding = new Padding(12);
            pnlMenu.Size = new Size(274, 597);
            pnlMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-28, 513);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 108);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // lblSatısGorev
            // 
            lblSatısGorev.AutoSize = true;
            lblSatısGorev.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSatısGorev.Location = new Point(15, 12);
            lblSatısGorev.Name = "lblSatısGorev";
            lblSatısGorev.Size = new Size(244, 46);
            lblSatısGorev.TabIndex = 0;
            lblSatısGorev.Text = "Satış Görevlisi";
            lblSatısGorev.Click += lblSatısGorev_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnProduct);
            flowLayoutPanel1.Controls.Add(btnCustomer);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(24, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(235, 125);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LemonChiffon;
            pnlContent.Controls.Add(lblTemp);
            pnlContent.Controls.Add(lblDesc);
            pnlContent.Controls.Add(lblCity);
            pnlContent.Controls.Add(pictureBoxWeather);
            pnlContent.Controls.Add(kryptonMonthCalendar1);
            pnlContent.Controls.Add(panel1);
            pnlContent.Controls.Add(lblHeader);
            pnlContent.Controls.Add(pictureBox1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(283, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(791, 597);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Location = new Point(231, 496);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(15, 20);
            lblDesc.TabIndex = 7;
            lblDesc.Text = "-";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.BackColor = Color.Transparent;
            lblTemp.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTemp.Location = new Point(231, 430);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(90, 54);
            lblTemp.TabIndex = 6;
            lblTemp.Text = "- °C";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCity.ForeColor = Color.Black;
            lblCity.Location = new Point(231, 395);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(83, 25);
            lblCity.TabIndex = 5;
            lblCity.Text = "Eskişehir";
            // 
            // pictureBoxWeather
            // 
            pictureBoxWeather.BackColor = Color.Transparent;
            pictureBoxWeather.BackgroundImage = (Image)resources.GetObject("pictureBoxWeather.BackgroundImage");
            pictureBoxWeather.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxWeather.Location = new Point(41, 395);
            pictureBoxWeather.Name = "pictureBoxWeather";
            pictureBoxWeather.Size = new Size(171, 150);
            pictureBoxWeather.TabIndex = 4;
            pictureBoxWeather.TabStop = false;
            pictureBoxWeather.Click += pictureBoxWeather_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(489, 103);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16);
            panel1.Size = new Size(293, 214);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblHeader.Location = new Point(29, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(235, 46);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hoş Geldiniz";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LemonChiffon;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Location = new Point(29, 370);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 188);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1077, 603);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Görevlisi Form";
            tlpMain.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnProduct;
        private Button btnCustomer;
        private TableLayoutPanel tlpMain;
        private Panel pnlMenu;
        private Label lblSatısGorev;
        private Panel pnlContent;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblHeader;
        private Panel panel1;
        private PictureBox pictureBoxWeather;
        private Label lblCity;
        private Label lblTemp;
        private Label lblDesc;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}