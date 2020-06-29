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
    public partial class FormSettleContract : Form
    {
        DataTable dt;
        DateTime today = DateTime.Today;
        MySqlCommand cmd;
        String SQL;
        MySqlDataReader myData;

        public FormSettleContract(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            lblContractID.Text = "Contract ID: " + generateContractID();
        }

        public String generateContractID()
        {
            int SequenceNumber = generateSequenceNumber();
            String contractID = today.ToString("yyyyMMdd") + SequenceNumber.ToString("D5");
            return contractID;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormTenantRegistration FrmTenantRegistration = new FormTenantRegistration();
            FrmTenantRegistration.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            updateDatabase_Tenant_prepaid();
            updateDatabase_Contract();
            MessageBox.Show("Successfuly settle contract!");
            this.Close();
        }

        public int fetchPrepaidBalance(String tenantid)
        {
            int balanceFetched = 0;
            try
            {
                SQL = "select prepaid from Tenant where tenantid = '" + txtTenantID.Text + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                if (myData.HasRows)
                {
                    while (myData.Read())
                    {
                        balanceFetched = Convert.ToInt32(myData["prepaid"]);
                    }
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
            return balanceFetched;
        }
        public int generateSequenceNumber()
        {
            String date = today.ToString("yyyyMMdd");
            int SequenceNumber = 0;
            try
            {
                SQL = "select count(contractid) as amount from contract where contractid like'" + date + "%';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                    SequenceNumber = Convert.ToInt32(myData["amount"]);
                }
                myData.Close();
                return SequenceNumber;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
            return SequenceNumber;
        }

        public void updateDatabase_Tenant_prepaid()
        {
            int balance = fetchPrepaidBalance(txtTenantID.Text);
            try
            {
                balance += Convert.ToInt32(txtPrepaid.Text);
                SQL = "update Tenant set prepaid = " + balance + " where tenantid ='" + txtTenantID.Text + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }
        public void updateDatabase_Contract()
        {
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    String contractID = generateContractID();
                    DateTime rentto = DateTime.Parse(dt.Rows[i][2].ToString()).AddMonths(Convert.ToInt32(dt.Rows[i][3]));
                    rentto = rentto.AddDays(-1);
                    SQL = "insert into contract(contractid, showcaseid, tenantid, rentfrom, rentto,discount,commission)" +
                        " values(" + contractID + ", '" + dt.Rows[i][0].ToString() + "','" + txtTenantID.Text.ToString() + "', " +
                        "'" + dt.Rows[i][2] + "', '" + rentto.ToString("yyyy-MM-dd") + "','" + Convert.ToDouble(dt.Rows[i][4]) / 100 + "','" + Convert.ToDouble(dt.Rows[i][6]) / 100 + "');";
                    cmd = new MySqlCommand(SQL, FormContainer.conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }

        public void calChange()
        {
            try
            {
                txtChange.Text = (Convert.ToInt32(txtPrepaid.Text) - Convert.ToInt32(txtTender.Text)).ToString();
            }
            catch (FormatException)
            {
                //cancel method.
            }
        }
        private void txtPrepaid_TextChanged(object sender, EventArgs e)
        {
            calChange();
        }
        private void txtTender_TextChanged(object sender, EventArgs e)
        {
            calChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFindID frmfindid = new FormFindID();
            frmfindid.Show();
        }
    }
}
