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
using SDP_Project;
using SDP_Project.Entity;

namespace SDP_Project
{
    public partial class FormShowcaseRental : Form
    {

        String SQL = "";
        MySqlDataReader myData;
        MySqlCommand cmd;
        List<branch> branchDB = new List<branch>();
        public FormShowcaseRental()
        {
            InitializeComponent();
        }
        private void FormShowcaseRental_Load(object sender, EventArgs e)
        {
            //fill up datagripview with database;
            initializeShowcaseRecord();
            initializeAvailibility();
            getBranchformDB();
            loadCombox();
        }
        public void initializeAvailibility(){
            

            DateTime today = DateTime.Today;
            foreach (DataGridViewRow row in dgvShowcaseList.Rows)
            {
                try
                {
                    SQL = "select max(date_format(rentto,'%Y-%m-%d')) as 'rentto' from contract where showcaseid = '" + row.Cells[showcaseid.Index].Value.ToString() + "';";
                    cmd = new MySqlCommand(SQL, FormContainer.conn);
                    myData = cmd.ExecuteReader();
                    while (myData.Read())
                    {
                        if (myData["rentto"].ToString() != "")
                        {
                            DateTime rentto = DateTime.Parse(myData["rentto"].ToString());
                            if (DateTime.Compare(today, rentto) > 0) //<0 earlier than, =0 equal to, >0 later than
                            {
                                row.Cells[availability.Index].Style.BackColor = Color.LimeGreen;
                            }
                            else
                            {
                                row.Cells[availability.Index].Style.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            row.Cells[availability.Index].Style.BackColor = Color.LimeGreen;
                        }
                    }
                    myData.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
                }
                catch (NullReferenceException)
                {
                    //undo
                }
            }
        }//get availibility for showcase
        public void initializeShowcaseRecord()
        {
            try
            {
                SQL = "select * from showcase";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                int i = 0;
                while (myData.Read())
                {
                    dgvShowcaseList.Rows.Add();
                    dgvShowcaseList.Rows[i].Cells[showcaseid.Index].Value = myData["showcaseid"];
                    dgvShowcaseList.Rows[i].Cells[rent.Index].Value = myData["rent"];
                    dgvShowcaseList.Rows[i].Cells[genre.Index].Value = myData["genre"];
                    dgvShowcaseList.Rows[i].Cells[category.Index].Value = myData["category"];
                    dgvShowcaseList.Rows[i].Cells[branchid.Index].Value = myData["branchid"];
                    i++;
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }//load showcase record's data in datagripview

        public void initializeShowcaseRecord(String shopid)
        {
            try
            {
                SQL = "select * from showcase  WHERE branchid ='" + shopid + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                int i = 0;
                while (myData.Read())
                {
                    dgvShowcaseList.Rows.Add();
                    dgvShowcaseList.Rows[i].Cells[showcaseid.Index].Value = myData["showcaseid"];
                    dgvShowcaseList.Rows[i].Cells[rent.Index].Value = myData["rent"];
                    dgvShowcaseList.Rows[i].Cells[genre.Index].Value = myData["genre"];
                    dgvShowcaseList.Rows[i].Cells[category.Index].Value = myData["category"];
                    dgvShowcaseList.Rows[i].Cells[branchid.Index].Value = myData["branchid"];
                    i++;
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }//load showcase record's data in datagripview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string showcaseIDselected;
            string colname;
            try
            {
                showcaseIDselected = dgvShowcaseList[0, e.RowIndex].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                showcaseIDselected = null;
            }
            colname = dgvShowcaseList.Columns[e.ColumnIndex].Name;
            if (colname == "Select")
            {
                try
                {
                    if (!lstSelected.Items.Contains(showcaseIDselected)&& dgvShowcaseList[availability.Index, e.RowIndex].Style.BackColor == Color.LimeGreen)
                    {
                        lstSelected.Items.Add(showcaseIDselected);
                    }
                }
                catch (ArgumentNullException)
                {
                    //cancel event when clicking on column header
                }
            }


        }//add showcase to shopping cart
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Boolean canConfirm = true;
            if (lstSelected.Items.Count == 0)
            {
                canConfirm = false;
            }

            if (canConfirm == true)
            {
                Showcase[] Arrayshowcase = new Showcase[lstSelected.Items.Count];
                for (int i = 0; i < lstSelected.Items.Count; i++)
                {
                    MySqlCommand cmd = new MySqlCommand("select * from showcase where showcaseid = '" + lstSelected.Items[i].ToString() + "'", FormContainer.conn);
                    MySqlDataReader myData = cmd.ExecuteReader();
                    while (myData.Read())
                    {
                        Arrayshowcase[i] = new Showcase(myData.GetString(0), myData.GetInt32(1));//Index:0 is ID, Index:1 is rent                
                    }
                    myData.Close();
                }
                FormContract frmContract = new FormContract(Arrayshowcase);
                frmContract.ShowDialog();
                lstSelected.Items.Clear();
                initializeAvailibility();
            }
        }//click on  confirm button to prepare contract
        private void lstSelected_DoubleClick(object sender, EventArgs e)
        {
            lstSelected.Items.Remove(lstSelected.SelectedItem);
        }//double click to delete items

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

        private void cmbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String shopID = listcontainer(cmbShop.Items[cmbShop.SelectedIndex].ToString());
            dgvShowcaseList.Rows.Clear();
            initializeShowcaseRecord(shopID);
            initializeAvailibility();
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
    }
}
