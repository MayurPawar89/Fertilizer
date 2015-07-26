namespace FertilizerProject.Edit
{
    partial class frmEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUser));
            this.trvUsers = new System.Windows.Forms.TreeView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpBoxUsers = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTreeView = new System.Windows.Forms.Panel();
            this.pnlTopManuStrip = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlMain.SuspendLayout();
            this.pnlOther.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpBoxUsers.SuspendLayout();
            this.pnlTreeView.SuspendLayout();
            this.pnlTopManuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvUsers
            // 
            this.trvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvUsers.Location = new System.Drawing.Point(0, 0);
            this.trvUsers.Name = "trvUsers";
            this.trvUsers.Size = new System.Drawing.Size(200, 384);
            this.trvUsers.TabIndex = 0;
            this.trvUsers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvUsers_NodeMouseClick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlOther);
            this.pnlMain.Controls.Add(this.pnlTopManuStrip);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(730, 440);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlOther
            // 
            this.pnlOther.Controls.Add(this.pnlContent);
            this.pnlOther.Controls.Add(this.pnlTreeView);
            this.pnlOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOther.Location = new System.Drawing.Point(0, 56);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(730, 384);
            this.pnlOther.TabIndex = 27;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpBoxUsers);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(530, 384);
            this.pnlContent.TabIndex = 2;
            // 
            // grpBoxUsers
            // 
            this.grpBoxUsers.Controls.Add(this.label5);
            this.grpBoxUsers.Controls.Add(this.txtPassword);
            this.grpBoxUsers.Controls.Add(this.txtUserID);
            this.grpBoxUsers.Controls.Add(this.btnCancel);
            this.grpBoxUsers.Controls.Add(this.btnUpdate);
            this.grpBoxUsers.Controls.Add(this.txtUserName);
            this.grpBoxUsers.Controls.Add(this.txtEmail);
            this.grpBoxUsers.Controls.Add(this.txtLastName);
            this.grpBoxUsers.Controls.Add(this.txtFirstName);
            this.grpBoxUsers.Controls.Add(this.label4);
            this.grpBoxUsers.Controls.Add(this.label3);
            this.grpBoxUsers.Controls.Add(this.label2);
            this.grpBoxUsers.Controls.Add(this.label1);
            this.grpBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxUsers.Location = new System.Drawing.Point(0, 0);
            this.grpBoxUsers.Name = "grpBoxUsers";
            this.grpBoxUsers.Size = new System.Drawing.Size(530, 384);
            this.grpBoxUsers.TabIndex = 0;
            this.grpBoxUsers.TabStop = false;
            this.grpBoxUsers.Text = "User Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(154, 20);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.UseSystemPasswordChar = true;
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
            this.btnCancel.Location = new System.Drawing.Point(200, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(119, 137);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(155, 20);
            this.txtUserName.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(119, 69);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 20);
            this.txtLastName.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(119, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 20);
            this.txtFirstName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name :";
            // 
            // pnlTreeView
            // 
            this.pnlTreeView.Controls.Add(this.trvUsers);
            this.pnlTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTreeView.Location = new System.Drawing.Point(0, 0);
            this.pnlTreeView.Name = "pnlTreeView";
            this.pnlTreeView.Size = new System.Drawing.Size(200, 384);
            this.pnlTreeView.TabIndex = 2;
            // 
            // pnlTopManuStrip
            // 
            this.pnlTopManuStrip.Controls.Add(this.toolStrip1);
            this.pnlTopManuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopManuStrip.Location = new System.Drawing.Point(0, 0);
            this.pnlTopManuStrip.Name = "pnlTopManuStrip";
            this.pnlTopManuStrip.Size = new System.Drawing.Size(730, 56);
            this.pnlTopManuStrip.TabIndex = 27;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbModify,
            this.tsbDelete,
            this.tsbClose,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 56);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.AutoSize = false;
            this.tsbNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(63, 56);
            this.tsbNew.Text = "New";
            this.tsbNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNew.ToolTipText = "New User";
            // 
            // tsbModify
            // 
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Margin = new System.Windows.Forms.Padding(0);
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(49, 56);
            this.tsbModify.Text = "Modify";
            this.tsbModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModify.ToolTipText = "Modify User";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Margin = new System.Windows.Forms.Padding(0);
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(48, 56);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDelete.ToolTipText = "Delete User";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::FertilizerProject.Properties.Resources.Remove;
            this.tsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(48, 53);
            this.tsbClose.Text = "Close";
            this.tsbClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClose.ToolTipText = "Close User";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 53);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmEditUser";
            this.ShowInTaskbar = false;
            this.Text = "Modify User";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlOther.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.grpBoxUsers.ResumeLayout(false);
            this.grpBoxUsers.PerformLayout();
            this.pnlTreeView.ResumeLayout(false);
            this.pnlTopManuStrip.ResumeLayout(false);
            this.pnlTopManuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvUsers;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTreeView;
        private System.Windows.Forms.GroupBox grpBoxUsers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlTopManuStrip;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbModify;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label5;

    }
}