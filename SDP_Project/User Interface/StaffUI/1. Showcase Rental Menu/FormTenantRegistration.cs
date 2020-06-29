using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace SDP_Project
{
    public partial class FormTenantRegistration : Form
    {
        public FormTenantRegistration()
        {
            InitializeComponent();
        }

        private void FormTenantRegistration_Load(object sender, EventArgs e)
        {
            //generate the new staffID to register
            String SQL = "select count(tenantid) from Tenant;";
            MySqlCommand cmd = new MySqlCommand(SQL, FormContainer.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            int IDAmount = 0;
            while (myData.Read())
            {
                IDAmount = myData.GetInt32(0);
            }
            txtTenantID.Text = "A"+IDAmount.ToString("D3");
            myData.Close();

        }


        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                String SQL = "insert into Tenant(tenantid, name, phonenumber,prepaid) values ('" + txtTenantID.Text + "', '" + txtName.Text + "','" + Convert.ToInt32(txtPhoneNumber.Text) + "', 0);";
                MySqlCommand cmd = new MySqlCommand(SQL, FormContainer.conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("You have been registered!");
            }
            MessageBox.Show("Sign up success!");
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenantID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
