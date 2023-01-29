namespace DesignPattern.CustomerProject.ViewLayer
{
    partial class frmCustomer
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBillDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbTypeCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 31;
            this.button1.Text = "Validation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(781, 302);
            this.dataGridView1.TabIndex = 30;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(438, 10);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(203, 23);
            this.txtBillAmount.TabIndex = 29;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(438, 82);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(203, 68);
            this.txtAddress.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Address : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Bill Date : ";
            // 
            // txtBillDate
            // 
            this.txtBillDate.Location = new System.Drawing.Point(438, 47);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(203, 23);
            this.txtBillDate.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bill Amount : ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 82);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(138, 23);
            this.txtPhone.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer Phone : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customer Name : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 23);
            this.txtName.TabIndex = 20;
            // 
            // cmbTypeCustomer
            // 
            this.cmbTypeCustomer.FormattingEnabled = true;
            this.cmbTypeCustomer.Items.AddRange(new object[] {
            "Customer",
            "Lead"});
            this.cmbTypeCustomer.Location = new System.Drawing.Point(139, 13);
            this.cmbTypeCustomer.Name = "cmbTypeCustomer";
            this.cmbTypeCustomer.Size = new System.Drawing.Size(138, 23);
            this.cmbTypeCustomer.TabIndex = 19;
            this.cmbTypeCustomer.Text = "Customer";
            this.cmbTypeCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbTypeCustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer Type : ";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBillDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbTypeCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txtBillAmount;
        private TextBox txtAddress;
        private Label label7;
        private Label label8;
        private TextBox txtBillDate;
        private Label label9;
        private TextBox txtPhone;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private ComboBox cmbTypeCustomer;
        private Label label1;
    }
}