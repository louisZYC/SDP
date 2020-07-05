namespace SDP_Project
{
    partial class FormSalesRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesRecord));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSalesRecord = new System.Windows.Forms.DataGridView();
            this.salesrecordid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.btnMonthfilter = new System.Windows.Forms.Button();
            this.btnDayfilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesRecord
            // 
            this.dgvSalesRecord.AllowUserToAddRows = false;
            this.dgvSalesRecord.AllowUserToDeleteRows = false;
            this.dgvSalesRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesrecordid,
            this.staffid,
            this.salesdate,
            this.totalamount,
            this.details});
            this.dgvSalesRecord.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSalesRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesRecord.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSalesRecord.Name = "dgvSalesRecord";
            this.dgvSalesRecord.ReadOnly = true;
            this.dgvSalesRecord.RowHeadersVisible = false;
            this.dgvSalesRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSalesRecord.RowTemplate.Height = 42;
            this.dgvSalesRecord.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesRecord.Size = new System.Drawing.Size(687, 750);
            this.dgvSalesRecord.TabIndex = 0;
            this.dgvSalesRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesRecord_CellContentClick);
            // 
            // salesrecordid
            // 
            this.salesrecordid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.salesrecordid.HeaderText = "Sales Record ID";
            this.salesrecordid.Name = "salesrecordid";
            this.salesrecordid.ReadOnly = true;
            this.salesrecordid.Width = 157;
            // 
            // staffid
            // 
            this.staffid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.staffid.HeaderText = "staffID";
            this.staffid.Name = "staffid";
            this.staffid.ReadOnly = true;
            this.staffid.Width = 98;
            // 
            // salesdate
            // 
            this.salesdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salesdate.HeaderText = "Sales date";
            this.salesdate.Name = "salesdate";
            this.salesdate.ReadOnly = true;
            this.salesdate.Width = 127;
            // 
            // totalamount
            // 
            this.totalamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalamount.HeaderText = "Total Amount";
            this.totalamount.Name = "totalamount";
            this.totalamount.ReadOnly = true;
            this.totalamount.Width = 150;
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.details.DefaultCellStyle = dataGridViewCellStyle1;
            this.details.HeaderText = "details";
            this.details.Image = global::SDP_Project.Properties.Resources.tick;
            this.details.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Width = 81;
            // 
            // cmbShop
            // 
            this.cmbShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(687, 0);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(363, 33);
            this.cmbShop.TabIndex = 3;
            this.cmbShop.Text = "Select The shop";
            this.cmbShop.SelectedIndexChanged += new System.EventHandler(this.cmbShop_SelectedIndexChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.HeaderText = "details";
            this.dataGridViewImageColumn1.Image = global::SDP_Project.Properties.Resources.tick;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Sales: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(852, 488);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 5;
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MM yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(790, 255);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.ShowUpDown = true;
            this.dtpMonth.Size = new System.Drawing.Size(216, 31);
            this.dtpMonth.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(810, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDay
            // 
            this.dtpDay.CustomFormat = "";
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDay.Location = new System.Drawing.Point(790, 381);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(216, 31);
            this.dtpDay.TabIndex = 10;
            // 
            // btnMonthfilter
            // 
            this.btnMonthfilter.Location = new System.Drawing.Point(790, 301);
            this.btnMonthfilter.Name = "btnMonthfilter";
            this.btnMonthfilter.Size = new System.Drawing.Size(216, 38);
            this.btnMonthfilter.TabIndex = 11;
            this.btnMonthfilter.Text = "by Month";
            this.btnMonthfilter.UseVisualStyleBackColor = true;
            this.btnMonthfilter.Click += new System.EventHandler(this.btnMonthfilter_Click);
            // 
            // btnDayfilter
            // 
            this.btnDayfilter.Location = new System.Drawing.Point(790, 428);
            this.btnDayfilter.Name = "btnDayfilter";
            this.btnDayfilter.Size = new System.Drawing.Size(216, 38);
            this.btnDayfilter.TabIndex = 12;
            this.btnDayfilter.Text = "by Day";
            this.btnDayfilter.UseVisualStyleBackColor = true;
            this.btnDayfilter.Click += new System.EventHandler(this.btnDayfilter_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(781, 116);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 53);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 750);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDayfilter);
            this.Controls.Add(this.btnMonthfilter);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbShop);
            this.Controls.Add(this.dgvSalesRecord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSalesRecord";
            this.Text = "FormSalesRecord";
            this.Load += new System.EventHandler(this.FormSalesRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesRecord;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesrecordid;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamount;
        private System.Windows.Forms.DataGridViewImageColumn details;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Button btnMonthfilter;
        private System.Windows.Forms.Button btnDayfilter;
        private System.Windows.Forms.Button btnRefresh;
    }
}