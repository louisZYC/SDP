namespace SDP_Project
{
    partial class FormSettleContract
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
            this.lblTenantID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblContractID = new System.Windows.Forms.Label();
            this.txtPrepaid = new System.Windows.Forms.MaskedTextBox();
            this.txtTender = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenantID
            // 
            this.lblTenantID.AutoSize = true;
            this.lblTenantID.Location = new System.Drawing.Point(164, 156);
            this.lblTenantID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTenantID.Name = "lblTenantID";
            this.lblTenantID.Size = new System.Drawing.Size(112, 26);
            this.lblTenantID.TabIndex = 0;
            this.lblTenantID.Text = "Tenant ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prepaid Amount:";
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(984, 100);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Settle Contract";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenantID
            // 
            this.txtTenantID.Location = new System.Drawing.Point(285, 156);
            this.txtTenantID.MaxLength = 4;
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Size = new System.Drawing.Size(246, 32);
            this.txtTenantID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cash Tendered:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Change:";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(285, 450);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(246, 32);
            this.txtChange.TabIndex = 11;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(587, 145);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(299, 82);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "No ID yet? Register now.";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(106, 537);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(385, 48);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblContractID
            // 
            this.lblContractID.AutoSize = true;
            this.lblContractID.Location = new System.Drawing.Point(200, 114);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(70, 26);
            this.lblContractID.TabIndex = 15;
            this.lblContractID.Text = "label6";
            // 
            // txtPrepaid
            // 
            this.txtPrepaid.Location = new System.Drawing.Point(285, 366);
            this.txtPrepaid.Mask = "999999";
            this.txtPrepaid.Name = "txtPrepaid";
            this.txtPrepaid.Size = new System.Drawing.Size(246, 32);
            this.txtPrepaid.TabIndex = 2;
            this.txtPrepaid.TextChanged += new System.EventHandler(this.txtPrepaid_TextChanged);
            // 
            // txtTender
            // 
            this.txtTender.Location = new System.Drawing.Point(285, 412);
            this.txtTender.Mask = "999999";
            this.txtTender.Name = "txtTender";
            this.txtTender.Size = new System.Drawing.Size(246, 32);
            this.txtTender.TabIndex = 3;
            this.txtTender.TextChanged += new System.EventHandler(this.txtTender_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 67);
            this.button1.TabIndex = 16;
            this.button1.Text = "ID forgotten. Find it out by Phone#";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSettleContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTender);
            this.Controls.Add(this.txtPrepaid);
            this.Controls.Add(this.lblContractID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenantID);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenantID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSettleContract";
            this.Text = "FormSettleContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenantID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.MaskedTextBox txtPrepaid;
        private System.Windows.Forms.MaskedTextBox txtTender;
        private System.Windows.Forms.Button button1;
    }
}