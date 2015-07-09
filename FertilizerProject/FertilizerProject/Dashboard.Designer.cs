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
            this.TSMI_FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_EditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_EditFertilizer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_EditCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ViewFertilizer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Go = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_GoInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tools_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ToolSetting_ServerSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_VoucherPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_VoucherReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_Edit,
            this.TSMI_View,
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
            this.TSMI_FileExit});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(37, 20);
            this.TSMI_File.Text = "&File";
            // 
            // TSMI_FileExit
            // 
            this.TSMI_FileExit.Name = "TSMI_FileExit";
            this.TSMI_FileExit.Size = new System.Drawing.Size(92, 22);
            this.TSMI_FileExit.Text = "E&xit";
            // 
            // TSMI_Edit
            // 
            this.TSMI_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_EditUser,
            this.TSMI_EditFertilizer,
            this.TSMI_EditCustomer});
            this.TSMI_Edit.Name = "TSMI_Edit";
            this.TSMI_Edit.Size = new System.Drawing.Size(39, 20);
            this.TSMI_Edit.Text = "&Edit";
            // 
            // TSMI_EditUser
            // 
            this.TSMI_EditUser.Name = "TSMI_EditUser";
            this.TSMI_EditUser.Size = new System.Drawing.Size(146, 22);
            this.TSMI_EditUser.Text = "Edit&User";
            this.TSMI_EditUser.Click += new System.EventHandler(this.TSMI_EditUser_Click);
            // 
            // TSMI_EditFertilizer
            // 
            this.TSMI_EditFertilizer.Name = "TSMI_EditFertilizer";
            this.TSMI_EditFertilizer.Size = new System.Drawing.Size(146, 22);
            this.TSMI_EditFertilizer.Text = "Edit&Fertilizer";
            this.TSMI_EditFertilizer.Click += new System.EventHandler(this.TSMI_EditFertilizer_Click);
            // 
            // TSMI_EditCustomer
            // 
            this.TSMI_EditCustomer.Name = "TSMI_EditCustomer";
            this.TSMI_EditCustomer.Size = new System.Drawing.Size(146, 22);
            this.TSMI_EditCustomer.Text = "Edit&Customer";
            this.TSMI_EditCustomer.Click += new System.EventHandler(this.TSMI_EditCustomer_Click);
            // 
            // TSMI_View
            // 
            this.TSMI_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ViewUser,
            this.TSMI_ViewFertilizer,
            this.TSMI_ViewCustomer,
            this.TSMI_VoucherPayment,
            this.TSMI_VoucherReceipt});
            this.TSMI_View.Name = "TSMI_View";
            this.TSMI_View.Size = new System.Drawing.Size(44, 20);
            this.TSMI_View.Text = "&View";
            // 
            // TSMI_ViewUser
            // 
            this.TSMI_ViewUser.Name = "TSMI_ViewUser";
            this.TSMI_ViewUser.Size = new System.Drawing.Size(165, 22);
            this.TSMI_ViewUser.Text = "View&User";
            this.TSMI_ViewUser.Click += new System.EventHandler(this.TSMI_ViewUser_Click);
            // 
            // TSMI_ViewFertilizer
            // 
            this.TSMI_ViewFertilizer.Name = "TSMI_ViewFertilizer";
            this.TSMI_ViewFertilizer.Size = new System.Drawing.Size(165, 22);
            this.TSMI_ViewFertilizer.Text = "View&Fertilizer";
            this.TSMI_ViewFertilizer.Click += new System.EventHandler(this.TSMI_ViewFertilizer_Click);
            // 
            // TSMI_ViewCustomer
            // 
            this.TSMI_ViewCustomer.Name = "TSMI_ViewCustomer";
            this.TSMI_ViewCustomer.Size = new System.Drawing.Size(165, 22);
            this.TSMI_ViewCustomer.Text = "View&Customer";
            this.TSMI_ViewCustomer.Click += new System.EventHandler(this.TSMI_ViewCustomer_Click);
            // 
            // TSMI_Go
            // 
            this.TSMI_Go.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_GoInvoice});
            this.TSMI_Go.Name = "TSMI_Go";
            this.TSMI_Go.Size = new System.Drawing.Size(34, 20);
            this.TSMI_Go.Text = "&Go";
            // 
            // TSMI_GoInvoice
            // 
            this.TSMI_GoInvoice.Name = "TSMI_GoInvoice";
            this.TSMI_GoInvoice.Size = new System.Drawing.Size(112, 22);
            this.TSMI_GoInvoice.Text = "&Invoice";
            this.TSMI_GoInvoice.Click += new System.EventHandler(this.TSMI_GoInvoice_Click);
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
            // TSMI_VoucherPayment
            // 
            this.TSMI_VoucherPayment.Name = "TSMI_VoucherPayment";
            this.TSMI_VoucherPayment.Size = new System.Drawing.Size(165, 22);
            this.TSMI_VoucherPayment.Text = "Voucher&Payment";
            this.TSMI_VoucherPayment.Click += new System.EventHandler(this.TSMI_VoucherPayment_Click);
            // 
            // TSMI_VoucherReceipt
            // 
            this.TSMI_VoucherReceipt.Name = "TSMI_VoucherReceipt";
            this.TSMI_VoucherReceipt.Size = new System.Drawing.Size(165, 22);
            this.TSMI_VoucherReceipt.Text = "Voucher&Reciept";
            this.TSMI_VoucherReceipt.Click += new System.EventHandler(this.TSMI_VoucherReceipt_Click);
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
        private System.Windows.Forms.ToolStripMenuItem TSMI_Edit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_EditUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ViewUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Go;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tools_Settings;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_EditFertilizer;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ViewFertilizer;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem TSMI_EditCustomer;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ToolSetting_ServerSetting;
        private System.Windows.Forms.ToolStripMenuItem TSMI_GoInvoice;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VoucherPayment;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VoucherReceipt;
    }
}