namespace StokSatisTakip.UI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            btnSale = new Button();
            btnStock = new Button();
            btnReport = new Button();
            btnCustomer = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlMenu = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            lblYoneticiForm = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            kryptonMonthCalendar1 = new Krypton.Toolkit.KryptonMonthCalendar();
            panel1 = new Panel();
            pictureBoxWeather = new PictureBox();
            lblDesc = new Label();
            lblTemp = new Label();
            lblCity = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.White;
            btnSale.FlatAppearance.BorderColor = Color.LightGray;
            btnSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnSale.Location = new Point(15, 15);
            btnSale.Name = "btnSale";
            btnSale.Padding = new Padding(12, 0, 0, 0);
            btnSale.Size = new Size(201, 33);
            btnSale.TabIndex = 1;
            btnSale.Text = "Satış Formu";
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.White;
            btnStock.Location = new Point(15, 54);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(12, 0, 0, 0);
            btnStock.Size = new Size(201, 33);
            btnStock.TabIndex = 3;
            btnStock.Text = "Stok Formu";
            btnStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += button3_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.White;
            btnReport.Location = new Point(15, 15);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(12, 0, 0, 0);
            btnReport.Size = new Size(201, 33);
            btnReport.TabIndex = 4;
            btnReport.Text = "Rapor Ekranı";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnCustomerReport_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.White;
            btnCustomer.Location = new Point(15, 93);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(12, 0, 0, 0);
            btnCustomer.Size = new Size(201, 33);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "Müşteri Formu";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1243, 627);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Honeydew;
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlMenu.Controls.Add(pictureBox2);
            pnlMenu.Controls.Add(label3);
            pnlMenu.Controls.Add(flowLayoutPanel2);
            pnlMenu.Controls.Add(flowLayoutPanel1);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(lblYoneticiForm);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(4, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(274, 619);
            pnlMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-18, 732);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 84);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(16, 285);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 4;
            label3.Text = "Rapor Ekranları";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(btnReport);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(9, 330);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(12);
            flowLayoutPanel2.Size = new Size(233, 68);
            flowLayoutPanel2.TabIndex = 3;
            flowLayoutPanel2.WrapContents = false;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(btnSale);
            flowLayoutPanel1.Controls.Add(btnStock);
            flowLayoutPanel1.Controls.Add(btnCustomer);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(9, 110);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(12);
            flowLayoutPanel1.Size = new Size(233, 144);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(16, 73);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 1;
            label1.Text = "Formlar ";
            // 
            // lblYoneticiForm
            // 
            lblYoneticiForm.AutoSize = true;
            lblYoneticiForm.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYoneticiForm.Location = new Point(9, 6);
            lblYoneticiForm.Name = "lblYoneticiForm";
            lblYoneticiForm.Size = new Size(206, 38);
            lblYoneticiForm.TabIndex = 0;
            lblYoneticiForm.Text = "Yönetici Formu";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.MintCream;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.66667F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(kryptonMonthCalendar1, 1, 2);
            tableLayoutPanel2.Controls.Add(panel1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(285, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(954, 619);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(18, 16, 18, 0);
            label2.Size = new Size(483, 90);
            label2.TabIndex = 0;
            label2.Text = "Hoş geldiniz";
            label2.Click += label2_Click;
            // 
            // kryptonMonthCalendar1
            // 
            kryptonMonthCalendar1.ControlBorderStyle = Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone;
            kryptonMonthCalendar1.DayOfWeekStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonMonthCalendar1.DayStyle = Krypton.Toolkit.ButtonStyle.BreadCrumb;
            kryptonMonthCalendar1.Dock = DockStyle.Bottom;
            kryptonMonthCalendar1.HeaderStyle = Krypton.Toolkit.HeaderStyle.Custom1;
            kryptonMonthCalendar1.Location = new Point(492, 384);
            kryptonMonthCalendar1.MaxSelectionCount = 1;
            kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            kryptonMonthCalendar1.Size = new Size(293, 241);
            kryptonMonthCalendar1.TabIndex = 1;
            kryptonMonthCalendar1.DateChanged += kryptonMonthCalendar1_DateChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxWeather);
            panel1.Controls.Add(lblDesc);
            panel1.Controls.Add(lblTemp);
            panel1.Controls.Add(lblCity);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(492, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 258);
            panel1.TabIndex = 2;
            // 
            // pictureBoxWeather
            // 
            pictureBoxWeather.BackColor = Color.Transparent;
            pictureBoxWeather.BackgroundImage = (Image)resources.GetObject("pictureBoxWeather.BackgroundImage");
            pictureBoxWeather.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxWeather.Location = new Point(34, 34);
            pictureBoxWeather.Name = "pictureBoxWeather";
            pictureBoxWeather.Size = new Size(171, 150);
            pictureBoxWeather.TabIndex = 3;
            pictureBoxWeather.TabStop = false;
            pictureBoxWeather.Click += pictureBoxWeather_Click;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Location = new Point(260, 139);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(15, 20);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "-";
            lblDesc.Click += lblDesc_Click;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTemp.Location = new Point(260, 73);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(90, 54);
            lblTemp.TabIndex = 1;
            lblTemp.Text = "- °C";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCity.ForeColor = Color.Black;
            lblCity.Location = new Point(260, 34);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(83, 25);
            lblCity.TabIndex = 0;
            lblCity.Text = "Eskişehir";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Location = new Point(0, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 217);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1243, 627);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetici Formu";
            Load += AdminForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSale;
        private Button btnStock;
        private Button btnReport;
        private Button btnCustomer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlMenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label lblYoneticiForm;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Krypton.Toolkit.KryptonMonthCalendar kryptonMonthCalendar1;
        private Panel panel1;
        private Label lblDesc;
        private Label lblTemp;
        private Label lblCity;
        private PictureBox pictureBoxWeather;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}