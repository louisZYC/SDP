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
        FormInventory frm;
        public FormNewProduct(FormInventory frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        
        private void FormNewProduct_Load(object sender, EventArgs e)
        {


        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (tbPName.Text != "" && tbPrice.Text != "" && tbqty.Text != "" && tbSId.Text != "")
            {
                string[] row = {tbSId.Text, tbPName.Text , tbqty.Text ,tbPrice.Text,tbRemark.Text};
                dgvNewall.Rows.Add(row);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNewall.SelectedRows)
            {
                dgvNewall.Rows.RemoveAt(row.Index);
            }
        }

        private void dgvNewall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvNewall.Rows.Count; i++)
            {
                String tmpSId = dgvNewall.Rows[i].Cells[0].Value.ToString();
                SQL = "SELECT Count(productID) AS cPId FROM product WHERE showcaseid = '" + tmpSId + "'; ";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                int sequenceNum = 0;

                while (myData.Read())
                {
                    sequenceNum = Convert.ToInt32(myData["cPId"]);
                }
                myData.Close();

                String tmpPId = tmpSId + sequenceNum.ToString("D3");
                String PName = dgvNewall.Rows[i].Cells[1].Value.ToString();
                String Qty = dgvNewall.Rows[i].Cells[2].Value.ToString();
                String Price = dgvNewall.Rows[i].Cells[3].Value.ToString();
                String Remark = dgvNewall.Rows[i].Cells[4].Value.ToString();
                Int16 showit = 0;



                SQL = "INSERT INTO product " +
                      "VALUES ('" + tmpPId + "','" + 
                                    tmpSId + "','" + 
                                    PName + "','" + 
                                    Qty + "','" + 
                                    Price + "','" + 
                                    today.ToString("yyyy-MM-dd") + "','" + 
                                    Remark + "',"+
                                    showit +
                                    ");";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                myData.Close();
            }
            frm.intializeDataGridView();
            this.Close();
        }
    }
    }

