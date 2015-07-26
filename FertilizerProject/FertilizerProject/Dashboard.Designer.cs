namespace FertilizerProject
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FileNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FileNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FileNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FileViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FileViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FileViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Go = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_GoInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_VoucherReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_VoucherPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tools_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ToolSetting_ServerSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_Go,
            this.TSMI_Tools_Settings,
            this.TSMI_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.TSMI_FileExit});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(37, 20);
            this.TSMI_File.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_FileNewUser,
            this.TSMI_FileNewItem,
            this.TSMI_FileNewCustomer});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // TSMI_FileNewUser
            // 
            this.TSMI_FileNewUser.Name = "TSMI_FileNewUser";
            this.TSMI_FileNewUser.Size = new System.Drawing.Size(126, 22);
            this.TSMI_FileNewUser.Text = "&User";
            this.TSMI_FileNewUser.Click += new System.EventHandler(this.TSMI_FileNewUser_Click);
            // 
            // TSMI_FileNewItem
            // 
            this.TSMI_FileNewItem.Name = "TSMI_FileNewItem";
            this.TSMI_FileNewItem.Size = new System.Drawing.Size(126, 22);
            this.TSMI_FileNewItem.Text = "&Item";
            this.TSMI_FileNewItem.Click += new System.EventHandler(this.TSMI_FileNewItem_Click);
            // 
            // TSMI_FileNewCustomer
            // 
            this.TSMI_FileNewCustomer.Name = "TSMI_FileNewCustomer";
            this.TSMI_FileNewCustomer.Size = new System.Drawing.Size(126, 22);
            this.TSMI_FileNewCustomer.Text = "&Customer";
            this.TSMI_FileNewCustomer.Click += new System.EventHandler(this.TSMI_FileNewCustomer_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_FileViewUser,
            this.TSMI_FileViewItem,
            this.TSMI_FileViewCustomer});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "&Modify";
            // 
            // TSMI_FileViewUser
            // 
            this.TSMI_FileViewUser.Name = "TSMI_FileViewUser";
            this.TSMI_FileViewUser.Size = new System.Drawing.Size(152, 22);
            this.TSMI_FileViewUser.Text = "&User";
            this.TSMI_FileViewUser.Click += new System.EventHandler(this.TSMI_FileViewUser_Click);
            // 
            // TSMI_FileViewItem
            // 
            this.TSMI_FileViewItem.Name = "TSMI_FileViewItem";
            this.TSMI_FileViewItem.Size = new System.Drawing.Size(152, 22);
            this.TSMI_FileViewItem.Text = "&Fertilizer";
            this.TSMI_FileViewItem.Click += new System.EventHandler(this.TSMI_FileViewItem_Click);
            // 
            // TSMI_FileViewCustomer
            // 
            this.TSMI_FileViewCustomer.Name = "TSMI_FileViewCustomer";
            this.TSMI_FileViewCustomer.Size = new System.Drawing.Size(152, 22);
            this.TSMI_FileViewCustomer.Text = "&Customer";
            this.TSMI_FileViewCustomer.Click += new System.EventHandler(this.TSMI_FileViewCustomer_Click);
            // 
            // TSMI_FileExit
            // 
            this.TSMI_FileExit.Name = "TSMI_FileExit";
            this.TSMI_FileExit.Size = new System.Drawing.Size(152, 22);
            this.TSMI_FileExit.Text = "E&xit";
            // 
            // TSMI_Go
            // 
            this.TSMI_Go.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_GoInvoice,
            this.TSMI_VoucherReceipt,
            this.TSMI_VoucherPayment});
            this.TSMI_Go.Name = "TSMI_Go";
            this.TSMI_Go.Size = new System.Drawing.Size(34, 20);
            this.TSMI_Go.Text = "&Go";
            // 
            // TSMI_GoInvoice
            // 
            this.TSMI_GoInvoice.Name = "TSMI_GoInvoice";
            this.TSMI_GoInvoice.Size = new System.Drawing.Size(168, 22);
            this.TSMI_GoInvoice.Text = "&Invoice";
            this.TSMI_GoInvoice.Click += new System.EventHandler(this.TSMI_GoInvoice_Click);
            // 
            // TSMI_VoucherReceipt
            // 
            this.TSMI_VoucherReceipt.Name = "TSMI_VoucherReceipt";
            this.TSMI_VoucherReceipt.Size = new System.Drawing.Size(168, 22);
            this.TSMI_VoucherReceipt.Text = "Voucher &Reciept";
            this.TSMI_VoucherReceipt.Click += new System.EventHandler(this.TSMI_VoucherReceipt_Click_1);
            // 
            // TSMI_VoucherPayment
            // 
            this.TSMI_VoucherPayment.Name = "TSMI_VoucherPayment";
            this.TSMI_VoucherPayment.Size = new System.Drawing.Size(168, 22);
            this.TSMI_VoucherPayment.Text = "Voucher &Payment";
            this.TSMI_VoucherPayment.Click += new System.EventHandler(this.TSMI_VoucherPayment_Click_1);
            // 
            // TSMI_Tools_Settings
            // 
            this.TSMI_Tools_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ToolSetting_ServerSetting});
            this.TSMI_Tools_Settings.Name = "TSMI_Tools_Settings";
            this.TSMI_Tools_Settings.Size = new System.Drawing.Size(106, 20);
            this.TSMI_Tools_Settings.Text = "&Tools && Settings";
            // 
            // TSMI_ToolSetting_ServerSetting
            // 
            this.TSMI_ToolSetting_ServerSetting.Name = "TSMI_ToolSetting_ServerSetting";
            this.TSMI_ToolSetting_ServerSetting.Size = new System.Drawing.Size(146, 22);
            this.TSMI_ToolSetting_ServerSetting.Text = "&Server Setting";
            this.TSMI_ToolSetting_ServerSetting.Click += new System.EventHandler(this.TSMI_ToolSetting_ServerSetting_Click);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(37, 20);
            this.TSMI_Exit.Text = "E&xit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FertilizerProject.Properties.Resources.agri11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1159, 514);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FileExit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Go;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tools_Settings;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ToolSetting_ServerSetting;
        private System.Windows.Forms.ToolStripMenuItem TSMI_GoInvoice;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FileNewUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FileNewItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FileNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FileViewUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FileViewItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FileViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VoucherReceipt;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VoucherPayment;
    }
}