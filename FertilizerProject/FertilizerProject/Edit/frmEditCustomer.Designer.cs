namespace FertilizerProject.Edit
{
    partial class frmEditCustomer
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
            this.pnlTreeView = new System.Windows.Forms.Panel();
            this.trvUsers = new System.Windows.Forms.TreeView();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpBoxCustomer = new System.Windows.Forms.GroupBox();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtClosing = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOpening = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.cmb6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTreeView.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpBoxCustomer.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTreeView
            // 
            this.pnlTreeView.Controls.Add(this.trvUsers);
            this.pnlTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTreeView.Location = new System.Drawing.Point(0, 0);
            this.pnlTreeView.Name = "pnlTreeView";
            this.pnlTreeView.Size = new System.Drawing.Size(200, 593);
            this.pnlTreeView.TabIndex = 2;
            // 
            // trvUsers
            // 
            this.trvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvUsers.Location = new System.Drawing.Point(0, 0);
            this.trvUsers.Name = "trvUsers";
            this.trvUsers.Size = new System.Drawing.Size(200, 593);
            this.trvUsers.TabIndex = 0;
            this.trvUsers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvUsers_NodeMouseClick);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(319, 14);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(84, 26);
            this.txtUserID.TabIndex = 24;
            this.txtUserID.Text = "0";
            this.txtUserID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(181, 548);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpBoxCustomer);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(685, 593);
            this.pnlContent.TabIndex = 2;
            // 
            // grpBoxCustomer
            // 
            this.grpBoxCustomer.Controls.Add(this.cmb4);
            this.grpBoxCustomer.Controls.Add(this.label20);
            this.grpBoxCustomer.Controls.Add(this.txtInterest);
            this.grpBoxCustomer.Controls.Add(this.label19);
            this.grpBoxCustomer.Controls.Add(this.txtCredit);
            this.grpBoxCustomer.Controls.Add(this.label18);
            this.grpBoxCustomer.Controls.Add(this.txtClosing);
            this.grpBoxCustomer.Controls.Add(this.label17);
            this.grpBoxCustomer.Controls.Add(this.txtOpening);
            this.grpBoxCustomer.Controls.Add(this.label16);
            this.grpBoxCustomer.Controls.Add(this.dob);
            this.grpBoxCustomer.Controls.Add(this.cmb6);
            this.grpBoxCustomer.Controls.Add(this.label14);
            this.grpBoxCustomer.Controls.Add(this.cmb5);
            this.grpBoxCustomer.Controls.Add(this.label15);
            this.grpBoxCustomer.Controls.Add(this.cmb3);
            this.grpBoxCustomer.Controls.Add(this.label13);
            this.grpBoxCustomer.Controls.Add(this.cmb2);
            this.grpBoxCustomer.Controls.Add(this.cmb1);
            this.grpBoxCustomer.Controls.Add(this.label12);
            this.grpBoxCustomer.Controls.Add(this.label11);
            this.grpBoxCustomer.Controls.Add(this.txtPhoneNo);
            this.grpBoxCustomer.Controls.Add(this.label7);
            this.grpBoxCustomer.Controls.Add(this.txtAddress);
            this.grpBoxCustomer.Controls.Add(this.label6);
            this.grpBoxCustomer.Controls.Add(this.txtCity);
            this.grpBoxCustomer.Controls.Add(this.txtEmail);
            this.grpBoxCustomer.Controls.Add(this.txtLastName);
            this.grpBoxCustomer.Controls.Add(this.txtFirstName);
            this.grpBoxCustomer.Controls.Add(this.label5);
            this.grpBoxCustomer.Controls.Add(this.label4);
            this.grpBoxCustomer.Controls.Add(this.label3);
            this.grpBoxCustomer.Controls.Add(this.label2);
            this.grpBoxCustomer.Controls.Add(this.label1);
            this.grpBoxCustomer.Controls.Add(this.txtUserID);
            this.grpBoxCustomer.Controls.Add(this.btnCancel);
            this.grpBoxCustomer.Controls.Add(this.btnUpdate);
            this.grpBoxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxCustomer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCustomer.Location = new System.Drawing.Point(0, 0);
            this.grpBoxCustomer.Name = "grpBoxCustomer";
            this.grpBoxCustomer.Size = new System.Drawing.Size(685, 593);
            this.grpBoxCustomer.TabIndex = 0;
            this.grpBoxCustomer.TabStop = false;
            this.grpBoxCustomer.Text = "groupBox1";
            // 
            // cmb4
            // 
            this.cmb4.FormattingEnabled = true;
            this.cmb4.Location = new System.Drawing.Point(401, 183);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(134, 26);
            this.cmb4.TabIndex = 114;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(333, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 18);
            this.label20.TabIndex = 113;
            this.label20.Text = "Pincode:";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(183, 481);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(205, 26);
            this.txtInterest.TabIndex = 112;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 484);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 18);
            this.label19.TabIndex = 111;
            this.label19.Text = "Interest Rate per Month %:";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(183, 453);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(205, 26);
            this.txtCredit.TabIndex = 110;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(83, 455);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 18);
            this.label18.TabIndex = 109;
            this.label18.Text = "Credit Balance:";
            // 
            // txtClosing
            // 
            this.txtClosing.Location = new System.Drawing.Point(184, 420);
            this.txtClosing.Margin = new System.Windows.Forms.Padding(4);
            this.txtClosing.Name = "txtClosing";
            this.txtClosing.Size = new System.Drawing.Size(205, 26);
            this.txtClosing.TabIndex = 107;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(77, 422);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 18);
            this.label17.TabIndex = 106;
            this.label17.Text = "Closing Balance:";
            // 
            // txtOpening
            // 
            this.txtOpening.Location = new System.Drawing.Point(184, 384);
            this.txtOpening.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpening.Name = "txtOpening";
            this.txtOpening.Size = new System.Drawing.Size(205, 26);
            this.txtOpening.TabIndex = 104;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(70, 389);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 18);
            this.label16.TabIndex = 103;
            this.label16.Text = "Opening Balance:";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(185, 351);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(205, 26);
            this.dob.TabIndex = 102;
            // 
            // cmb6
            // 
            this.cmb6.FormattingEnabled = true;
            this.cmb6.Location = new System.Drawing.Point(404, 216);
            this.cmb6.Name = "cmb6";
            this.cmb6.Size = new System.Drawing.Size(134, 26);
            this.cmb6.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(325, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 18);
            this.label14.TabIndex = 100;
            this.label14.Text = "Categories:";
            // 
            // cmb5
            // 
            this.cmb5.FormattingEnabled = true;
            this.cmb5.Location = new System.Drawing.Point(184, 216);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(134, 26);
            this.cmb5.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(127, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 18);
            this.label15.TabIndex = 98;
            this.label15.Text = "Group:";
            // 
            // cmb3
            // 
            this.cmb3.FormattingEnabled = true;
            this.cmb3.Location = new System.Drawing.Point(181, 183);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(134, 26);
            this.cmb3.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(133, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 96;
            this.label13.Text = "State:";
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(401, 155);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(134, 26);
            this.cmb2.TabIndex = 95;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(181, 152);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(134, 26);
            this.cmb1.TabIndex = 94;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(339, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 93;
            this.label12.Text = "District:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 18);
            this.label11.TabIndex = 92;
            this.label11.Text = "Taluka:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(184, 249);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(205, 26);
            this.txtPhoneNo.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 90;
            this.label7.Text = "Phone No. :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(182, 94);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(321, 50);
            this.txtAddress.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 88;
            this.label6.Text = "Address :";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(185, 318);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(205, 26);
            this.txtCity.TabIndex = 87;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(190, 286);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 26);
            this.txtEmail.TabIndex = 86;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(485, 60);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 26);
            this.txtLastName.TabIndex = 85;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(182, 58);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(205, 26);
            this.txtFirstName.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "BirthDate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "City :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 81;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Customer First Name:";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlTreeView);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(885, 593);
            this.pnlMain.TabIndex = 2;
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 593);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmEditCustomer";
            this.Text = "frmEditCustomer";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            this.pnlTreeView.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.grpBoxCustomer.ResumeLayout(false);
            this.grpBoxCustomer.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTreeView;
        private System.Windows.Forms.TreeView trvUsers;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpBoxCustomer;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cmb4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtClosing;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOpening;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.ComboBox cmb6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}