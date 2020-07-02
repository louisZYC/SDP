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

namespace SDP_Project
{
    public partial class FormSalesItems : Form
    {
        salesrecord salesrecord;
        public FormSalesItems(salesrecord salesrecord)
        {
            InitializeComponent();
            this.salesrecord = salesrecord;
        }

        private void FormSalesItems_Load(object sender, EventArgs e)
        {
            initializeDgvSalesItems();
        }

        public void initializeDgvSalesItems()
        {
            for(int i = 0; i < salesrecord._salesitems.Count; i++)
            {
                dgvSalesItems.Rows.Add();
                dgvSalesItems.Rows[i].Cells[name.Index].Value = salesrecord._salesitems[i].productname;
                dgvSalesItems.Rows[i].Cells[quantity.Index].Value = salesrecord._salesitems[i].amount;
                dgvSalesItems.Rows[i].Cells[discount.Index].Value = salesrecord._salesitems[i].discount;
                dgvSalesItems.Rows[i].Cells[unitprice.Index].Value = salesrecord._salesitems[i].price;
                dgvSalesItems.Rows[i].Cells[totalamount.Index].Value = salesrecord._salesitems[i].calTotal();
            }
            
        }
    }
}
