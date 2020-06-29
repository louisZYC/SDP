namespace SDP_Project
{
    partial class FormFindID
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnRrieve = new System.Windows.Forms.Button();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(684, 100);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Retrieve Tenant ID";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRrieve
            // 
            this.btnRrieve.Location = new System.Drawing.Point(81, 364);
            this.btnRrieve.Name = "btnRrieve";
            this.btnRrieve.Size = new System.Drawing.Size(264, 55);
            this.btnRrieve.TabIndex = 1;
            this.btnRrieve.Text = "Retrieve";
            this.btnRrieve.UseVisualStyleBackColor = true;
            this.btnRrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // txtTenantID
            // 
            this.txtTenantID.Location = new System.Drawing.Point(249, 312);
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.ReadOnly = true;
            this.txtTenantID.Size = new System.Drawing.Size(136, 32);
            this.txtTenantID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tenant ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(249, 264);
            this.txtPhoneNumber.Mask = "99999999";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(136, 32);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.AutoSize = true;
            this.lblResultMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultMessage.Location = new System.Drawing.Point(153, 473);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(0, 26);
            this.lblResultMessage.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(190, 473);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 26);
            this.lblMessage.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(412, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 32);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "clear()";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormFindID
            // 
            this.AcceptButton = this.btnRrieve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 695);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblResultMessage);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.btnRrieve);
            this.Controls.Add(this.txtTenantID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormFindID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFindID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRrieve;
        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClear;
    }
}