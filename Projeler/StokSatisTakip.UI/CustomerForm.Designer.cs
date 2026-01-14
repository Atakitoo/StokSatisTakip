namespace StokSatisTakip.UI
{
    partial class CustomerForm
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
            lblName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lbltur = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtType = new TextBox();
            dgvCustomers = new DataGridView();
            btnSave = new Button();
            txtSearch = new TextBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblName.Location = new Point(54, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 25);
            lblName.TabIndex = 0;
            lblName.Text = "İsim:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLastName.Location = new Point(54, 110);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(80, 25);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Soyisim:";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEmail.Location = new Point(54, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(82, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-Posta :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblPhone.Location = new Point(54, 195);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(104, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Telefon No:";
            // 
            // lbltur
            // 
            lbltur.AutoSize = true;
            lbltur.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbltur.Location = new Point(85, 234);
            lbltur.Name = "lbltur";
            lbltur.Size = new Size(48, 25);
            lbltur.TabIndex = 4;
            lbltur.Text = "Tür :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(171, 69);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(245, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(171, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(245, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(171, 193);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(245, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtType
            // 
            txtType.Location = new Point(171, 234);
            txtType.Name = "txtType";
            txtType.Size = new Size(245, 27);
            txtType.TabIndex = 9;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = Color.LightBlue;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(454, 69);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(728, 429);
            dgvCustomers.TabIndex = 10;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(171, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(245, 49);
            btnSave.TabIndex = 11;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(454, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(728, 27);
            txtSearch.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(171, 360);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(245, 46);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Kayıt Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1373, 716);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
            Controls.Add(dgvCustomers);
            Controls.Add(txtType);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lbltur);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            ForeColor = SystemColors.ControlText;
            Name = "CustomerForm";
            Text = "Customer";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lbltur;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtType;
        private DataGridView dgvCustomers;
        private Button btnSave;
        private TextBox txtSearch;
        private Button btnDelete;
    }
}