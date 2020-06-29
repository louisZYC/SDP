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

namespace SDP_Project
{
    public partial class FormFindID : Form
    {
        String SQL = "";
        MySqlDataReader myData;
        MySqlCommand cmd;
        public FormFindID()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                int phone = Convert.ToInt32(txtPhoneNumber.Text);
                bool canStart = false;
                if (phone > 10000000)
                {
                    canStart = true;
                }
                else
                {
                    txtPhoneNumber.Focus();
                }

                if (canStart == true)
                {
                    SQL = "select TenantID from Tenant where PhoneNumber = " + phone + ";";
                    cmd = new MySqlCommand(SQL, FormContainer.conn);
                    myData = cmd.ExecuteReader();
                    if (myData.HasRows == false)
                    {
                        lblMessage.Text = "The phone number have not registered";
                    }
                    else
                    {
                        while (myData.Read())
                        {
                            txtTenantID.Text = myData["TenantID"].ToString();
                            lblMessage.Text = "Congrats";

                        }
                    }
                    myData.Close();
                }
            }
            catch (FormatException ex)
            {
                txtPhoneNumber.Focus();
                //undo
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Clear();
            txtPhoneNumber.Focus();
            lblMessage.Text = "";
        }
    }
}
