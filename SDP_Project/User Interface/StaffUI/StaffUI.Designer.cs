namespace SDP_Project
{
    partial class StaffUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowcaseManagement = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnCustomerSalesManagement = new System.Windows.Forms.Button();
            this.btnRentalRecord = new System.Windows.Forms.Button();
            this.btnShowcaseRental = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.btnSalesRecord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "StaffUI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalesRecord);
            this.panel1.Controls.Add(this.btnShowcaseManagement);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnCustomerSalesManagement);
            this.panel1.Controls.Add(this.btnRentalRecord);
            this.panel1.Controls.Add(this.btnShowcaseRental);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnShowcaseManagement
            // 
            this.btnShowcaseManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowcaseManagement.Location = new System.Drawing.Point(0, 392);
            this.btnShowcaseManagement.Name = "btnShowcaseManagement";
            this.btnShowcaseManagement.Size = new System.Drawing.Size(224, 98);
            this.btnShowcaseManagement.TabIndex = 4;
            this.btnShowcaseManagement.Text = "Showcase Management";
            this.btnShowcaseManagement.UseVisualStyleBackColor = true;
            this.btnShowcaseManagement.Click += new System.EventHandler(this.btnShowcaseManagement_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.Location = new System.Drawing.Point(0, 294);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(224, 98);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnCustomerSalesManagement
            // 
            this.btnCustomerSalesManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerSalesManagement.Location = new System.Drawing.Point(0, 196);
            this.btnCustomerSalesManagement.Name = "btnCustomerSalesManagement";
            this.btnCustomerSalesManagement.Size = new System.Drawing.Size(224, 98);
            this.btnCustomerSalesManagement.TabIndex = 2;
            this.btnCustomerSalesManagement.Text = "Customer Sales Management";
            this.btnCustomerSalesManagement.UseVisualStyleBackColor = true;
            this.btnCustomerSalesManagement.Click += new System.EventHandler(this.btnCustomerSalesManagement_Click);
            // 
            // btnRentalRecord
            // 
            this.btnRentalRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentalRecord.Location = new System.Drawing.Point(0, 98);
            this.btnRentalRecord.Name = "btnRentalRecord";
            this.btnRentalRecord.Size = new System.Drawing.Size(224, 98);
            this.btnRentalRecord.TabIndex = 1;
            this.btnRentalRecord.Text = "Rental Record";
            this.btnRentalRecord.UseVisualStyleBackColor = true;
            this.btnRentalRecord.Click += new System.EventHandler(this.btnRentalRecord_Click);
            // 
            // btnShowcaseRental
            // 
            this.btnShowcaseRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowcaseRental.Location = new System.Drawing.Point(0, 0);
            this.btnShowcaseRental.Name = "btnShowcaseRental";
            this.btnShowcaseRental.Size = new System.Drawing.Size(224, 98);
            this.btnShowcaseRental.TabIndex = 0;
            this.btnShowcaseRental.Text = "Showcase Rental";
            this.btnShowcaseRental.UseVisualStyleBackColor = true;
            this.btnShowcaseRental.Click += new System.EventHandler(this.btnShowcaseRental_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(491, 360);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Staff";
            // 
            // pnlChild
            // 
            this.pnlChild.Controls.Add(this.lblWelcome);
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(224, 0);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(1476, 768);
            this.pnlChild.TabIndex = 2;
            // 
            // btnSalesRecord
            // 
            this.btnSalesRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesRecord.Location = new System.Drawing.Point(0, 490);
            this.btnSalesRecord.Name = "btnSalesRecord";
            this.btnSalesRecord.Size = new System.Drawing.Size(224, 98);
            this.btnSalesRecord.TabIndex = 5;
            this.btnSalesRecord.Text = "Sales Record";
            this.btnSalesRecord.UseVisualStyleBackColor = true;
            this.btnSalesRecord.Click += new System.EventHandler(this.btnSalesRecord_Click);
            // 
            // StaffUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 768);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1700, 768);
            this.Name = "StaffUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StaffUI_Load);
            this.panel1.ResumeLayout(false);
            this.pnlChild.ResumeLayout(false);
            this.pnlChild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowcaseRental;
        private System.Windows.Forms.Button btnShowcaseManagement;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnCustomerSalesManagement;
        private System.Windows.Forms.Button btnRentalRecord;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Button btnSalesRecord;
    }
}