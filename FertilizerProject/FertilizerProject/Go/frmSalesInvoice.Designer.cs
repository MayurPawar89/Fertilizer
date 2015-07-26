namespace FertilizerProject
{
    partial class frmSalesInvoice
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFertDiscountAmount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtFertAmount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFertAvailableQuntity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddInCart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInvoiceClose = new System.Windows.Forms.Button();
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbCheque = new System.Windows.Forms.RadioButton();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.rdbCredit = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Items.AddRange(new object[] {
            "Select"});
            this.cmbCustomer.Location = new System.Drawing.Point(100, 15);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(220, 21);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address :";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(388, 18);
            this.txtCustAddress.Multiline = true;
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(195, 79);
            this.txtCustAddress.TabIndex = 3;
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(100, 42);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(149, 20);
            this.txtCustCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "City :";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(100, 68);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(149, 20);
            this.txtCustPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone No. :";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Checked = false;
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(741, 19);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(144, 20);
            this.dtpInvoiceDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
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
            this.txtFertCompany.Location = new System.Drawing.Point(349, 46);
            this.txtFertCompany.Name = "txtFertCompany";
            this.txtFertCompany.ReadOnly = true;
            this.txtFertCompany.Size = new System.Drawing.Size(292, 20);
            this.txtFertCompany.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 49);
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
            this.cmbFertilizerList.Location = new System.Drawing.Point(105, 46);
            this.cmbFertilizerList.Name = "cmbFertilizerList";
            this.cmbFertilizerList.Size = new System.Drawing.Size(164, 21);
            this.cmbFertilizerList.TabIndex = 13;
            this.cmbFertilizerList.SelectedIndexChanged += new System.EventHandler(this.cmbFertilizerList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 49);
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
            this.cmbFertItem.Location = new System.Drawing.Point(105, 19);
            this.cmbFertItem.Name = "cmbFertItem";
            this.cmbFertItem.Size = new System.Drawing.Size(126, 21);
            this.cmbFertItem.TabIndex = 17;
            this.cmbFertItem.SelectedIndexChanged += new System.EventHandler(this.cmbFertItem_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Item Type :";
            // 
            // txtFertQuantity
            // 
            this.txtFertQuantity.Location = new System.Drawing.Point(104, 101);
            this.txtFertQuantity.Name = "txtFertQuantity";
            this.txtFertQuantity.Size = new System.Drawing.Size(71, 20);
            this.txtFertQuantity.TabIndex = 19;
            this.txtFertQuantity.TextChanged += new System.EventHandler(this.txtFertQuantity_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quntity :";
            // 
            // txtFertUnitPrice
            // 
            this.txtFertUnitPrice.Location = new System.Drawing.Point(354, 72);
            this.txtFertUnitPrice.Name = "txtFertUnitPrice";
            this.txtFertUnitPrice.ReadOnly = true;
            this.txtFertUnitPrice.Size = new System.Drawing.Size(95, 20);
            this.txtFertUnitPrice.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Unit Price :";
            // 
            // txtFertDiscount
            // 
            this.txtFertDiscount.Location = new System.Drawing.Point(644, 72);
            this.txtFertDiscount.Name = "txtFertDiscount";
            this.txtFertDiscount.ReadOnly = true;
            this.txtFertDiscount.Size = new System.Drawing.Size(89, 20);
            this.txtFertDiscount.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(585, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Discount :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCapture);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.picPhoto);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustCity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCustPhone);
            this.groupBox1.Location = new System.Drawing.Point(6, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 129);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(792, 47);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(792, 18);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 64;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(600, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Photo :";
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(647, 20);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(130, 105);
            this.picPhoto.TabIndex = 47;
            this.picPhoto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFertDiscountAmount);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtFertAmount);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtFertAvailableQuntity);
            this.groupBox2.Controls.Add(this.label19);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 157);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            // 
            // txtFertDiscountAmount
            // 
            this.txtFertDiscountAmount.Location = new System.Drawing.Point(644, 103);
            this.txtFertDiscountAmount.Name = "txtFertDiscountAmount";
            this.txtFertDiscountAmount.ReadOnly = true;
            this.txtFertDiscountAmount.Size = new System.Drawing.Size(89, 20);
            this.txtFertDiscountAmount.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(546, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Discount Amount :";
            // 
            // txtFertAmount
            // 
            this.txtFertAmount.Location = new System.Drawing.Point(353, 102);
            this.txtFertAmount.Name = "txtFertAmount";
            this.txtFertAmount.ReadOnly = true;
            this.txtFertAmount.Size = new System.Drawing.Size(89, 20);
            this.txtFertAmount.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(294, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Amount :";
            // 
            // txtFertAvailableQuntity
            // 
            this.txtFertAvailableQuntity.Location = new System.Drawing.Point(105, 72);
            this.txtFertAvailableQuntity.Name = "txtFertAvailableQuntity";
            this.txtFertAvailableQuntity.ReadOnly = true;
            this.txtFertAvailableQuntity.Size = new System.Drawing.Size(71, 20);
            this.txtFertAvailableQuntity.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Available Quntity :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddInCart
            // 
            this.btnAddInCart.Location = new System.Drawing.Point(105, 129);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(917, 289);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice Details";
            // 
            // btnInvoiceClose
            // 
            this.btnInvoiceClose.Location = new System.Drawing.Point(535, 261);
            this.btnInvoiceClose.Name = "btnInvoiceClose";
            this.btnInvoiceClose.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceClose.TabIndex = 35;
            this.btnInvoiceClose.Text = "Close";
            this.btnInvoiceClose.UseVisualStyleBackColor = true;
            this.btnInvoiceClose.Click += new System.EventHandler(this.btnInvoiceClose_Click);
            // 
            // btnInvoicePrint
            // 
            this.btnInvoicePrint.Location = new System.Drawing.Point(440, 261);
            this.btnInvoicePrint.Name = "btnInvoicePrint";
            this.btnInvoicePrint.Size = new System.Drawing.Size(75, 23);
            this.btnInvoicePrint.TabIndex = 33;
            this.btnInvoicePrint.Text = "Print";
            this.btnInvoicePrint.UseVisualStyleBackColor = true;
            this.btnInvoicePrint.Click += new System.EventHandler(this.btnInvoicePrint_Click);
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.Location = new System.Drawing.Point(351, 261);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceSave.TabIndex = 32;
            this.btnInvoiceSave.Text = "Save";
            this.btnInvoiceSave.UseVisualStyleBackColor = true;
            this.btnInvoiceSave.Click += new System.EventHandler(this.btnInvoiceSave_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(783, 180);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(113, 20);
            this.txtTotalAmount.TabIndex = 31;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(701, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Total Amount :";
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Location = new System.Drawing.Point(783, 232);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.Size = new System.Drawing.Size(113, 20);
            this.txtBalanceAmount.TabIndex = 29;
            this.txtBalanceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(686, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Balance Amount :";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(783, 206);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(113, 20);
            this.txtPaidAmount.TabIndex = 27;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(704, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Paid Amount :";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Enabled = false;
            this.txtNetAmount.Location = new System.Drawing.Point(783, 154);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(113, 20);
            this.txtNetAmount.TabIndex = 25;
            this.txtNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(708, 157);
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
            this.panel1.Size = new System.Drawing.Size(890, 129);
            this.panel1.TabIndex = 1;
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(890, 129);
            this.dgvInvoiceDetails.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblUserName);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lblInvoiceNo);
            this.groupBox4.Controls.Add(this.dtpInvoiceDate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(917, 74);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Billing Information";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(102, 49);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 33;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbCheque);
            this.groupBox5.Controls.Add(this.rdbCash);
            this.groupBox5.Controls.Add(this.rdbCredit);
            this.groupBox5.Location = new System.Drawing.Point(375, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 43);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment Mode";
            // 
            // rdbCheque
            // 
            this.rdbCheque.AutoSize = true;
            this.rdbCheque.Location = new System.Drawing.Point(130, 19);
            this.rdbCheque.Name = "rdbCheque";
            this.rdbCheque.Size = new System.Drawing.Size(62, 17);
            this.rdbCheque.TabIndex = 2;
            this.rdbCheque.TabStop = true;
            this.rdbCheque.Text = "Cheque";
            this.rdbCheque.UseVisualStyleBackColor = true;
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Location = new System.Drawing.Point(70, 19);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(49, 17);
            this.rdbCash.TabIndex = 1;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "Cash";
            this.rdbCash.UseVisualStyleBackColor = true;
            // 
            // rdbCredit
            // 
            this.rdbCredit.AutoSize = true;
            this.rdbCredit.Checked = true;
            this.rdbCredit.Location = new System.Drawing.Point(7, 19);
            this.rdbCredit.Name = "rdbCredit";
            this.rdbCredit.Size = new System.Drawing.Size(52, 17);
            this.rdbCredit.TabIndex = 0;
            this.rdbCredit.TabStop = true;
            this.rdbCredit.Text = "Credit";
            this.rdbCredit.UseVisualStyleBackColor = true;
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
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(127, 23);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(0, 13);
            this.lblInvoiceNo.TabIndex = 32;
            // 
            // frmGoInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 661);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGoInvoice";
            this.Text = "Sales Invoice";
            this.Load += new System.EventHandler(this.frmSalesInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFertAvailableQuntity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFertAmount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFertDiscountAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdbCheque;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.RadioButton rdbCredit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblInvoiceNo;
    }
}