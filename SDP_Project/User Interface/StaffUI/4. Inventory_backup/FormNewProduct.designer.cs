namespace SDP_Project.User_Interface
{
    partial class FormNewProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.tbqty = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSId = new System.Windows.Forms.TextBox();
            this.dgvNewall = new System.Windows.Forms.DataGridView();
            this.btnConfrim = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.shwocaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewall)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(55, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(79, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Price:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(61, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Remark:";
            // 
            // tbPName
            // 
            this.tbPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPName.Location = new System.Drawing.Point(133, 59);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(202, 26);
            this.tbPName.TabIndex = 47;
            // 
            // tbqty
            // 
            this.tbqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbqty.Location = new System.Drawing.Point(133, 93);
            this.tbqty.Name = "tbqty";
            this.tbqty.Size = new System.Drawing.Size(59, 26);
            this.tbqty.TabIndex = 48;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPrice.Location = new System.Drawing.Point(133, 132);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(59, 26);
            this.tbPrice.TabIndex = 49;
            // 
            // tbRemark
            // 
            this.tbRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbRemark.Location = new System.Drawing.Point(133, 164);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(209, 96);
            this.tbRemark.TabIndex = 50;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNew.Location = new System.Drawing.Point(17, 298);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(322, 70);
            this.btnNew.TabIndex = 51;
            this.btnNew.Text = "Add Product";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(17, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(322, 70);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "ShowcaseID:";
            // 
            // tbSId
            // 
            this.tbSId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSId.Location = new System.Drawing.Point(133, 23);
            this.tbSId.Name = "tbSId";
            this.tbSId.Size = new System.Drawing.Size(202, 26);
            this.tbSId.TabIndex = 53;
            this.tbSId.TabStop = false;
            // 
            // dgvNewall
            // 
            this.dgvNewall.AllowUserToAddRows = false;
            this.dgvNewall.AllowUserToDeleteRows = false;
            this.dgvNewall.AllowUserToResizeColumns = false;
            this.dgvNewall.AllowUserToResizeRows = false;
            this.dgvNewall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shwocaseID,
            this.productName,
            this.Qty,
            this.Price,
            this.Remark});
            this.dgvNewall.EnableHeadersVisualStyles = false;
            this.dgvNewall.Location = new System.Drawing.Point(365, 23);
            this.dgvNewall.MultiSelect = false;
            this.dgvNewall.Name = "dgvNewall";
            this.dgvNewall.ReadOnly = true;
            this.dgvNewall.RowHeadersVisible = false;
            this.dgvNewall.RowTemplate.Height = 24;
            this.dgvNewall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewall.Size = new System.Drawing.Size(444, 365);
            this.dgvNewall.TabIndex = 54;
            this.dgvNewall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewall_CellContentClick);
            // 
            // btnConfrim
            // 
            this.btnConfrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfrim.Location = new System.Drawing.Point(365, 394);
            this.btnConfrim.Name = "btnConfrim";
            this.btnConfrim.Size = new System.Drawing.Size(226, 70);
            this.btnConfrim.TabIndex = 55;
            this.btnConfrim.Text = "Confirm";
            this.btnConfrim.UseVisualStyleBackColor = true;
            this.btnConfrim.Click += new System.EventHandler(this.btnConfrim_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(597, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 70);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // shwocaseID
            // 
            this.shwocaseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shwocaseID.FillWeight = 60F;
            this.shwocaseID.HeaderText = "showcaseID";
            this.shwocaseID.Name = "shwocaseID";
            this.shwocaseID.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "ProductName";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.FillWeight = 40F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.FillWeight = 40F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // FormNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(827, 484);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConfrim);
            this.Controls.Add(this.dgvNewall);
            this.Controls.Add(this.tbSId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbqty);
            this.Controls.Add(this.tbPName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "FormNewProduct";
            this.Text = "FormNewProduct";
            this.Load += new System.EventHandler(this.FormNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.TextBox tbqty;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSId;
        private System.Windows.Forms.DataGridView dgvNewall;
        private System.Windows.Forms.Button btnConfrim;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn shwocaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}