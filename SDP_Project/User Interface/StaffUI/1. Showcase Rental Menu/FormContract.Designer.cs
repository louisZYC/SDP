namespace SDP_Project
{
    partial class FormContract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContract));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedID = new System.Windows.Forms.Label();
            this.dgvContractList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pnlAnnouncement = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSettle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCommission = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractList)).BeginInit();
            this.pnlAnnouncement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 492);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(366, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duration(Month):";
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(260, 535);
            this.nudDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(120, 31);
            this.nudDuration.TabIndex = 4;
            this.nudDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(47, 627);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(356, 55);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rental From:";
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.AutoSize = true;
            this.lblSelectedID.ForeColor = System.Drawing.Color.Red;
            this.lblSelectedID.Location = new System.Drawing.Point(255, 449);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(131, 25);
            this.lblSelectedID.TabIndex = 0;
            this.lblSelectedID.Text = "ShowcaseID";
            // 
            // dgvContractList
            // 
            this.dgvContractList.AllowUserToAddRows = false;
            this.dgvContractList.AllowUserToDeleteRows = false;
            this.dgvContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.duration,
            this.discount,
            this.currentprice,
            this.commission,
            this.Select});
            this.dgvContractList.Location = new System.Drawing.Point(0, 40);
            this.dgvContractList.Name = "dgvContractList";
            this.dgvContractList.ReadOnly = true;
            this.dgvContractList.RowHeadersVisible = false;
            this.dgvContractList.RowHeadersWidth = 70;
            this.dgvContractList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvContractList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContractList.RowTemplate.Height = 42;
            this.dgvContractList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContractList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractList.Size = new System.Drawing.Size(1088, 326);
            this.dgvContractList.TabIndex = 8;
            this.dgvContractList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "showcase ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 159;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "rent";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Rent From";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 137;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 118;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.discount.HeaderText = "Discount(%)";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 154;
            // 
            // currentprice
            // 
            this.currentprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.currentprice.HeaderText = "Current Price";
            this.currentprice.Name = "currentprice";
            this.currentprice.ReadOnly = true;
            this.currentprice.Width = 163;
            // 
            // commission
            // 
            this.commission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.commission.HeaderText = "Comission(%)";
            this.commission.Name = "commission";
            this.commission.ReadOnly = true;
            this.commission.Width = 170;
            // 
            // Select
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.Select.DefaultCellStyle = dataGridViewCellStyle1;
            this.Select.HeaderText = "Select";
            this.Select.Image = global::SDP_Project.Properties.Resources.tick;
            this.Select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(42, 449);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(207, 25);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Selected Showcase:";
            // 
            // lbl2
            // 
            this.lbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2.Location = new System.Drawing.Point(0, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(298, 80);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "3 showcases: 5% off discount\r\n6 showcase: 10% off discount\r\n";
            // 
            // pnlAnnouncement
            // 
            this.pnlAnnouncement.BackColor = System.Drawing.SystemColors.Info;
            this.pnlAnnouncement.Controls.Add(this.lbl2);
            this.pnlAnnouncement.Location = new System.Drawing.Point(747, 385);
            this.pnlAnnouncement.Name = "pnlAnnouncement";
            this.pnlAnnouncement.Size = new System.Drawing.Size(298, 80);
            this.pnlAnnouncement.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Amount:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(768, 506);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(102, 25);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "Discount:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(934, 506);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(24, 25);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(934, 541);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 25);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // btnSettle
            // 
            this.btnSettle.Location = new System.Drawing.Point(730, 590);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(243, 46);
            this.btnSettle.TabIndex = 16;
            this.btnSettle.Text = "Settle contract";
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Commission(%): ";
            // 
            // nudCommission
            // 
            this.nudCommission.Location = new System.Drawing.Point(266, 588);
            this.nudCommission.Name = "nudCommission";
            this.nudCommission.Size = new System.Drawing.Size(120, 31);
            this.nudCommission.TabIndex = 19;
            this.nudCommission.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // FormContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1292, 694);
            this.Controls.Add(this.nudCommission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSettle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlAnnouncement);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvContractList);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelectedID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractList)).EndInit();
            this.pnlAnnouncement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedID;
        private System.Windows.Forms.DataGridView dgvContractList;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pnlAnnouncement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn commission;
        private System.Windows.Forms.DataGridViewImageColumn Select;
    }
}