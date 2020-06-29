using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDP_Project.Entity;
using SDP_Project.User_Interface;

namespace SDP_Project
{
    public partial class FormChashier : Form
    {
        FormShoppingCart frmParent;
        List<SalesItem> shoppingcart;
        String SalesRecordID;
        public FormChashier(List<SalesItem> shoppingcart,FormShoppingCart frmParent,String SalesRecordID)
        {
            InitializeComponent();
            this.shoppingcart = shoppingcart;
            this.frmParent = frmParent;
            this.SalesRecordID = SalesRecordID;
        }

        private void FormChashier_Load(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach(SalesItem s in shoppingcart)
            {
                total += s.calTotal();
            }
            lblTotal.Text = total.ToString();
        }
        private void mtxtCashTendered_TextChanged(object sender, EventArgs e)
        {
            try { 
            lblChange.Text = (Convert.ToInt32(lblTotal.Text) - Convert.ToInt32(mtxtCashTendered.Text)).ToString();
            }
            catch (FormatException)
            {
                //undo
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            decimal tendered = Convert.ToDecimal(mtxtCashTendered.Text);
            frmParent.onChashierFinished(tendered);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
