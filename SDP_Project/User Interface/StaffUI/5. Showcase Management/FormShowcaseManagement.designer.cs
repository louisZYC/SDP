namespace SDP_Project.User_Interface
{

    partial class FormShowcaseManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sDPPROJDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sDP_PROJDataSet1 = new SDP_Project.SDP_PROJDataSet1();
            this.showcaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sDPPROJDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bUpdata = new System.Windows.Forms.Button();
            this.sUpdata = new System.Windows.Forms.Button();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelectedShowcase = new System.Windows.Forms.Label();
            this.dgvShowcaseList = new System.Windows.Forms.DataGridView();
            this.showcaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.showcaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sDPPROJDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDP_PROJDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showcaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDPPROJDataSet1BindingSource)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowcaseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showcaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // sDPPROJDataSet1BindingSource1
            // 
            this.sDPPROJDataSet1BindingSource1.DataSource = this.sDP_PROJDataSet1;
            this.sDPPROJDataSet1BindingSource1.Position = 0;
            // 
            // sDP_PROJDataSet1
            // 
            this.sDP_PROJDataSet1.DataSetName = "SDP_PROJDataSet1";
            this.sDP_PROJDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showcaseBindingSource
            // 
            this.showcaseBindingSource.DataSource = this.sDPPROJDataSet1BindingSource;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tbSearch);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.tbRent);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.tbSid);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cmbCategory);
            this.pnlMain.Controls.Add(this.button3);
            this.pnlMain.Controls.Add(this.bUpdata);
            this.pnlMain.Controls.Add(this.sUpdata);
            this.pnlMain.Controls.Add(this.cbPrivate);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Location = new System.Drawing.Point(700, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 800);
            this.pnlMain.TabIndex = 5;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(177, 183);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(268, 31);
            this.tbSearch.TabIndex = 21;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Search ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Update the selected data upon :";
            // 
            // tbRent
            // 
            this.tbRent.Location = new System.Drawing.Point(176, 324);
            this.tbRent.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.tbRent.Name = "tbRent";
            this.tbRent.Size = new System.Drawing.Size(127, 31);
            this.tbRent.TabIndex = 18;
            this.tbRent.ValueChanged += new System.EventHandler(this.tbRent_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Genre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rent :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "ShowCaseID :";
            // 
            // tbSid
            // 
            this.tbSid.Location = new System.Drawing.Point(176, 265);
            this.tbSid.Name = "tbSid";
            this.tbSid.ReadOnly = true;
            this.tbSid.Size = new System.Drawing.Size(268, 31);
            this.tbSid.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Accessories",
            "Electronics",
            "Toys"});
            this.cmbCategory.Location = new System.Drawing.Point(176, 445);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(268, 33);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 722);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "AddCase";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bUpdata
            // 
            this.bUpdata.Location = new System.Drawing.Point(92, 652);
            this.bUpdata.Name = "bUpdata";
            this.bUpdata.Size = new System.Drawing.Size(352, 41);
            this.bUpdata.TabIndex = 8;
            this.bUpdata.Text = "Batch Update";
            this.bUpdata.UseVisualStyleBackColor = true;
            // 
            // sUpdata
            // 
            this.sUpdata.Location = new System.Drawing.Point(92, 553);
            this.sUpdata.Name = "sUpdata";
            this.sUpdata.Size = new System.Drawing.Size(352, 41);
            this.sUpdata.TabIndex = 7;
            this.sUpdata.Text = "single Update";
            this.sUpdata.UseVisualStyleBackColor = true;
            this.sUpdata.Click += new System.EventHandler(this.sUpdata_Click);
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.Location = new System.Drawing.Point(176, 384);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(98, 29);
            this.cbPrivate.TabIndex = 6;
            this.cbPrivate.Text = "Private";
            this.cbPrivate.UseVisualStyleBackColor = true;
            this.cbPrivate.CheckStateChanged += new System.EventHandler(this.cbPrivate_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblSelectedShowcase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 100);
            this.panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(500, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select The Shops";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSelectedShowcase
            // 
            this.lblSelectedShowcase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSelectedShowcase.Location = new System.Drawing.Point(0, 36);
            this.lblSelectedShowcase.Name = "lblSelectedShowcase";
            this.lblSelectedShowcase.Size = new System.Drawing.Size(500, 64);
            this.lblSelectedShowcase.TabIndex = 0;
            this.lblSelectedShowcase.Text = "Edit Selected Showcase";
            this.lblSelectedShowcase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelectedShowcase.Click += new System.EventHandler(this.lblSelectedShowcase_Click);
            // 
            // dgvShowcaseList
            // 
            this.dgvShowcaseList.AllowUserToAddRows = false;
            this.dgvShowcaseList.AllowUserToDeleteRows = false;
            this.dgvShowcaseList.AllowUserToResizeColumns = false;
            this.dgvShowcaseList.AllowUserToResizeRows = false;
            this.dgvShowcaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowcaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showcaseid,
            this.rent,
            this.genre,
            this.category,
            this.availability,
            this.Select});
            this.dgvShowcaseList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvShowcaseList.Location = new System.Drawing.Point(0, 0);
            this.dgvShowcaseList.MultiSelect = false;
            this.dgvShowcaseList.Name = "dgvShowcaseList";
            this.dgvShowcaseList.ReadOnly = true;
            this.dgvShowcaseList.RowHeadersVisible = false;
            this.dgvShowcaseList.RowHeadersWidth = 70;
            this.dgvShowcaseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowcaseList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowcaseList.RowTemplate.Height = 42;
            this.dgvShowcaseList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowcaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvShowcaseList.Size = new System.Drawing.Size(700, 480);
            this.dgvShowcaseList.TabIndex = 7;
            this.dgvShowcaseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowcaseList_CellContentClick_1);
            // 
            // showcaseid
            // 
            this.showcaseid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.showcaseid.HeaderText = "Showcase ID";
            this.showcaseid.Name = "showcaseid";
            this.showcaseid.ReadOnly = true;
            this.showcaseid.Width = 162;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.NullValue = null;
            this.Select.DefaultCellStyle = dataGridViewCellStyle1;
            this.Select.HeaderText = "Select";
            this.Select.Image = global::SDP_Project.Properties.Resources.tick;
            this.Select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 78;
            // 
            // showcaseBindingSource1
            // 
            this.showcaseBindingSource1.DataMember = "showcase";
            this.showcaseBindingSource1.DataSource = this.sDPPROJDataSet1BindingSource1;
            // 
            // dgvSelected
            // 
            this.dgvSelected.AllowUserToAddRows = false;
            this.dgvSelected.AllowUserToDeleteRows = false;
            this.dgvSelected.AllowUserToResizeColumns = false;
            this.dgvSelected.AllowUserToResizeRows = false;
            this.dgvSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelected.ColumnHeadersHeight = 33;
            this.dgvSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.reny,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.branchid});
            this.dgvSelected.Location = new System.Drawing.Point(0, 480);
            this.dgvSelected.MultiSelect = false;
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.RowHeadersVisible = false;
            this.dgvSelected.RowTemplate.Height = 24;
            this.dgvSelected.Size = new System.Drawing.Size(700, 320);
            this.dgvSelected.TabIndex = 6;
            this.dgvSelected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelected_CellContentClick);
            this.dgvSelected.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelected_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ShowCaseID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // reny
            // 
            this.reny.HeaderText = "Rent";
            this.reny.Name = "reny";
            this.reny.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // branchid
            // 
            this.branchid.HeaderText = "Branchid";
            this.branchid.Name = "branchid";
            this.branchid.ReadOnly = true;
            // 
            // FormShowcaseManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.dgvShowcaseList);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShowcaseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowcaseRental";
            ((System.ComponentModel.ISupportInitialize)(this.sDPPROJDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDP_PROJDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showcaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDPPROJDataSet1BindingSource)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRent)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowcaseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showcaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectedShowcase;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sDPPROJDataSet1BindingSource;
        private System.Windows.Forms.BindingSource showcaseBindingSource;
        private System.Windows.Forms.BindingSource sDPPROJDataSet1BindingSource1;
        private SDP_PROJDataSet1 sDP_PROJDataSet1;
        private System.Windows.Forms.BindingSource showcaseBindingSource1;
        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.DataGridView dgvShowcaseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reny;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bUpdata;
        private System.Windows.Forms.Button sUpdata;
        private System.Windows.Forms.CheckBox cbPrivate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tbRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label6;
    }
}
 