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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
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
            this.cmbCustomer.Location = new System.Drawing.Point(100, 35);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(199, 21);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address :";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(100, 70);
            this.txtCustAddress.Multiline = true;
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(199, 73);
            this.txtCustAddress.TabIndex = 3;
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(384, 70);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(149, 20);
            this.txtCustCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "City :";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(384, 96);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(149, 20);
            this.txtCustPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone No. :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(384, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
            // 
            // frmGoInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmGoInvoice";
            this.Text = "frmGoInvoice";
            this.Load += new System.EventHandler(this.frmGoInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}