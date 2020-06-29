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

namespace SDP_Project.User_Interface
{
    public partial class FormRentalRecord : Form
    {
        private String SQL = "";
        private MySqlCommand cmd;
        private MySqlDataReader myData;
        private StaffUI staffui;
        List<contract> contractList;
        public FormRentalRecord(StaffUI staffui)
        {
            InitializeComponent();
            this.staffui = staffui;
            contractList = new List<contract>();
        }

        private void FormRentalRecord_Load(object sender, EventArgs e)
        {
            intializeDataGridView();
        }

        int rowindex;
        private void dgvRentalRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colname = dgvRentalRecord.Columns[e.ColumnIndex].Name;
            if (colname == "select")
            {
                try
                {
                    lblContractID.Text = dgvRentalRecord[0, e.RowIndex].Value.ToString();
                }
                catch (ArgumentOutOfRangeException)
                {
                    //undo Evnet
                }
                rowindex = e.RowIndex;
            }

            if (colname == "monthly")
            {
                try
                {
                    String showcaseID = dgvRentalRecord[showcaseid.Index, e.RowIndex].Value.ToString();
                    if (!lstMonthly.Items.Contains(showcaseID))
                        lstMonthly.Items.Add(dgvRentalRecord[showcaseid.Index, e.RowIndex].Value.ToString());
                }
                catch (ArgumentOutOfRangeException)
                {
                    //undo Evnet
                }
            }
        } //dgv select and monthly column event

        public void updateDataBase_RentTo(DateTime newDate, int rowindex)
        {
            try
            {
                SQL = "update contract set rentto = '" + newDate.ToString("yyyy-MM-dd") + "' where contractid = '" + dgvRentalRecord.Rows[rowindex].Cells[contractid.Index].Value.ToString() + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
            MessageBox.Show("Success");
        } //update db

        public void intializeDataGridView()
        {
            dgvRentalRecord.Rows.Clear();
            try
            {
                SQL = "select * from contract where RentTo >=now()";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                    dgvRentalRecord.Rows.Add(myData["contractID"], myData["showcaseid"], myData["tenantid"], Convert.ToDateTime(myData["RentFrom"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(myData["RentTo"]).ToString("yyyy-MM-dd"), Convert.ToDouble(myData["discount"]) * 100);

                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }// db select * from contract


        private void lstMonthly_DoubleClick(object sender, EventArgs e)
        {
            lstMonthly.Items.Remove(lstMonthly.SelectedItem);
        } //double click to delete

        #region declare List<contract>
        private void initializeContractList()
        {
            for (int i = 0; i < lstMonthly.Items.Count; i++)
            {
                initializeContract(lstMonthly.Items[i].ToString());
            }
        } //initialize List<contract>

        private void initializeContract(String showcaseid)
        {
            try
            {
                SQL = "select * from contract as c inner join showcase as s on s.showcaseid = c.showcaseid where c.showcaseid = '" + showcaseid + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                if (myData.HasRows)
                {
                    while (myData.Read())
                    {
                        contractList.Add(new contract
                        {
                            contractID = myData["contractID"].ToString(),
                            showcaseID = myData["showcaseid"].ToString(),
                            tenantID = myData["tenantid"].ToString(),
                            RentFrom = Convert.ToDateTime(myData["RentFrom"]),
                            RentTo = Convert.ToDateTime(myData["RentTo"]),
                            discount = Convert.ToDouble(myData["discount"]),
                            commission = Convert.ToDouble(myData["commission"]),
                            rent = Convert.ToDouble(myData["rent"])
                        });
                    }
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        } // initialzie contract obj

        private void onChildClosed()
        {
            contractList.Clear();
            lstMonthly.Items.Clear();
        }

        #endregion

        #region button event
        private void btnOne_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataGridViewRow row in dgvRentalRecord.Rows) { 
                String showcaseID = dgvRentalRecord[showcaseid.Index, row.Index].Value.ToString();
                if (!lstMonthly.Items.Contains(showcaseID))
                    lstMonthly.Items.Add(dgvRentalRecord[showcaseid.Index, row.Index].Value.ToString());
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //undo Evnet
            }
        } //one-click selection

        private void btnNext_Click(object sender, EventArgs e)
        {
            Boolean canGenerate = true;
            if (lstMonthly.Items.Count == 0)
            {
                canGenerate = false;
            }

            if (canGenerate == true)
            {
                initializeContractList();
                FormGenerateMonthlyStatement frmGenerate = new FormGenerateMonthlyStatement(contractList);
                frmGenerate.ShowDialog();
                onChildClosed();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime newDate = dtpRentTo.Value.Date;
                newDate = new DateTime(newDate.Year, newDate.Month, DateTime.DaysInMonth(newDate.Year, newDate.Month));//turn to last day of the month
                updateDataBase_RentTo(newDate, rowindex);
                intializeDataGridView();
                initializeAvailibility();
            }

        } // Confirm Change

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvRentalRecord.Rows.Clear();
            try
            {
                SQL = "select * from contract";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                    dgvRentalRecord.Rows.Add(myData["contractID"], myData["showcaseid"], myData["tenantid"], Convert.ToDateTime(myData["RentFrom"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(myData["RentTo"]).ToString("yyyy-MM-dd"), Convert.ToDouble(myData["discount"]) * 100);

                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            intializeDataGridView();
        }
        #endregion

        #region callback()
        public void initializeAvailibility()
        {
            staffui.initializeAvailibility();
        }  //onContract.RentToChanged

        #endregion

    }
}
