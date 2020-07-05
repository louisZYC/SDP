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
using SDP_Project.Entity;
using SDP_Project;

namespace SDP_Project.User_Interface
{
    public partial class FormShoppingCart : Form
    {

        List<SalesItem> shoppingcart;
        String SQL = "";
        MySqlDataReader myData;
        MySqlCommand cmd;
        FormCustomerSalesManagement frmCSM;
        DateTime today;
        String SalesRecordID;
        decimal cashTendered = 0;
        //delegate


        public FormShoppingCart(FormCustomerSalesManagement frmCSM,List<SalesItem> shoppingcart)
        {
            InitializeComponent();
            this.shoppingcart = shoppingcart;
            today = DateTime.Today;
            SalesRecordID = generateSalesRecordID();
            this.frmCSM = frmCSM;
        } //constructor 

        private void FormShoppingCart_Load(object sender, EventArgs e)
        {
            initializeDataGridView();
            calTotalAmount();
            calSubtotal();
            calTotalDiscount();
            lblSalesRecordID.Text = SalesRecordID;
        }

        #region Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }//button Close shopping cart

        private void dgvShoppingCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvShoppingCart.Columns[e.ColumnIndex].Name == "remove")
            {
                try
                {
                    String RemovedProductid = dgvShoppingCart.Rows[e.RowIndex].Cells[productid.Index].Value.ToString();
                    shoppingcart.Remove(new SalesItem() { productid = RemovedProductid });
                }
                catch (ArgumentNullException ex)
                {
                    //undo event
                }
            }
            initializeDataGridView();
            calTotalAmount();
            calSubtotal();
            calTotalDiscount();
        }//Remove from shopping cart

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            if (checkisEmptyshoppingCart() == true)
            {
                MessageBox.Show("The shopping car has no item!");
            }
            else
            {
                FormChashier frmChashier = new FormChashier(shoppingcart, this,SalesRecordID);
                if (frmChashier.ShowDialog(this) == DialogResult.OK)
                {
                    DateTime now = DateTime.Now;
                    updateDatabase_SalesRecord(SalesRecordID, StaffUI.staff.getStaffID(), now.ToString("yyyy-MM-dd HH:mm:ss"));
                    foreach (SalesItem item in shoppingcart)
                    {
                        String productid = item.productid;
                        String salesrecordid = SalesRecordID;
                        int quantity = item.amount;
                        int discount = item.discount;
                        decimal unitprice = item.price;
                        decimal total = item.calTotal();
                        String productname = item.productname;
                        updataDatabase_SalesItem(productid, salesrecordid, productname, quantity, discount, total, unitprice);
                        updateDatabase_product_amount(quantity, productid);
                    }
                    MessageBox.Show("Success!");
                    //create receipt
                    FormReceipt frmReceipt = new FormReceipt(shoppingcart, SalesRecordID, cashTendered);
                    frmReceipt.ShowDialog();
                    //callback method
                    frmCSM.OnPaymentSettled();
                    
                    this.Close();
                }
            }

        }//button SettlePayment
        #endregion

        private void initializeDataGridView()
        {
            dgvShoppingCart.Rows.Clear();
            for (int i = 0; i < shoppingcart.Count(); i++)
            {
                dgvShoppingCart.Rows.Add();
                dgvShoppingCart.Rows[i].Cells[productid.Index].Value = shoppingcart[i].productid;
                dgvShoppingCart.Rows[i].Cells[productname.Index].Value = shoppingcart[i].productname;
                dgvShoppingCart.Rows[i].Cells[quantity.Index].Value = shoppingcart[i].amount;
                dgvShoppingCart.Rows[i].Cells[unitprice.Index].Value = shoppingcart[i].price;
                dgvShoppingCart.Rows[i].Cells[discount.Index].Value = shoppingcart[i].discount;
                dgvShoppingCart.Rows[i].Cells[total.Index].Value = shoppingcart[i].calTotal();
            }
        } //clear and then load data in datagripview

        #region calculate amount
        public decimal calTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (SalesItem salesitem in shoppingcart)
            {
                totalAmount += salesitem.calTotal();
            }
            lblTotalAmount.Text = totalAmount.ToString();
            return totalAmount;
        } //calculate total amount

        public decimal calTotalDiscount()
        {
            decimal totalDisountAmount = 0;
            foreach (SalesItem salesitem in shoppingcart)
            {
                totalDisountAmount += salesitem.discount;
            }
            lblDiscount.Text = totalDisountAmount.ToString();
            return totalDisountAmount;
        }//calculate total discount
        public decimal calSubtotal()
        {
            decimal subtotal = 0;
            foreach (SalesItem salesitem in shoppingcart)
            {
                subtotal += salesitem.calSubTotal();
            }
            lblSubTotal.Text = subtotal.ToString();
            return subtotal;
        }//calculate subtotal
        #endregion


        #region Generate sales recordID
        public String generateSalesRecordID()
        {
            int SequenceNumber = generateSequenceNumber_SalesRecordID();
            String generateSalesRecordID = today.ToString("yyyyMMdd") + SequenceNumber.ToString("D4");
            return generateSalesRecordID;
        } //automaticly generate salesrecord ID
        public int generateSequenceNumber_SalesRecordID()
        {
            String date = today.ToString("yyyyMMdd");
            int SequenceNumber = 0;
            try
            {
                SQL = "select count(salesrecordid) as amount from SalesRecord where salesrecordid like'" + date + "%';";
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
        } //automaticly generate sequencenumber to form a salesrecord ID
        #endregion

        #region update database
        public void updateDatabase_SalesRecord(String salesrecordID, String staffid, String salesdate)
        {
            try
            {
                SQL = "insert into SalesRecord(salesrecordid, staffid, salesdate) values ('" + salesrecordID + "','" + staffid + "','" + salesdate + "');";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        } //insert record into salesrecord table

        public void updateDatabase_product_amount(int soldQuantity,String productid)
        {
            try
            {
                int productAmount = 0;
                SQL = "select productAmount from product where productID = '" + productid + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                    productAmount = Convert.ToInt32(myData["productAmount"]);
                }
                myData.Close();

                int newAmount = productAmount - soldQuantity;
                SQL = "update product set productAmount = " + newAmount + " where productID = '"+productid+"';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }

        public void updataDatabase_SalesItem(String productid, String salesrecordid,String productname, int quantity, int discount,decimal total,decimal price)
        {
            try
            {
                SQL = "insert into SalesItem(productID, salesrecordID,productName,Quantity,discount,total,price) values ('" + productid + "','" + salesrecordid + "','"+productname+"'," + quantity + "," + discount + ","+total+","+price+");";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }

        }//insert into Sales Item table
        #endregion
        public bool checkisEmptyshoppingCart()
        {
            return dgvShoppingCart.Rows.Count <= 0;
        }

        public void onChashierFinished( decimal tendered)
        {
            cashTendered = tendered;
        }
    }
}
