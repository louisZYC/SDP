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
            this.label5 = new System.Windows.Forms.Label();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.dgvNewProduct = new System.Windows.Forms.DataGridView();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.tbqty = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 98);
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
            this.label2.Location = new System.Drawing.Point(54, 132);
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
            this.label1.Location = new System.Drawing.Point(78, 171);
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
            this.label3.Location = new System.Drawing.Point(57, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Remark:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(62, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Branch:";
            // 
            // cbbBranch
            // 
            this.cbbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(132, 19);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(202, 28);
            this.cbbBranch.TabIndex = 44;
            this.cbbBranch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvNewProduct
            // 
            this.dgvNewProduct.AllowUserToAddRows = false;
            this.dgvNewProduct.AllowUserToDeleteRows = false;
            this.dgvNewProduct.AllowUserToResizeColumns = false;
            this.dgvNewProduct.AllowUserToResizeRows = false;
            this.dgvNewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Branch,
            this.SId});
            this.dgvNewProduct.EnableHeadersVisualStyles = false;
            this.dgvNewProduct.Location = new System.Drawing.Point(372, 19);
            this.dgvNewProduct.MultiSelect = false;
            this.dgvNewProduct.Name = "dgvNewProduct";
            this.dgvNewProduct.ReadOnly = true;
            this.dgvNewProduct.RowHeadersVisible = false;
            this.dgvNewProduct.RowTemplate.Height = 24;
            this.dgvNewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewProduct.Size = new System.Drawing.Size(476, 368);
            this.dgvNewProduct.TabIndex = 46;
            this.dgvNewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewProduct_CellContentClick);
            // 
            // Branch
            // 
            this.Branch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Branch.FillWeight = 50F;
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            // 
            // SId
            // 
            this.SId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SId.FillWeight = 60F;
            this.SId.HeaderText = "showcaseID";
            this.SId.Name = "SId";
            this.SId.ReadOnly = true;
            // 
            // tbPName
            // 
            this.tbPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPName.Location = new System.Drawing.Point(132, 95);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(202, 26);
            this.tbPName.TabIndex = 47;
            // 
            // tbqty
            // 
            this.tbqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbqty.Location = new System.Drawing.Point(132, 129);
            this.tbqty.Name = "tbqty";
            this.tbqty.Size = new System.Drawing.Size(59, 26);
            this.tbqty.TabIndex = 48;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPrice.Location = new System.Drawing.Point(132, 168);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(59, 26);
            this.tbPrice.TabIndex = 49;
            // 
            // tbRemark
            // 
            this.tbRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbRemark.Location = new System.Drawing.Point(129, 210);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(209, 96);
            this.tbRemark.TabIndex = 50;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNew.Location = new System.Drawing.Point(29, 314);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(154, 70);
            this.btnNew.TabIndex = 51;
            this.btnNew.Text = "New Product";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(201, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 70);
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
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "ShowcaseID:";
            // 
            // tbSId
            // 
            this.tbSId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSId.Location = new System.Drawing.Point(132, 59);
            this.tbSId.Name = "tbSId";
            this.tbSId.ReadOnly = true;
            this.tbSId.Size = new System.Drawing.Size(202, 26);
            this.tbSId.TabIndex = 53;
            this.tbSId.TabStop = false;
            // 
            // FormNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(864, 403);
            this.Controls.Add(this.tbSId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbqty);
            this.Controls.Add(this.tbPName);
            this.Controls.Add(this.dgvNewProduct);
            this.Controls.Add(this.cbbBranch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "FormNewProduct";
            this.Text = "FormNewProduct";
            this.Load += new System.EventHandler(this.FormNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.DataGridView dgvNewProduct;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.TextBox tbqty;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SId;
    }
}