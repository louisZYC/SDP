namespace SDP_Project.User_Interface
{
    partial class FormInventory
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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbStockOut = new System.Windows.Forms.TextBox();
            this.tbStockIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblpprice = new System.Windows.Forms.Label();
            this.tbPId = new System.Windows.Forms.TextBox();
            this.tbPAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.SId,
            this.PName,
            this.qty,
            this.price,
            this.Remark});
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.Location = new System.Drawing.Point(11, 123);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(444, 317);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PId
            // 
            this.PId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PId.HeaderText = "productID";
            this.PId.Name = "PId";
            this.PId.ReadOnly = true;
            this.PId.Width = 78;
            // 
            // SId
            // 
            this.SId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SId.HeaderText = "showcaseID";
            this.SId.Name = "SId";
            this.SId.ReadOnly = true;
            this.SId.Width = 85;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 45;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 53;
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 67;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(88, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(198, 22);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search:";
            // 
            // tbSId
            // 
            this.tbSId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSId.CausesValidation = false;
            this.tbSId.Location = new System.Drawing.Point(134, 69);
            this.tbSId.Name = "tbSId";
            this.tbSId.ReadOnly = true;
            this.tbSId.Size = new System.Drawing.Size(124, 22);
            this.tbSId.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(11, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "ShwocaseID:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.tbStockOut);
            this.panel3.Controls.Add(this.tbStockIn);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(19, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 139);
            this.panel3.TabIndex = 35;
            // 
            // tbStockOut
            // 
            this.tbStockOut.Location = new System.Drawing.Point(92, 88);
            this.tbStockOut.Name = "tbStockOut";
            this.tbStockOut.Size = new System.Drawing.Size(73, 22);
            this.tbStockOut.TabIndex = 20;
            this.tbStockOut.Text = "0";
            // 
            // tbStockIn
            // 
            this.tbStockIn.Location = new System.Drawing.Point(92, 56);
            this.tbStockIn.Name = "tbStockIn";
            this.tbStockIn.Size = new System.Drawing.Size(73, 22);
            this.tbStockIn.TabIndex = 17;
            this.tbStockIn.Text = "0";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Stock-Out:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stock-In:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Inventory";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrice.CausesValidation = false;
            this.tbPrice.Location = new System.Drawing.Point(134, 153);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(57, 22);
            this.tbPrice.TabIndex = 46;
            // 
            // lblpprice
            // 
            this.lblpprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblpprice.Location = new System.Drawing.Point(11, 155);
            this.lblpprice.Name = "lblpprice";
            this.lblpprice.Size = new System.Drawing.Size(117, 20);
            this.lblpprice.TabIndex = 45;
            this.lblpprice.Text = "Price:";
            // 
            // tbPId
            // 
            this.tbPId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPId.CausesValidation = false;
            this.tbPId.Location = new System.Drawing.Point(134, 41);
            this.tbPId.Name = "tbPId";
            this.tbPId.ReadOnly = true;
            this.tbPId.Size = new System.Drawing.Size(124, 22);
            this.tbPId.TabIndex = 44;
            // 
            // tbPAmount
            // 
            this.tbPAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPAmount.CausesValidation = false;
            this.tbPAmount.Location = new System.Drawing.Point(134, 125);
            this.tbPAmount.Name = "tbPAmount";
            this.tbPAmount.ReadOnly = true;
            this.tbPAmount.Size = new System.Drawing.Size(57, 22);
            this.tbPAmount.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Quantity:";
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelProduct.Location = new System.Drawing.Point(221, 316);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(140, 50);
            this.btnDelProduct.TabIndex = 41;
            this.btnDelProduct.Text = "Delete Product";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // tbPName
            // 
            this.tbPName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPName.Location = new System.Drawing.Point(134, 97);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(198, 22);
            this.tbPName.TabIndex = 40;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateProduct.Location = new System.Drawing.Point(221, 246);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(140, 50);
            this.btnUpdateProduct.TabIndex = 39;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(11, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "ProductName:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(11, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "ProductID:";
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInfo.Location = new System.Drawing.Point(9, 7);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(161, 31);
            this.lblProductInfo.TabIndex = 36;
            this.lblProductInfo.Text = "Product Info";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(337, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 50);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnAddProduct.Location = new System.Drawing.Point(11, 64);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(275, 50);
            this.btnAddProduct.TabIndex = 49;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbRemark
            // 
            this.tbRemark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRemark.CausesValidation = false;
            this.tbRemark.Location = new System.Drawing.Point(134, 181);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(198, 22);
            this.tbRemark.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Remark:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tbRemark);
            this.panel1.Controls.Add(this.lblProductInfo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbPId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbSId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnUpdateProduct);
            this.panel1.Controls.Add(this.tbPName);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.btnDelProduct);
            this.panel1.Controls.Add(this.lblpprice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(461, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 453);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.dgvInventory);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 453);
            this.panel2.TabIndex = 54;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(851, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventory";
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbStockOut;
        private System.Windows.Forms.TextBox tbStockIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblpprice;
        private System.Windows.Forms.TextBox tbPId;
        private System.Windows.Forms.TextBox tbPAmount;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProductInfo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}