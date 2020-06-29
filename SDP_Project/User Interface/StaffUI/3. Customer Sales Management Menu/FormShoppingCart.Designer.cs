namespace SDP_Project.User_Interface
{
    partial class FormShoppingCart
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
            this.dgvShoppingCart = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSalesRecordID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShoppingCart
            // 
            this.dgvShoppingCart.AllowUserToAddRows = false;
            this.dgvShoppingCart.AllowUserToDeleteRows = false;
            this.dgvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.productname,
            this.quantity,
            this.unitprice,
            this.discount,
            this.total,
            this.remove});
            this.dgvShoppingCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvShoppingCart.Location = new System.Drawing.Point(0, 0);
            this.dgvShoppingCart.Name = "dgvShoppingCart";
            this.dgvShoppingCart.ReadOnly = true;
            this.dgvShoppingCart.RowHeadersVisible = false;
            this.dgvShoppingCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShoppingCart.RowTemplate.Height = 40;
            this.dgvShoppingCart.Size = new System.Drawing.Size(1104, 711);
            this.dgvShoppingCart.TabIndex = 0;
            this.dgvShoppingCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShoppingCart_CellContentClick);
            // 
            // productid
            // 
            this.productid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.productid.HeaderText = "Product ID";
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Width = 137;
            // 
            // productname
            // 
            this.productname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 173;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 117;
            // 
            // unitprice
            // 
            this.unitprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.unitprice.HeaderText = "Unit Price";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            this.unitprice.Width = 130;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.discount.HeaderText = "Discount(Integer)";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 201;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // remove
            // 
            this.remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.remove.HeaderText = "Remove";
            this.remove.Image = global::SDP_Project.Properties.Resources.Remove;
            this.remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Width = 97;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.Location = new System.Drawing.Point(1104, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(346, 98);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close Shopping Cart";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "Remove";
            this.dataGridViewImageColumn1.Image = global::SDP_Project.Properties.Resources.Remove;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSalesRecordID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Location = new System.Drawing.Point(1110, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 330);
            this.panel1.TabIndex = 6;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(153, 185);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(70, 25);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sub Total:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(173, 221);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(70, 25);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Discount:  -";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(153, 261);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(155, 25);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "lblTotalAmount";
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSettlePayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettlePayment.Location = new System.Drawing.Point(1104, 628);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(346, 83);
            this.btnSettlePayment.TabIndex = 7;
            this.btnSettlePayment.Text = "Settle Payment";
            this.btnSettlePayment.UseVisualStyleBackColor = false;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sales Record ID:";
            // 
            // lblSalesRecordID
            // 
            this.lblSalesRecordID.AutoSize = true;
            this.lblSalesRecordID.ForeColor = System.Drawing.Color.Red;
            this.lblSalesRecordID.Location = new System.Drawing.Point(173, 100);
            this.lblSalesRecordID.Name = "lblSalesRecordID";
            this.lblSalesRecordID.Size = new System.Drawing.Size(70, 25);
            this.lblSalesRecordID.TabIndex = 18;
            this.lblSalesRecordID.Text = "label5";
            // 
            // FormShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 711);
            this.Controls.Add(this.btnSettlePayment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvShoppingCart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingCart";
            this.Load += new System.EventHandler(this.FormShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShoppingCart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn remove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnSettlePayment;
        private System.Windows.Forms.Label lblSalesRecordID;
        private System.Windows.Forms.Label label2;
    }
}