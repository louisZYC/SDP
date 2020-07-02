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
using SDP_Project.Entity;

namespace SDP_Project.User_Interface
{
    public partial class FormCustomerSalesManagement : Form
    {
        private String SQL = "";
        private MySqlCommand cmd;
        private MySqlDataReader myData;
        FormShoppingCart frmShoppingCart;
        String shopID;
        List<branch> branchDB;
        List<SalesItem> shoppingCart;//List<> is similiar with Linkedlist
        public FormCustomerSalesManagement()
        {
            InitializeComponent();
            shoppingCart = new List<SalesItem>();
            branchDB = new List<branch>();
        }

        #region event handler
        private void FormCustomerSalesManagement_Load(object sender, EventArgs e)
        {
            getBranchformDB();
            loadCombox();
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            String colname = dgvProductList.Columns[e.ColumnIndex].Name;
            if (colname == "select")
            {
                try
                {
                    Boolean isInvalidAmountInput = true;
                    Boolean hasDiscount = false;
                    Boolean isInvalidDiscountInput = false;
                    //initialize salesitem information
                    int Amount;
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Input quantity", "Title", "");
                    if (int.TryParse(input, out Amount) == true)
                    {
                        isInvalidAmountInput = false;
                    }
                    int Discount;
                    if (dgvProductList.Rows[rowindex].Cells[remark.Index].Value.ToString() != "")
                    {
                        hasDiscount = true;
                    }
                    if (hasDiscount == true)
                    {
                        input = Microsoft.VisualBasic.Interaction.InputBox(dgvProductList.Rows[rowindex].Cells[remark.Index].Value.ToString() + "\nPlease input integer discount", "Title", "");
                        if (int.TryParse(input, out Discount) != true)
                        {
                            isInvalidDiscountInput = true;
                        }
                    }
                    else
                    {
                        Discount = 0;
                    }
                    String Productid = dgvProductList.Rows[rowindex].Cells[productid.Index].Value.ToString();
                    String ProductName = dgvProductList.Rows[rowindex].Cells[productname.Index].Value.ToString();
                    decimal Price = Convert.ToDecimal(dgvProductList.Rows[rowindex].Cells[price.Index].Value);

                    if (shoppingCart.Contains(new SalesItem { productid = Productid }))
                    {
                        MessageBox.Show("This product has been already added into shopping cart");
                    }
                    else if (isInvalidAmountInput == true)
                    {
                        MessageBox.Show("Invalid amount input");
                    }
                    else if (isInvalidDiscountInput == true)
                    {
                        MessageBox.Show("Invalid discount input");
                    }
                    else
                    {
                        SalesItem salesitem = new SalesItem { amount = Amount, productid = Productid, productname = ProductName, price = Price, discount = Discount };
                        shoppingCart.Add(salesitem);
                    }
                }
                catch (ArgumentNullException)
                {
                    //undo event
                }
            }
        }
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            frmShoppingCart = new FormShoppingCart(this, shoppingCart);
            frmShoppingCart.ShowDialog();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String prodID = txtProductID.Text;
            String showcaseID = txtShowcaseID.Text;
            //searchByProdID(shopID, prodID);
            searchByshowcaseID(shopID,showcaseID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShowcaseID.Text = String.Empty;
            txtProductID.Text = String.Empty;
            intializeDataGridView(shopID);
        }

        #endregion
        public void OnPaymentSettled()
        {
            shoppingCart.Clear();
            intializeDataGridView(shopID);
        }

        public void intializeDataGridView(String shopID)
        {
            dgvProductList.Rows.Clear();
            try
            {
                SQL = "select p.productID, p.showcaseid, p.productName,p.productAmount,p.price,p.Remark from product as p inner join showcase as s on p.showcaseid = s.showcaseid where productAmount >=0 and s.branchid ='" + shopID + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                if (myData.HasRows)
                {
                    while (myData.Read())
                    {
                        dgvProductList.Rows.Add(myData["productid"], myData["showcaseid"], myData["productName"], myData["productamount"], myData["price"], myData["remark"]);
                    }
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }

        public void searchByProdID(String shopID, String prodID)
        {
            dgvProductList.Rows.Clear();
            bool isEmptyprodID = true;
            if (prodID.Trim().Length > 0)
            {
                isEmptyprodID = false;
            }

            if (isEmptyprodID == false)
            {

                try
                {
                    SQL = "select p.productID, p.showcaseid, p.productName,p.productAmount,p.price,p.Remark from product as p inner join showcase as s on p.showcaseid = s.showcaseid where productAmount >=0 and s.branchid ='" + shopID + "' and productID = '" + prodID + "';";
                    cmd = new MySqlCommand(SQL, FormContainer.conn);
                    myData = cmd.ExecuteReader();
                    if (myData.HasRows)
                    {
                        dgvProductList.Rows.Clear();
                        while (myData.Read())
                        {
                            dgvProductList.Rows.Add(myData["productid"], myData["showcaseid"], myData["productName"], myData["productamount"], myData["price"], myData["remark"]);
                        }
                    }
                    myData.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
                }

            }
        }
        public void searchByshowcaseID(String shopID, String showcaseID)
        {
            bool isEmpty = true;
            if (showcaseID.Trim().Length > 0)
            {
                isEmpty = false;
            }

            if (isEmpty == false)
            {

                try
                {
                    SQL = "select p.productID, p.showcaseid, p.productName,p.productAmount,p.price,p.Remark from product as p inner join showcase as s on p.showcaseid = s.showcaseid where productAmount >=0 and s.branchid ='" + shopID + "' and p.showcaseid = '" + showcaseID + "';";
                    cmd = new MySqlCommand(SQL, FormContainer.conn);
                    myData = cmd.ExecuteReader();
                    if (myData.HasRows)
                    {
                        dgvProductList.Rows.Clear();
                        while (myData.Read())
                        {
                            dgvProductList.Rows.Add(myData["productid"], myData["showcaseid"], myData["productName"], myData["productamount"], myData["price"], myData["remark"]);
                        }
                    }
                    myData.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
                }

            }
        }

        #region showcase management methods
        public void getBranchformDB()
        {
            try
            {
                SQL = "select * from branch";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                    branchDB.Add(new branch(myData["branchid"].ToString(), (int)myData["showcaseNum"], myData["branchName"].ToString()));
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }

        public void loadCombox()
        {
            foreach (branch b in branchDB)
            {
                cmbShop.Items.Add(b.BranchName);
            }

        }


        private void cmbShop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            shopID = listcontainer(cmbShop.Items[cmbShop.SelectedIndex].ToString());
            dgvProductList.Rows.Clear();
            intializeDataGridView(shopID);
        }
        public String listcontainer(String other)
        {
            foreach (branch b in branchDB)
            {
                if (b.BranchName == other)
                {
                    return b.Branchid;
                }

            }
            return "";
        }


        #endregion

    }
}
