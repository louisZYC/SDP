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
    public partial class FormInventory : Form
    {
        private String SQL = "";
        private MySqlCommand cmd;
        private MySqlDataReader myData;
        public FormInventory()
        {
            InitializeComponent();
        }
        private void FormInventory_Load(object sender, EventArgs e)
        {
            intializeDataGridView();


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];
                tbPId.Text = row.Cells[0].Value.ToString();
                tbSId.Text = row.Cells[1].Value.ToString();
                tbPName.Text = row.Cells[2].Value.ToString();
                tbPAmount.Text = row.Cells[3].Value.ToString();
                tbPrice.Text = row.Cells[4].Value.ToString();
                tbRemark.Text = row.Cells[5].Value.ToString();
            }
        }

        public void intializeDataGridView()
        {
            dgvInventory.Rows.Clear();
            try
            {
                SQL = "select * from product where enable/disable = 0;";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                if (myData.HasRows)
                {
                    while (myData.Read())
                    {
                        dgvInventory.Rows.Add(myData["productid"], //Pid
                                              myData["showcaseid"], //Sid
                                              myData["productName"], //PName
                                              myData["productAmount"], //qty
                                              myData["price"], //Price
                                              myData["Remark"]  //Remark
                                              );
                    }
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int stockin, stockout, cqty;
            stockin = Int16.Parse(tbStockIn.Text);
            stockout = Int16.Parse(tbStockOut.Text);
            cqty = Int16.Parse(tbPAmount.Text);

            if (stockout > cqty)
            {
                MessageBox.Show("Stock-out more than qty,please try again.");
            }
            else
            {
                int newqty = cqty - stockout + stockin;

                SQL = "UPDATE product SET productName ='" + tbPName.Text + "', productAmount ='" + newqty + "', price='" + tbPrice.Text + "', Remark ='"+ tbRemark.Text +"'" +
                    "WHERE productID = '" + tbPId.Text + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                myData.Close();
                intializeDataGridView();
            }
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete record?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SQL = "UPDATE product SET enable/disable = '"+ 1 +"' WHERE productID='" + tbPId.Text + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                myData.Close();
                intializeDataGridView();
            }
            else {
                intializeDataGridView();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            
            dgvInventory.Rows.Clear();
            SQL = "SELECT * FROM product WHERE CONCAT(productID,showcaseid,productName) LIKE '%"+ tbSearch.Text +"%';";
            cmd = new MySqlCommand(SQL, FormContainer.conn);
            myData = cmd.ExecuteReader();

            if (myData.HasRows)
            {
                while (myData.Read())
                {
                    dgvInventory.Rows.Add(myData["productid"], //Pid
                                          myData["showcaseid"], //Sid
                                          myData["productName"], //PName
                                          myData["productAmount"], //qty
                                          myData["price"], //Price
                                          myData["Remark"]  //Remark
                                          );
                }
            }

            myData.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            intializeDataGridView();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormNewProduct FormNewProduct = new FormNewProduct();
            FormNewProduct.Show();
        }
    }
}
