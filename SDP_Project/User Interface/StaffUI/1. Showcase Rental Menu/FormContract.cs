using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDP_Project.Entity;

namespace SDP_Project
{
    public partial class FormContract : Form
    {
        
        Calendar myCal = CultureInfo.InvariantCulture.Calendar;
        Showcase[] Arrayshowcase;
        double doublediscount;//percentage discount
        int showcaseAmount ;


        public FormContract(Showcase[] Arrayshowcase)
        {
            InitializeComponent();
            this.Arrayshowcase = Arrayshowcase;
            showcaseAmount = Arrayshowcase.Length;
            foreach (Showcase showcase in Arrayshowcase)
                dgvContractList.Rows.Add(showcase.showcaseID, showcase.Rent);

        }


        int rowindex;
        private void dgvContractList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            lblSelectedID.Text = dgvContractList[0, e.RowIndex].Value.ToString();
            }catch(ArgumentOutOfRangeException)
            {
                //undo Evnet
            }
            rowindex = e.RowIndex;
        }//datagridview click event
        private void btnSet_Click(object sender, EventArgs e)
        {
            DateTime Rentalfrom = dateTimePicker1.Value.Date;
            int duration = (int)nudDuration.Value;
            //update datagirdview
            dgvContractList.Rows[rowindex].Cells[3].Value=duration;
            Rentalfrom = new DateTime(Rentalfrom.Year, Rentalfrom.Month, 1);
            dgvContractList.Rows[rowindex].Cells[2].Value = Rentalfrom.ToString("yyyy-MM-dd");
            dgvContractList.Rows[rowindex].Cells[commission.Index].Value = nudCommission.Value;
            calDiscount();
            calCurrentPrice();
            calTotalAmount();
        }
        private void btnSettle_Click(object sender, EventArgs e)
        {
            bool canSettle = true;
            for (int i = 0; i < showcaseAmount; i++)
            {
                if (dgvContractList.Rows[i].Cells[2].Value == null)
                {
                    canSettle = false;
                }
            }

            if (canSettle == true)
            {
                //make new table to store information
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn ac in dgvContractList.Columns)
                    dt.Columns.Add();

                object[] cellValues = new object[dgvContractList.Columns.Count];
                foreach (DataGridViewRow row in dgvContractList.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        cellValues[i] = row.Cells[i].Value;
                    }
                    dt.Rows.Add(cellValues);
                }
                FormSettleContract frmSettleContract = new FormSettleContract(dt);
                frmSettleContract.ShowDialog();
                this.Close();
            }
        }



        public void calDiscount()
        {
            if (Arrayshowcase.Length >= 6)
            {
                doublediscount = 0.1;
            }
            else if (Arrayshowcase.Length >= 3)
            {
                doublediscount = 0.05;
            }
            else
            {
                doublediscount = 0;
            }
            for (int i = 0; i < showcaseAmount; i++)
            {
                 dgvContractList.Rows[i].Cells[4].Value = doublediscount*100;
            }
            lblDiscount.Text = doublediscount*100+"%";
        }
        public void calCurrentPrice()
        {
            double currentprice;
            for(int i = 0; i < showcaseAmount; i++)
            {
                currentprice = (int)dgvContractList.Rows[i].Cells[1].Value * (1-doublediscount);
                dgvContractList.Rows[i].Cells[5].Value = currentprice;
            }
        }
        public void calTotalAmount()
        {
            double totalAmount= 0;
            for (int i = 0; i < showcaseAmount; i++)
            {
                //total+= duration * current price;
                if (dgvContractList.Rows[i].Cells[3].Value != null)
                    totalAmount += (Convert.ToDouble(dgvContractList.Rows[i].Cells[3].Value) * Convert.ToDouble(dgvContractList.Rows[i].Cells[5].Value));
            }
            lblTotal.Text = totalAmount.ToString();
        }

    }
}
