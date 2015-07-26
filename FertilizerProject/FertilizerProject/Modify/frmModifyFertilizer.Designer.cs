namespace FertilizerProject.Edit
{
    partial class frmEditFertilizer
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
            this.trvFertilizer = new System.Windows.Forms.TreeView();
            this.txtFertilizerID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtFertilizerPrice = new System.Windows.Forms.TextBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpBoxFertilizer = new System.Windows.Forms.GroupBox();
            this.cmbFertilizerItem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFertilizerUsage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFertilizerDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFertilizerQuantity = new System.Windows.Forms.TextBox();
            this.txtFertilizerCompanyName = new System.Windows.Forms.TextBox();
            this.txtFertilizerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTreeView.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpBoxFertilizer.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTreeView
            // 
            this.pnlTreeView.Controls.Add(this.trvFertilizer);
            this.pnlTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTreeView.Location = new System.Drawing.Point(0, 0);
            this.pnlTreeView.Name = "pnlTreeView";
            this.pnlTreeView.Size = new System.Drawing.Size(200, 448);
            this.pnlTreeView.TabIndex = 2;
            // 
            // trvFertilizer
            // 
            this.trvFertilizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvFertilizer.Location = new System.Drawing.Point(0, 0);
            this.trvFertilizer.Name = "trvFertilizer";
            this.trvFertilizer.Size = new System.Drawing.Size(200, 448);
            this.trvFertilizer.TabIndex = 0;
            this.trvFertilizer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvFertilizer_NodeMouseClick);
            // 
            // txtFertilizerID
            // 
            this.txtFertilizerID.Location = new System.Drawing.Point(319, 14);
            this.txtFertilizerID.Name = "txtFertilizerID";
            this.txtFertilizerID.Size = new System.Drawing.Size(84, 20);
            this.txtFertilizerID.TabIndex = 24;
            this.txtFertilizerID.Text = "0";
            this.txtFertilizerID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(142, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFertilizerPrice
            // 
            this.txtFertilizerPrice.Location = new System.Drawing.Point(142, 154);
            this.txtFertilizerPrice.Name = "txtFertilizerPrice";
            this.txtFertilizerPrice.Size = new System.Drawing.Size(85, 20);
            this.txtFertilizerPrice.TabIndex = 20;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpBoxFertilizer);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(437, 448);
            this.pnlContent.TabIndex = 2;
            // 
            // grpBoxFertilizer
            // 
            this.grpBoxFertilizer.Controls.Add(this.cmbFertilizerItem);
            this.grpBoxFertilizer.Controls.Add(this.label9);
            this.grpBoxFertilizer.Controls.Add(this.label8);
            this.grpBoxFertilizer.Controls.Add(this.label7);
            this.grpBoxFertilizer.Controls.Add(this.txtFertilizerUsage);
            this.grpBoxFertilizer.Controls.Add(this.label6);
            this.grpBoxFertilizer.Controls.Add(this.txtFertilizerDiscount);
            this.grpBoxFertilizer.Controls.Add(this.label5);
            this.grpBoxFertilizer.Controls.Add(this.txtFertilizerID);
            this.grpBoxFertilizer.Controls.Add(this.btnCancel);
            this.grpBoxFertilizer.Controls.Add(this.btnUpdate);
            this.grpBoxFertilizer.Controls.Add(this.txtFertilizerPrice);
            this.grpBoxFertilizer.Controls.Add(this.txtFertilizerQuantity);
            this.grpBoxFertilizer.Controls.Add(this.txtFertilizerCompanyName);
            this.grpBoxFertilizer.Controls.Add(this.txtFertilizerName);
            this.grpBoxFertilizer.Controls.Add(this.label4);
            this.grpBoxFertilizer.Controls.Add(this.label3);
            this.grpBoxFertilizer.Controls.Add(this.label2);
            this.grpBoxFertilizer.Controls.Add(this.label1);
            this.grpBoxFertilizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxFertilizer.Location = new System.Drawing.Point(0, 0);
            this.grpBoxFertilizer.Name = "grpBoxFertilizer";
            this.grpBoxFertilizer.Size = new System.Drawing.Size(437, 448);
            this.grpBoxFertilizer.TabIndex = 0;
            this.grpBoxFertilizer.TabStop = false;
            this.grpBoxFertilizer.Text = "groupBox1";
            // 
            // cmbFertilizerItem
            // 
            this.cmbFertilizerItem.FormattingEnabled = true;
            this.cmbFertilizerItem.Items.AddRange(new object[] {
            "None",
            "All",
            "Seed",
            "Pestiside",
            "Fertilizer"});
            this.cmbFertilizerItem.Location = new System.Drawing.Point(142, 185);
            this.cmbFertilizerItem.Name = "cmbFertilizerItem";
            this.cmbFertilizerItem.Size = new System.Drawing.Size(126, 21);
            this.cmbFertilizerItem.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Rs";
            // 
            // txtFertilizerUsage
            // 
            this.txtFertilizerUsage.Location = new System.Drawing.Point(143, 217);
            this.txtFertilizerUsage.Multiline = true;
            this.txtFertilizerUsage.Name = "txtFertilizerUsage";
            this.txtFertilizerUsage.Size = new System.Drawing.Size(216, 64);
            this.txtFertilizerUsage.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Usage :";
            // 
            // txtFertilizerDiscount
            // 
            this.txtFertilizerDiscount.Location = new System.Drawing.Point(330, 154);
            this.txtFertilizerDiscount.Name = "txtFertilizerDiscount";
            this.txtFertilizerDiscount.Size = new System.Drawing.Size(73, 20);
            this.txtFertilizerDiscount.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Discount :";
            // 
            // txtFertilizerQuantity
            // 
            this.txtFertilizerQuantity.Location = new System.Drawing.Point(142, 120);
            this.txtFertilizerQuantity.Name = "txtFertilizerQuantity";
            this.txtFertilizerQuantity.Size = new System.Drawing.Size(155, 20);
            this.txtFertilizerQuantity.TabIndex = 19;
            // 
            // txtFertilizerCompanyName
            // 
            this.txtFertilizerCompanyName.Location = new System.Drawing.Point(142, 87);
            this.txtFertilizerCompanyName.Name = "txtFertilizerCompanyName";
            this.txtFertilizerCompanyName.Size = new System.Drawing.Size(155, 20);
            this.txtFertilizerCompanyName.TabIndex = 18;
            // 
            // txtFertilizerName
            // 
            this.txtFertilizerName.Location = new System.Drawing.Point(142, 58);
            this.txtFertilizerName.Name = "txtFertilizerName";
            this.txtFertilizerName.Size = new System.Drawing.Size(155, 20);
            this.txtFertilizerName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Unit Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quntity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fertilizer Company Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fertilizer Name :";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlTreeView);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(637, 448);
            this.pnlMain.TabIndex = 2;
            // 
            // frmEditFertilizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 448);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmEditFertilizer";
            this.Text = "Modify Item";
            this.Load += new System.EventHandler(this.frmEditFertilizer_Load);
            this.pnlTreeView.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.grpBoxFertilizer.ResumeLayout(false);
            this.grpBoxFertilizer.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTreeView;
        private System.Windows.Forms.TreeView trvFertilizer;
        private System.Windows.Forms.TextBox txtFertilizerID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtFertilizerPrice;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpBoxFertilizer;
        private System.Windows.Forms.TextBox txtFertilizerQuantity;
        private System.Windows.Forms.TextBox txtFertilizerCompanyName;
        private System.Windows.Forms.TextBox txtFertilizerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtFertilizerDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFertilizerUsage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFertilizerItem;
        private System.Windows.Forms.Label label9;
    }
}