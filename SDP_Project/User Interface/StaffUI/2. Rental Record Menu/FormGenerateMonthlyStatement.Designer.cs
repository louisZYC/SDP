namespace SDP_Project
{
    partial class FormGenerateMonthlyStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerateMonthlyStatement));
            this.dgvTenant = new System.Windows.Forms.DataGridView();
            this.showcaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generate = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPeriod = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTenant
            // 
            this.dgvTenant.AllowUserToAddRows = false;
            this.dgvTenant.AllowUserToDeleteRows = false;
            this.dgvTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showcaseid,
            this.tenantid,
            this.tenantname,
            this.telephone,
            this.generate});
            this.dgvTenant.Location = new System.Drawing.Point(7, 79);
            this.dgvTenant.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTenant.Name = "dgvTenant";
            this.dgvTenant.ReadOnly = true;
            this.dgvTenant.RowHeadersVisible = false;
            this.dgvTenant.RowTemplate.Height = 41;
            this.dgvTenant.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTenant.Size = new System.Drawing.Size(824, 317);
            this.dgvTenant.TabIndex = 0;
            this.dgvTenant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTenant_CellContentClick);
            // 
            // showcaseid
            // 
            this.showcaseid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.showcaseid.HeaderText = "Showcase ID";
            this.showcaseid.Name = "showcaseid";
            this.showcaseid.ReadOnly = true;
            this.showcaseid.Width = 162;
            // 
            // tenantid
            // 
            this.tenantid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenantid.HeaderText = "Tenant ID";
            this.tenantid.Name = "tenantid";
            this.tenantid.ReadOnly = true;
            this.tenantid.Width = 130;
            // 
            // tenantname
            // 
            this.tenantname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tenantname.HeaderText = "Tenant Name";
            this.tenantname.Name = "tenantname";
            this.tenantname.ReadOnly = true;
            this.tenantname.Width = 166;
            // 
            // telephone
            // 
            this.telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telephone.HeaderText = "Telephone";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            this.telephone.Width = 139;
            // 
            // generate
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.generate.DefaultCellStyle = dataGridViewCellStyle1;
            this.generate.HeaderText = "Generate";
            this.generate.Image = global::SDP_Project.Properties.Resources.tick;
            this.generate.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.generate.Name = "generate";
            this.generate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1384, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate Monthly Statement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpPeriod
            // 
            this.dtpPeriod.CustomFormat = "MM yyyy";
            this.dtpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriod.Location = new System.Drawing.Point(210, 436);
            this.dtpPeriod.Name = "dtpPeriod";
            this.dtpPeriod.ShowUpDown = true;
            this.dtpPeriod.Size = new System.Drawing.Size(366, 31);
            this.dtpPeriod.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rental Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "1. select rental period\r\n2. click on Generate";
            // 
            // FormGenerateMonthlyStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 745);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTenant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormGenerateMonthlyStatement";
            this.Text = "FormGenerateMonthlyStatement";
            this.Load += new System.EventHandler(this.FormGenerateMonthlyStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTenant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantname;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewImageColumn generate;
        private System.Windows.Forms.Label label3;
    }
}