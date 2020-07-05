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
using MySql.Data.MySqlClient;
using SDP_Project.Controller;
using MySql.Data;




namespace SDP_Project
{
    public partial class FormSalesRecord : Form
    {
        private String SQL = "";
        private MySqlCommand cmd;
        private MySqlDataReader myData;
        String shopID;
        FormSalesItems frmSalesItems;
        List<salesrecord> _salesrecords;
        List<branch> branchDB;
        public FormSalesRecord()
        {
            InitializeComponent();
            _salesrecords = new List<salesrecord>();
            branchDB = new List<branch>();
        }


        private void FormSalesRecord_Load(object sender, EventArgs e)
        {
            getBranchformDB();
            loadCombox();
            getListofSalesrecords();
        }

        #region showcasemanagement methods
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

        private void cmbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            shopID = listcontainer(cmbShop.Items[cmbShop.SelectedIndex].ToString());
            loadDgvSalesRecords(shopID);

        }


        #endregion

        public void getListofSalesrecords()
        {
            _salesrecords = ListManager.loadSalesrecords();
        }

        public void loadDgvSalesRecords(String shopID) {
            dgvSalesRecord.Rows.Clear();

            

            List<salesrecord> salesrecords = new List<salesrecord>();
            salesrecords = _salesrecords.Where(x => x.branchid.Equals(shopID)).ToList();
            for (int i = 0; i < salesrecords.Count; i++)
            {
                dgvSalesRecord.Rows.Add();
                dgvSalesRecord.Rows[i].Cells[salesrecordid.Index].Value = salesrecords[i].salesrecordID;
                dgvSalesRecord.Rows[i].Cells[staffid.Index].Value = salesrecords[i].staffID;
                dgvSalesRecord.Rows[i].Cells[salesdate.Index].Value = salesrecords[i].salesdate;
                dgvSalesRecord.Rows[i].Cells[totalamount.Index].Value = salesrecords[i].getTotalAmount();
            }
            salesrecords = null;
            getTotalsales();
        }

        public void filterByMonth(String shopID)
        {
            dgvSalesRecord.Rows.Clear();
            DateTime dtpValue = dtpMonth.Value;
            DateTime startOfMonth = new DateTime(dtpValue.Year, dtpValue.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            List<salesrecord> salesrecords = new List<salesrecord>();
            salesrecords = _salesrecords.Where(x => x.salesdate.CompareTo(startOfMonth)>=0 && x.salesdate.CompareTo(endOfMonth)<=0).ToList();
            for (int i = 0; i < salesrecords.Count; i++)
            {
                dgvSalesRecord.Rows.Add();
                dgvSalesRecord.Rows[i].Cells[salesrecordid.Index].Value = salesrecords[i].salesrecordID;
                dgvSalesRecord.Rows[i].Cells[staffid.Index].Value = salesrecords[i].staffID;
                dgvSalesRecord.Rows[i].Cells[salesdate.Index].Value = salesrecords[i].salesdate;
                dgvSalesRecord.Rows[i].Cells[totalamount.Index].Value = salesrecords[i].getTotalAmount();
            }
            salesrecords = null;
            getTotalsales();
        }

        public void filterByDay(String shopID)
        {
            dgvSalesRecord.Rows.Clear();
            DateTime dtpValue = dtpDay.Value;
            DateTime startOfDay = new DateTime(dtpValue.Year, dtpValue.Month, dtpValue.Day,0,0,0);
            DateTime endOfDay = startOfDay.AddDays(1).AddSeconds(-1);

            List<salesrecord> salesrecords = new List<salesrecord>();
            salesrecords = _salesrecords.Where(x => x.salesdate.CompareTo(startOfDay) >= 0 && x.salesdate.CompareTo(endOfDay) <= 0).ToList();
            for (int i = 0; i < salesrecords.Count; i++)
            {
                dgvSalesRecord.Rows.Add();
                dgvSalesRecord.Rows[i].Cells[salesrecordid.Index].Value = salesrecords[i].salesrecordID;
                dgvSalesRecord.Rows[i].Cells[staffid.Index].Value = salesrecords[i].staffID;
                dgvSalesRecord.Rows[i].Cells[salesdate.Index].Value = salesrecords[i].salesdate;
                dgvSalesRecord.Rows[i].Cells[totalamount.Index].Value = salesrecords[i].getTotalAmount();
            }
            salesrecords = null;
            getTotalsales();
        }


        private void dgvSalesRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colname = dgvSalesRecord.Columns[e.ColumnIndex].Name;
            if (colname == "details")
            {
                try
                {
                    String salesrecordID = dgvSalesRecord.Rows[e.RowIndex].Cells[salesrecordid.Index].Value.ToString();
                    List<salesrecord> salesrecords = _salesrecords.Where(x => x.salesrecordID.Equals(salesrecordID)).ToList();
                    salesrecord salesrecord = salesrecords[0];
                    frmSalesItems = new FormSalesItems(salesrecord);
                    frmSalesItems.ShowDialog();
                }
                catch (ArgumentOutOfRangeException)
                {
                    //undo Evnet
                }
            }

            
        }

        public void getTotalsales()
        {
            decimal totalsales = 0;
            foreach(DataGridViewRow r in dgvSalesRecord.Rows)
            {
                totalsales += (decimal)r.Cells[totalamount.Index].Value;
            }
            lblTotal.Text = totalsales.ToString();
        }

        private void btnMonthfilter_Click(object sender, EventArgs e)
        {
            if(shopID != null)
            filterByMonth(shopID);
        }

        private void btnDayfilter_Click(object sender, EventArgs e)
        {
            if (shopID != null)
                filterByDay(shopID);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getListofSalesrecords();
            if(shopID!=null)
            loadDgvSalesRecords(shopID);
        }

        public void refreshdgv()
        {
            getListofSalesrecords();
            if (shopID != null)
                loadDgvSalesRecords(shopID);
        }
    }
}
