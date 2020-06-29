using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            cmbRank.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RegistrationController.confirmPassword(txtPassword.Text, txtConfirmPassword.Text) == false)
            {
                MessageBox.Show("Confirm password does not match the new password");
            }
            else if (RegistrationController.validateStaffID(txtStaffID.Text) == false)
            {
                MessageBox.Show("The staff ID has been registered");
            }
            else if (RegistrationController.confirmPassword(txtPassword.Text, txtConfirmPassword.Text)
                    && RegistrationController.validateStaffID(txtStaffID.Text))
            {
                RegistrationController.register(txtStaffID.Text, txtPassword.Text, txtName.Text, cmbRank.SelectedItem.ToString());
                MessageBox.Show("The account is successfully registered!");
            }


        }











    }
}
