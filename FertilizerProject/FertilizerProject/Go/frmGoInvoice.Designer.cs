namespace FertilizerProject
{
    partial class frmGoInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFertCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFertilizerList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFertItem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFertQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFertUnitPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFertDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddInCart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInvoiceClose = new System.Windows.Forms.Button();
            this.btnInvoiceModify = new System.Windows.Forms.Button();
            this.btnInvoicePrint = new System.Windows.Forms.Button();
            this.btnInvoiceSave = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Items.AddRange(new object[] {
            "Select"});
            this.cmbCustomer.Location = new System.Drawing.Point(100, 19);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(164, 21);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address :";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(336, 19);
            this.txtCustAddress.Multiline = true;
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(191, 73);
            this.txtCustAddress.TabIndex = 3;
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(100, 46);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(149, 20);
            this.txtCustCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "City :";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(100, 72);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(149, 20);
            this.txtCustPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone No. :";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Checked = false;
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(418, 19);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(102, 20);
            this.dtpInvoiceDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(100, 19);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(149, 20);
            this.txtInvoiceNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Invoice No. :";
            // 
            // txtFertCompany
            // 
            this.txtFertCompany.Location = new System.Drawing.Point(328, 46);
            this.txtFertCompany.Name = "txtFertCompany";
            this.txtFertCompany.Size = new System.Drawing.Size(199, 20);
            this.txtFertCompany.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Company :";
            // 
            // cmbFertilizerList
            // 
            this.cmbFertilizerList.FormattingEnabled = true;
            this.cmbFertilizerList.Items.AddRange(new object[] {
            "Select"});
            this.cmbFertilizerList.Location = new System.Drawing.Point(92, 46);
            this.cmbFertilizerList.Name = "cmbFertilizerList";
            this.cmbFertilizerList.Size = new System.Drawing.Size(164, 21);
            this.cmbFertilizerList.TabIndex = 13;
            this.cmbFertilizerList.SelectedIndexChanged += new System.EventHandler(this.cmbFertilizerList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fertilizer :";
            // 
            // cmbFertItem
            // 
            this.cmbFertItem.FormattingEnabled = true;
            this.cmbFertItem.Items.AddRange(new object[] {
            "Select"});
            this.cmbFertItem.Location = new System.Drawing.Point(92, 19);
            this.cmbFertItem.Name = "cmbFertItem";
            this.cmbFertItem.Size = new System.Drawing.Size(126, 21);
            this.cmbFertItem.TabIndex = 17;
            this.cmbFertItem.SelectedIndexChanged += new System.EventHandler(this.cmbFertItem_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Item Type :";
            // 
            // txtFertQuantity
            // 
            this.txtFertQuantity.Location = new System.Drawing.Point(92, 72);
            this.txtFertQuantity.Name = "txtFertQuantity";
            this.txtFertQuantity.Size = new System.Drawing.Size(71, 20);
            this.txtFertQuantity.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quntity :";
            // 
            // txtFertUnitPrice
            // 
            this.txtFertUnitPrice.Location = new System.Drawing.Point(240, 72);
            this.txtFertUnitPrice.Name = "txtFertUnitPrice";
            this.txtFertUnitPrice.Size = new System.Drawing.Size(95, 20);
            this.txtFertUnitPrice.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Unit Price :";
            // 
            // txtFertDiscount
            // 
            this.txtFertDiscount.Location = new System.Drawing.Point(411, 72);
            this.txtFertDiscount.Name = "txtFertDiscount";
            this.txtFertDiscount.Size = new System.Drawing.Size(89, 20);
            this.txtFertDiscount.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Discount :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustCity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCustPhone);
            this.groupBox1.Location = new System.Drawing.Point(6, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 104);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnAddInCart);
            this.groupBox2.Controls.Add(this.cmbFertItem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFertDiscount);
            this.groupBox2.Controls.Add(this.cmbFertilizerList);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFertUnitPrice);
            this.groupBox2.Controls.Add(this.txtFertCompany);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFertQuantity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 138);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 103);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddInCart
            // 
            this.btnAddInCart.Location = new System.Drawing.Point(92, 103);
            this.btnAddInCart.Name = "btnAddInCart";
            this.btnAddInCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddInCart.TabIndex = 24;
            this.btnAddInCart.Text = "Add in Cart";
            this.btnAddInCart.UseVisualStyleBackColor = true;
            this.btnAddInCart.Click += new System.EventHandler(this.btnAddInCart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInvoiceClose);
            this.groupBox3.Controls.Add(this.btnInvoiceModify);
            this.groupBox3.Controls.Add(this.btnInvoicePrint);
            this.groupBox3.Controls.Add(this.btnInvoiceSave);
            this.groupBox3.Controls.Add(this.txtTotalAmount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtBalanceAmount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtPaidAmount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtNetAmount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(6, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 307);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice Details";
            // 
            // btnInvoiceClose
            // 
            this.btnInvoiceClose.Location = new System.Drawing.Point(349, 278);
            this.btnInvoiceClose.Name = "btnInvoiceClose";
            this.btnInvoiceClose.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceClose.TabIndex = 35;
            this.btnInvoiceClose.Text = "Close";
            this.btnInvoiceClose.UseVisualStyleBackColor = true;
            // 
            // btnInvoiceModify
            // 
            this.btnInvoiceModify.Location = new System.Drawing.Point(260, 278);
            this.btnInvoiceModify.Name = "btnInvoiceModify";
            this.btnInvoiceModify.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceModify.TabIndex = 34;
            this.btnInvoiceModify.Text = "Modify";
            this.btnInvoiceModify.UseVisualStyleBackColor = true;
            // 
            // btnInvoicePrint
            // 
            this.btnInvoicePrint.Location = new System.Drawing.Point(177, 278);
            this.btnInvoicePrint.Name = "btnInvoicePrint";
            this.btnInvoicePrint.Size = new System.Drawing.Size(75, 23);
            this.btnInvoicePrint.TabIndex = 33;
            this.btnInvoicePrint.Text = "Print";
            this.btnInvoicePrint.UseVisualStyleBackColor = true;
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.Location = new System.Drawing.Point(88, 278);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceSave.TabIndex = 32;
            this.btnInvoiceSave.Text = "Save";
            this.btnInvoiceSave.UseVisualStyleBackColor = true;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(443, 180);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(84, 20);
            this.txtTotalAmount.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(361, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Total Amount :";
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Location = new System.Drawing.Point(443, 232);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.Size = new System.Drawing.Size(84, 20);
            this.txtBalanceAmount.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Balance Amount :";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(443, 206);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(84, 20);
            this.txtPaidAmount.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(364, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Paid Amount :";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(443, 154);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(84, 20);
            this.txtNetAmount.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Net Amount :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvInvoiceDetails);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 129);
            this.panel1.TabIndex = 1;
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(521, 129);
            this.dgvInvoiceDetails.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbPaymentMode);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtUserName);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtInvoiceNo);
            this.groupBox4.Controls.Add(this.dtpInvoiceDate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 100);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Billing Information";
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "Select",
            "Cash",
            "Credit",
            "Cheque"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(100, 73);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(104, 21);
            this.cmbPaymentMode.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Payment Mode :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 45);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(149, 20);
            this.txtUserName.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(59, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "User :";
            // 
            // frmGoInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 680);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGoInvoice";
            this.Text = "Save";
            this.Load += new System.EventHandler(this.frmGoInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFertCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFertilizerList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFertItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFertQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFertUnitPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFertDiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddInCart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInvoiceClose;
        private System.Windows.Forms.Button btnInvoiceModify;
        private System.Windows.Forms.Button btnInvoicePrint;
        private System.Windows.Forms.Button btnInvoiceSave;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label17;
    }
}