using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using SDP_Project.Controller;

namespace SDP_Project
{
    public partial class FormAccountManagement : Form
    {
        public FormAccountManagement()
        {
            InitializeComponent();
        }

        private void FormAccountManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sDP_PROJDataSet1.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.sDP_PROJDataSet1.staff);
        }

        //search by staff ID
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = this.sDP_PROJDataSet1.staff.DefaultView;
            dv.RowFilter = string.Format("staffid like '%{0}%'", txtSearch.Text);
            dataGridView1.DataSource = dv;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AccountManagementController.confirmPassword(txtNewPassword.Text, txtConfirm.Text) == false)
            {
                MessageBox.Show("Confirm password does not match the new password");
            }
            else if (AccountManagementController.validateStaffID(txtStaffID.Text) == false)
            {
                MessageBox.Show("The staff ID is not existed!");
            }
            else if (AccountManagementController.confirmPassword(txtNewPassword.Text, txtConfirm.Text)
                    && AccountManagementController.validateStaffID(txtStaffID.Text))
            {
                AccountManagementController.resetPassword(txtStaffID.Text, txtNewPassword.Text);
                MessageBox.Show("The password is successfully reset!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            staffTableAdapter.Update(sDP_PROJDataSet1);
        }
    }
}
