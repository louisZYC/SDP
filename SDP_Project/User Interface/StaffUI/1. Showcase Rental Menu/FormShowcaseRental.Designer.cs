namespace SDP_Project
{
    partial class FormShowcaseRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShowcaseList = new System.Windows.Forms.DataGridView();
            this.showcaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlForlblSelected = new System.Windows.Forms.Panel();
            this.lblSelectedShowcase = new System.Windows.Forms.Label();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowcaseList)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlForlblSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowcaseList
            // 
            this.dgvShowcaseList.AllowUserToAddRows = false;
            this.dgvShowcaseList.AllowUserToDeleteRows = false;
            this.dgvShowcaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowcaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showcaseid,
            this.branchid,
            this.rent,
            this.genre,
            this.category,
            this.availability,
            this.Select});
            this.dgvShowcaseList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvShowcaseList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvShowcaseList.Location = new System.Drawing.Point(0, 0);
            this.dgvShowcaseList.Name = "dgvShowcaseList";
            this.dgvShowcaseList.ReadOnly = true;
            this.dgvShowcaseList.RowHeadersVisible = false;
            this.dgvShowcaseList.RowHeadersWidth = 70;
            this.dgvShowcaseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowcaseList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowcaseList.RowTemplate.Height = 42;
            this.dgvShowcaseList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowcaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvShowcaseList.Size = new System.Drawing.Size(872, 750);
            this.dgvShowcaseList.TabIndex = 0;
            this.dgvShowcaseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showcaseid
            // 
            this.showcaseid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.showcaseid.HeaderText = "Showcase ID";
            this.showcaseid.Name = "showcaseid";
            this.showcaseid.ReadOnly = true;
            this.showcaseid.Width = 162;
            // 
            // branchid
            // 
            this.branchid.HeaderText = "Branch ID";
            this.branchid.Name = "branchid";
            this.branchid.ReadOnly = true;
            // 
            // rent
            // 
            this.rent.HeaderText = "Rent";
            this.rent.Name = "rent";
            this.rent.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Width = 96;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.category.HeaderText = "category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 120;
            // 
            // availability
            // 
            this.availability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.availability.HeaderText = "Availability";
            this.availability.Name = "availability";
            this.availability.ReadOnly = true;
            this.availability.Width = 140;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.NullValue = null;
            this.Select.DefaultCellStyle = dataGridViewCellStyle3;
            this.Select.HeaderText = "Select";
            this.Select.Image = global::SDP_Project.Properties.Resources.tick;
            this.Select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 78;
            // 
            // lstSelected
            // 
            this.lstSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSelected.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lstSelected.FormattingEnabled = true;
            this.lstSelected.ItemHeight = 31;
            this.lstSelected.Location = new System.Drawing.Point(0, 130);
            this.lstSelected.Margin = new System.Windows.Forms.Padding(0);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(477, 620);
            this.lstSelected.TabIndex = 4;
            this.lstSelected.DoubleClick += new System.EventHandler(this.lstSelected_DoubleClick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.cmbShop);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnConfirm);
            this.pnlMain.Controls.Add(this.pnlForlblSelected);
            this.pnlMain.Controls.Add(this.lstSelected);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(872, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(477, 750);
            this.pnlMain.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(91, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Double Click To Delete";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(-3, 665);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(480, 85);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlForlblSelected
            // 
            this.pnlForlblSelected.BackColor = System.Drawing.SystemColors.Info;
            this.pnlForlblSelected.Controls.Add(this.lblSelectedShowcase);
            this.pnlForlblSelected.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForlblSelected.Location = new System.Drawing.Point(0, 0);
            this.pnlForlblSelected.Name = "pnlForlblSelected";
            this.pnlForlblSelected.Size = new System.Drawing.Size(477, 100);
            this.pnlForlblSelected.TabIndex = 5;
            // 
            // lblSelectedShowcase
            // 
            this.lblSelectedShowcase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedShowcase.Location = new System.Drawing.Point(0, 0);
            this.lblSelectedShowcase.Name = "lblSelectedShowcase";
            this.lblSelectedShowcase.Size = new System.Drawing.Size(477, 100);
            this.lblSelectedShowcase.TabIndex = 0;
            this.lblSelectedShowcase.Text = "Selected Showcase";
            this.lblSelectedShowcase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbShop
            // 
            this.cmbShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(0, 100);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(477, 33);
            this.cmbShop.TabIndex = 1;
            this.cmbShop.Text = "Select The shop";
            this.cmbShop.SelectedIndexChanged += new System.EventHandler(this.cmbShop_SelectedIndexChanged);
            // 
            // FormShowcaseRental
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1450, 750);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.dgvShowcaseList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShowcaseRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowcaseRental";
            this.Load += new System.EventHandler(this.FormShowcaseRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowcaseList)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlForlblSelected.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvShowcaseList;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlForlblSelected;
        private System.Windows.Forms.Label lblSelectedShowcase;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.ComboBox cmbShop;
    }
}