namespace StokSatisTakip.UI
{
    partial class ReportForm
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
            cmbReportType = new ComboBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnShowReport = new Button();
            dgvReport = new DataGridView();
            lblTotalRevenueTitle = new Label();
            label2 = new Label();
            lblTotalDiscountTitle = new Label();
            label4 = new Label();
            lblTotalProfitTitle = new Label();
            label6 = new Label();
            lblTotalRevenueValue = new Label();
            lblTotalDiscountValue = new Label();
            lblTotalProfitValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Aylık Satış", "En Çok Satan Ürünler", "Müşteri Bazlı Satış", "Kâr/Zarar", "Minimum Stok" });
            cmbReportType.Location = new Point(26, 21);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(346, 28);
            cmbReportType.TabIndex = 0;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(394, 22);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 27);
            dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(665, 22);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 27);
            dtpEnd.TabIndex = 2;
            // 
            // btnShowReport
            // 
            btnShowReport.Location = new Point(937, 23);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(131, 29);
            btnShowReport.TabIndex = 3;
            btnShowReport.Text = "Raporu Göster";
            btnShowReport.UseVisualStyleBackColor = true;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = Color.LightBlue;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(26, 96);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1059, 489);
            dgvReport.TabIndex = 4;
            // 
            // lblTotalRevenueTitle
            // 
            lblTotalRevenueTitle.AutoSize = true;
            lblTotalRevenueTitle.Location = new Point(42, 622);
            lblTotalRevenueTitle.Name = "lblTotalRevenueTitle";
            lblTotalRevenueTitle.Size = new Size(93, 20);
            lblTotalRevenueTitle.TabIndex = 5;
            lblTotalRevenueTitle.Text = "Toplam Ciro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 622);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // lblTotalDiscountTitle
            // 
            lblTotalDiscountTitle.AutoSize = true;
            lblTotalDiscountTitle.Location = new Point(288, 622);
            lblTotalDiscountTitle.Name = "lblTotalDiscountTitle";
            lblTotalDiscountTitle.Size = new Size(113, 20);
            lblTotalDiscountTitle.TabIndex = 7;
            lblTotalDiscountTitle.Text = "Toplam İndirim:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 622);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // lblTotalProfitTitle
            // 
            lblTotalProfitTitle.AutoSize = true;
            lblTotalProfitTitle.Location = new Point(572, 622);
            lblTotalProfitTitle.Name = "lblTotalProfitTitle";
            lblTotalProfitTitle.Size = new Size(116, 20);
            lblTotalProfitTitle.TabIndex = 9;
            lblTotalProfitTitle.Text = "Toplam Net Kâr:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(609, 622);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            lblTotalRevenueValue.Location = new Point(141, 622);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new Size(15, 20);
            lblTotalRevenueValue.TabIndex = 11;
            lblTotalRevenueValue.Text = "-";
            // 
            // lblTotalDiscountValue
            // 
            lblTotalDiscountValue.AutoSize = true;
            lblTotalDiscountValue.Location = new Point(407, 622);
            lblTotalDiscountValue.Name = "lblTotalDiscountValue";
            lblTotalDiscountValue.Size = new Size(15, 20);
            lblTotalDiscountValue.TabIndex = 12;
            lblTotalDiscountValue.Text = "-";
            // 
            // lblTotalProfitValue
            // 
            lblTotalProfitValue.AutoSize = true;
            lblTotalProfitValue.Location = new Point(694, 622);
            lblTotalProfitValue.Name = "lblTotalProfitValue";
            lblTotalProfitValue.Size = new Size(15, 20);
            lblTotalProfitValue.TabIndex = 13;
            lblTotalProfitValue.Text = "-";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1291, 697);
            Controls.Add(lblTotalProfitValue);
            Controls.Add(lblTotalDiscountValue);
            Controls.Add(lblTotalRevenueValue);
            Controls.Add(label6);
            Controls.Add(lblTotalProfitTitle);
            Controls.Add(label4);
            Controls.Add(lblTotalDiscountTitle);
            Controls.Add(label2);
            Controls.Add(lblTotalRevenueTitle);
            Controls.Add(dgvReport);
            Controls.Add(btnShowReport);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cmbReportType);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbReportType;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnShowReport;
        private DataGridView dgvReport;
        private Label lblTotalRevenueTitle;
        private Label label2;
        private Label lblTotalDiscountTitle;
        private Label label4;
        private Label lblTotalProfitTitle;
        private Label label6;
        private Label lblTotalRevenueValue;
        private Label lblTotalDiscountValue;
        private Label lblTotalProfitValue;
    }
}