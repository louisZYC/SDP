using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Project.User_Interface
{
    public partial class FormNewProduct : Form
    {
        private String SQL = "";
        private MySqlCommand cmd;
        private MySqlDataReader myData;
        DateTime today = DateTime.Today;
        public FormNewProduct()
        {
            InitializeComponent();
        }

        private void FormNewProduct_Load(object sender, EventArgs e)
        {
            intializeDataGridView();
            intializeCombobox();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvNewProduct.Rows.Clear();
            SQL = "SELECT b.branchName,s.showcaseid FROM branch b INNER JOIN showcase s ON s.branchid = b.branchid WHERE b.branchName LIKE '"+ cbbBranch.SelectedItem +"' ;";
            cmd = new MySqlCommand(SQL, FormContainer.conn);
            myData = cmd.ExecuteReader();
            if (myData.HasRows)
            {
                while (myData.Read())
                {
                    dgvNewProduct.Rows.Add(myData["branchName"], //Pid
                                           myData["showcaseid"] //Sid
                                          );
                }
            }

            myData.Close();
        }
        private void intializeCombobox()
        {
            cbbBranch.Items.Clear();
            try {
                SQL = "SELECT branchName FROM branch;";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                if (myData.HasRows)
                {
                    while (myData.Read())
                    {
                        cbbBranch.Items.Add(myData["branchName"]);
                    }
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e) {
                MessageBox.Show(e.Message);
            }
        }


        public void intializeDataGridView()
        {
            dgvNewProduct.Rows.Clear();
            try
            {
                SQL = "SELECT branch.branchName,showcase.showcaseid,Tenant.TenantID FROM showcase, branch, Tenant; ";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                if (myData.HasRows)
                {
                    while (myData.Read())
                    {
                        dgvNewProduct.Rows.Add(myData["branchName"], //Pid
                                               myData["showcaseid"] //Sid
                                              );
                    }
                }
                myData.Close();
                dgvNewProduct.Sort(dgvNewProduct.Columns[0], ListSortDirection.Ascending);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (tbPName.Text != "" && tbPrice.Text != "" && tbqty.Text != "" && tbSId.Text != "")
            {
                if (MessageBox.Show("Do you want to New the product's record?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    SQL = "SELECT Count(productID) AS cPId FROM product WHERE showcaseid = '" + tbSId.Text + "'; ";
                    cmd = new MySqlCommand(SQL, FormContainer.conn);
                    myData = cmd.ExecuteReader();
                    int sequenceNum = 0;

                    while (myData.Read())
                    {
                        sequenceNum = Convert.ToInt32(myData["cPId"]);
                    }
                    myData.Close();

                    String tmpPId = tbSId.Text + sequenceNum.ToString("D3");


                    SQL = "INSERT INTO product " +
                          "VALUES ('" + tmpPId + "','" + tbSId.Text + "','" + tbPName.Text + "','" + tbqty.Text + "','" + tbPrice.Text + "','" + today.ToString("yyyy-MM-dd") + "','" + tbRemark.Text + "');";
                    cmd = new MySqlCommand(SQL, FormContainer.conn);
                    myData = cmd.ExecuteReader();
                    myData.Close();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    this.Close();
                }
            }
            else {
                String errormsg= "Please input \n";
                if(tbPName.Text == "") { errormsg += "Product Name \n" ; }
                if (tbPrice.Text == "") { errormsg += "Price \n"; }
                if (tbqty.Text == "") { errormsg += "Quantity \n"; }
                if (tbSId.Text == "") { errormsg += "Please select showcase \n"; }
                MessageBox.Show(errormsg,"Error");
            }

        }

        private void dgvNewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dgvNewProduct.Rows[e.RowIndex];
                tbSId.Text = row.Cells[1].Value.ToString();
            }
        }
    }
    }

