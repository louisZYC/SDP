namespace SDP_Project.User_Interface
{
    partial class FormRentalRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRentalRecord));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRentalRecord = new System.Windows.Forms.DataGridView();
            this.contractid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showcaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.monthly = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblContractID = new System.Windows.Forms.Label();
            this.dtpRentTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMakechange = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lstMonthly = new System.Windows.Forms.ListBox();
            this.lblSelectedShowcase = new System.Windows.Forms.Label();
            this.pnlMonthlyStatement = new System.Windows.Forms.Panel();
            this.btnOne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecord)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMakechange.SuspendLayout();
            this.pnlMonthlyStatement.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRentalRecord
            // 
            this.dgvRentalRecord.AllowUserToAddRows = false;
            this.dgvRentalRecord.AllowUserToDeleteRows = false;
            this.dgvRentalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractid,
            this.showcaseid,
            this.tenantid,
            this.rentfrom,
            this.rentto,
            this.discount,
            this.select,
            this.monthly});
            this.dgvRentalRecord.Location = new System.Drawing.Point(1, 12);
            this.dgvRentalRecord.Name = "dgvRentalRecord";
            this.dgvRentalRecord.ReadOnly = true;
            this.dgvRentalRecord.RowHeadersVisible = false;
            this.dgvRentalRecord.RowHeadersWidth = 70;
            this.dgvRentalRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRentalRecord.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRentalRecord.RowTemplate.Height = 42;
            this.dgvRentalRecord.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentalRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRentalRecord.Size = new System.Drawing.Size(1204, 411);
            this.dgvRentalRecord.TabIndex = 0;
            this.dgvRentalRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalRecord_CellContentClick);
            // 
            // contractid
            // 
            this.contractid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contractid.HeaderText = "Contract ID";
            this.contractid.Name = "contractid";
            this.contractid.ReadOnly = true;
            this.contractid.Width = 132;
            // 
            // showcaseid
            // 
            this.showcaseid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.showcaseid.HeaderText = "Showcase ID";
            this.showcaseid.Name = "showcaseid";
            this.showcaseid.ReadOnly = true;
            this.showcaseid.Width = 148;
            // 
            // tenantid
            // 
            this.tenantid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenantid.HeaderText = "Tenant ID";
            this.tenantid.Name = "tenantid";
            this.tenantid.ReadOnly = true;
            this.tenantid.Width = 119;
            // 
            // rentfrom
            // 
            this.rentfrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rentfrom.HeaderText = "Rent From";
            this.rentfrom.Name = "rentfrom";
            this.rentfrom.ReadOnly = true;
            this.rentfrom.Width = 125;
            // 
            // rentto
            // 
            this.rentto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rentto.HeaderText = "Rent To";
            this.rentto.Name = "rentto";
            this.rentto.ReadOnly = true;
            this.rentto.Width = 104;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.discount.HeaderText = "discount(%)";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 151;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.select.DefaultCellStyle = dataGridViewCellStyle1;
            this.select.HeaderText = "Select";
            this.select.Image = global::SDP_Project.Properties.Resources.tick;
            this.select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 78;
            // 
            // monthly
            // 
            this.monthly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.monthly.DefaultCellStyle = dataGridViewCellStyle2;
            this.monthly.HeaderText = "Monthly Statement";
            this.monthly.Image = global::SDP_Project.Properties.Resources.tick;
            this.monthly.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.monthly.Name = "monthly";
            this.monthly.ReadOnly = true;
            this.monthly.Width = 177;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 90);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(131, 25);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Contract ID: ";
            // 
            // lblContractID
            // 
            this.lblContractID.AutoSize = true;
            this.lblContractID.ForeColor = System.Drawing.Color.Red;
            this.lblContractID.Location = new System.Drawing.Point(174, 90);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(119, 25);
            this.lblContractID.TabIndex = 2;
            this.lblContractID.Text = "Contract ID";
            // 
            // dtpRentTo
            // 
            this.dtpRentTo.CustomFormat = "MM yyyy";
            this.dtpRentTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentTo.Location = new System.Drawing.Point(179, 134);
            this.dtpRentTo.Name = "dtpRentTo";
            this.dtpRentTo.ShowUpDown = true;
            this.dtpRentTo.Size = new System.Drawing.Size(366, 31);
            this.dtpRentTo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rental To:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pnlMakechange);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.dtpRentTo);
            this.panel1.Controls.Add(this.lblContractID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 279);
            this.panel1.TabIndex = 7;
            // 
            // pnlMakechange
            // 
            this.pnlMakechange.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMakechange.Controls.Add(this.label1);
            this.pnlMakechange.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMakechange.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMakechange.Location = new System.Drawing.Point(0, 0);
            this.pnlMakechange.Name = "pnlMakechange";
            this.pnlMakechange.Size = new System.Drawing.Size(596, 71);
            this.pnlMakechange.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Change";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(47, 197);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(463, 62);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm Change";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lstMonthly
            // 
            this.lstMonthly.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstMonthly.ItemHeight = 25;
            this.lstMonthly.Location = new System.Drawing.Point(0, 100);
            this.lstMonthly.Name = "lstMonthly";
            this.lstMonthly.Size = new System.Drawing.Size(365, 604);
            this.lstMonthly.TabIndex = 0;
            this.lstMonthly.DoubleClick += new System.EventHandler(this.lstMonthly_DoubleClick);
            // 
            // lblSelectedShowcase
            // 
            this.lblSelectedShowcase.BackColor = System.Drawing.SystemColors.Info;
            this.lblSelectedShowcase.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectedShowcase.Location = new System.Drawing.Point(0, 0);
            this.lblSelectedShowcase.Name = "lblSelectedShowcase";
            this.lblSelectedShowcase.Size = new System.Drawing.Size(365, 100);
            this.lblSelectedShowcase.TabIndex = 8;
            this.lblSelectedShowcase.Text = "Generate Monthly Statement";
            this.lblSelectedShowcase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMonthlyStatement
            // 
            this.pnlMonthlyStatement.Controls.Add(this.btnOne);
            this.pnlMonthlyStatement.Controls.Add(this.label3);
            this.pnlMonthlyStatement.Controls.Add(this.btnNext);
            this.pnlMonthlyStatement.Controls.Add(this.lstMonthly);
            this.pnlMonthlyStatement.Controls.Add(this.lblSelectedShowcase);
            this.pnlMonthlyStatement.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMonthlyStatement.Location = new System.Drawing.Point(1085, 0);
            this.pnlMonthlyStatement.Name = "pnlMonthlyStatement";
            this.pnlMonthlyStatement.Size = new System.Drawing.Size(365, 750);
            this.pnlMonthlyStatement.TabIndex = 9;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(35, 0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(239, 41);
            this.btnOne.TabIndex = 10;
            this.btnOne.Text = "One-click selection";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(30, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Double click to remove elements";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(0, 658);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(365, 46);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(743, 444);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(258, 56);
            this.btnHide.TabIndex = 10;
            this.btnHide.Text = "Hide expired contract";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(743, 519);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(258, 52);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show expired contract";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FormRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1450, 750);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.pnlMonthlyStatement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRentalRecord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormRentalRecord";
            this.Text = "FormRentalRecord";
            this.Load += new System.EventHandler(this.FormRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMakechange.ResumeLayout(false);
            this.pnlMakechange.PerformLayout();
            this.pnlMonthlyStatement.ResumeLayout(false);
            this.pnlMonthlyStatement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRentalRecord;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.DateTimePicker dtpRentTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlMakechange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMonthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractid;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentfrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentto;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.DataGridViewImageColumn monthly;
        private System.Windows.Forms.Label lblSelectedShowcase;
        private System.Windows.Forms.Panel pnlMonthlyStatement;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
    }
}