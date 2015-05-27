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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pnlTreeView.Size = new System.Drawing.Size(200, 472);
            this.pnlTreeView.TabIndex = 2;
            // 
            // trvUsers
            // 
            this.trvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvUsers.Location = new System.Drawing.Point(0, 0);
            this.trvUsers.Name = "trvUsers";
            this.trvUsers.Size = new System.Drawing.Size(200, 472);
            this.trvUsers.TabIndex = 0;
            this.trvUsers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvUsers_NodeMouseClick);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(319, 14);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(84, 20);
            this.txtUserID.TabIndex = 24;
            this.txtUserID.Text = "0";
            this.txtUserID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 258);
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
            this.pnlContent.Size = new System.Drawing.Size(459, 472);
            this.pnlContent.TabIndex = 2;
            // 
            // grpBoxCustomer
            // 
            this.grpBoxCustomer.Controls.Add(this.txtPhoneNo);
            this.grpBoxCustomer.Controls.Add(this.label7);
            this.grpBoxCustomer.Controls.Add(this.txtAddress);
            this.grpBoxCustomer.Controls.Add(this.label6);
            this.grpBoxCustomer.Controls.Add(this.txtDOB);
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
            this.grpBoxCustomer.Location = new System.Drawing.Point(0, 0);
            this.grpBoxCustomer.Name = "grpBoxCustomer";
            this.grpBoxCustomer.Size = new System.Drawing.Size(459, 472);
            this.grpBoxCustomer.TabIndex = 0;
            this.grpBoxCustomer.TabStop = false;
            this.grpBoxCustomer.Text = "groupBox1";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlTreeView);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(659, 472);
            this.pnlMain.TabIndex = 2;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(117, 138);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(155, 20);
            this.txtPhoneNo.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Phone No. :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(117, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 20);
            this.txtAddress.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Address :";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(117, 225);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(155, 20);
            this.txtDOB.TabIndex = 52;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(117, 196);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 20);
            this.txtCity.TabIndex = 51;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 20);
            this.txtEmail.TabIndex = 50;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(117, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 20);
            this.txtLastName.TabIndex = 49;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(117, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 20);
            this.txtFirstName.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "BirthDate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "City :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "First Name :";
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 472);
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
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDOB;
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