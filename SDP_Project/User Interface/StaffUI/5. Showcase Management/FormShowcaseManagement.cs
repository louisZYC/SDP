using MySql.Data.MySqlClient;
using SDP_Project.Entity;
using SDP_Project.User_Interface.ShowcaseManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Project.User_Interface
{

    public partial class FormShowcaseManagement : Form
    {

        String SQL = "";
        MySqlDataReader myData;
        MySqlCommand cmd;
        List<branch> branchDB = new List<branch>();
        String formID = "";
        String branchName = "";
        DataGridViewBand bandSelected,bandlist;
        DataGridViewRow row;
        public FormShowcaseManagement()
        {

            InitializeComponent();
            getBranchformDB();
            loadCombox();
        }

        private void lblSelectedShowcase_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvSelected_DoubleClick(object sender, EventArgs e)
        {
            //dgvSelected.Remove(lstSelected.SelectedItem);
        }//double click to delete items

        //this is the combobox setted all the branch you can select one to connect to db get the table
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                tbSid.Text = "";
                tbRent.Value = 0;
                cmbCategory.Text = "";
                cbPrivate.Checked = false;
                
                formID = listcontainer(comboBox1.Items[comboBox1.SelectedIndex].ToString());
                branchName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                dgvShowcaseList.Rows.Clear();
                dgvSelected.Rows.Clear();
                //formID = branch id throw it to the function to set the dgv
                initializeShowcaseRecord(formID);
                initializeAvailibility();
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
                comboBox1.Items.Add(b.BranchName);
            }

        }
        public void initializeShowcaseRecord(String id)
        {
            try
            {
                SQL = "select showcaseid,rent,genre,category from showcase WHERE branchid ='" + id + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                    
                    dgvShowcaseList.Rows.Add(myData.GetString(0), myData.GetInt64(1), myData.GetString(2), myData.GetString(3));
                    dgvSelected.Rows.Add(myData.GetString(0), myData.GetInt64(1), myData.GetString(2), myData.GetString(3), id);
                    
                }
                
                myData.Close();
                
                for(int i =0;i< dgvSelected.Rows.Count;i++)
                {
                    bandSelected = dgvSelected.Rows[i];
                    bandSelected.Visible = false;
                }
                tbSid.ResetText();
                tbRent.ResetText();
                cmbCategory.ResetText();
                cbPrivate.Checked=false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }
        public void initializeAvailibility()
        {

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
            }
        }



        private void dgvShowcaseList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                    if (e.RowIndex != -1)
                    {
                        if (dgvShowcaseList[availability.Index, e.RowIndex].Style.BackColor == Color.LimeGreen)
                        {
                            row = this.dgvShowcaseList.Rows[e.RowIndex];
                            String sclSCid = row.Cells[0].Value.ToString();
                            int i = 0;
                            String selectedSCid = "";
                            do
                            {
                                selectedSCid = dgvSelected.Rows[i].Cells[0].Value.ToString();
                                i++;

                            } while (sclSCid != selectedSCid);
                            bandlist = dgvShowcaseList.Rows[e.RowIndex];
                            bandlist.Visible = false;
                            bandSelected = dgvSelected.Rows[i-1];
                            bandSelected.Visible = true;
                            //dgvSelected.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    //cancel event when clicking on column header
                }
            }
        }


        private void dgvSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1) 
            {
                tbSid.Text = "";
                cmbCategory.Text = "";
                row = this.dgvSelected.Rows[e.RowIndex];
                tbSid.Text = row.Cells[0].Value.ToString();
                // tbRent.Value= decimal.Parse(row.Cells[1].Value.ToString());
                String rentS = row.Cells[1].Value.ToString();
                if(row.Cells[2].Value.ToString() == "Private")
                {
                    cbPrivate.Checked = true;
                }
                else
                {
                    cbPrivate.Checked = false;
                }
                tbRent.Value = decimal.Parse(rentS, CultureInfo.InvariantCulture);
                cmbCategory.Text = row.Cells[3].Value.ToString();
            }
        }

        private void tbRent_ValueChanged(object sender, EventArgs e)
        {
            if(row != null)
            row.Cells[1].Value = tbRent.Value;
        }

        private void cbPrivate_CheckedChanged(object sender, EventArgs e)
        {
            if (row != null)
            {

                if (!cbPrivate.Checked)
                {
                    row.Cells[2].Value = "Normal";

                }
                else
                {
                    row.Cells[2].Value = "Private";
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(row != null)
            row.Cells[3].Value = cmbCategory.Items[cmbCategory.SelectedIndex];
        }

        private void sUpdata_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                String supdataSCid, supdataGenre, supdatacategory, supdataBranchid;
                decimal supdataRent;
                supdataSCid = tbSid.Text;
                supdataGenre = row.Cells[2].Value.ToString();
                supdatacategory = cmbCategory.Text;
                supdataRent = tbRent.Value;
                supdataBranchid = row.Cells[4].Value.ToString();
                if (supdataSCid != "")
                {
                    try
                    {
                        SQL = "UPDATE showcase SET rent=" + supdataRent + " ,genre ='" + supdataGenre + "' ,category='" + supdatacategory + "' WHERE showcaseid='" + supdataSCid + "';";

                        cmd = new MySqlCommand(SQL, FormContainer.conn);
                        myData = cmd.ExecuteReader();
                        myData.Close();
                        dgvShowcaseList.Sort(dgvShowcaseList.Columns[0], ListSortDirection.Ascending);
                        //get eachrow visible
                        ArrayList rowVisible = new ArrayList();
                        for (int i = 0; i < dgvShowcaseList.Rows.Count; i++)
                        {
                            DataGridViewBand getVisrow = dgvShowcaseList.Rows[i];
                            rowVisible.Add(getVisrow.Visible);
                        }
                        //reset table
                        dgvShowcaseList.Rows.Clear();
                        //SQL=>select showcaseid,rent,genre,category from showcase WHERE branchid ='branchid';
                        SQL = "select showcaseid,rent,genre,category from showcase WHERE branchid ='" + supdataBranchid + "';";
                        cmd = new MySqlCommand(SQL, FormContainer.conn);
                        myData = cmd.ExecuteReader();
                        while (myData.Read())
                        {

                            dgvShowcaseList.Rows.Add(myData.GetString(0), myData.GetInt64(1), myData.GetString(2), myData.GetString(3));

                        }
                        myData.Close();
                        initializeAvailibility();
                        for (int i = 0; i < dgvShowcaseList.Rows.Count; i++)
                        {
                            DataGridViewBand getVisrow = dgvShowcaseList.Rows[i];
                            getVisrow.Visible = (Boolean)rowVisible[i];
                        }


                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
                    }
                    MessageBox.Show("Showcase:" + supdataSCid + " IN " + branchName + " rent : " + supdataRent + ", genre : " + supdataGenre + ", category : " + supdatacategory + " Is updated");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (formID != "")
            {
                
                decimal supdataRent;
                //SCid=branchid+casecunt+1
                int totalShowcaseint = dgvSelected.Rows.Count + 1;
                String totalShowcase = totalShowcaseint.ToString("000");
                String nform = formID.Substring(0,2);
                
                String gShowcase = nform + totalShowcase;
                supdataRent = tbRent.Value;
                SQL = "INSERT INTO showcase( showcaseid,rent,genre,category,branchid) VALUES('"+ gShowcase + "',0,'Normal','','" + formID+"');";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                myData.Close();
                dgvShowcaseList.Rows.Clear();
                dgvSelected.Rows.Clear();
                initializeShowcaseRecord(formID);
                initializeAvailibility();
            }
        }

        //this is a search funtion
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            String searchtext = tbSearch.Text;
            String curentshowcase = "";
            


            for (int i = 0; i < dgvShowcaseList.Rows.Count; i++)
            {
                bandlist = dgvShowcaseList.Rows[i];
                bandlist.Visible = false;
                
                curentshowcase= dgvSelected.Rows[i].Cells[0].Value.ToString();
                if (curentshowcase.Contains(searchtext))
                {
                    bandlist.Visible = true;
                }
                if(searchtext == "")
                {
                    bandlist.Visible = true;
                }
            }
        }

        private void bUpdata_Click(object sender, EventArgs e)
        {
            String res = "";
            try
            {
                for (int i = 0; i < dgvSelected.Rows.Count; i++)
                {
                    bandSelected = dgvSelected.Rows[i];
                    if (bandSelected.Visible)
                    {
                    
                            row = dgvSelected.Rows[i];
                            SQL = "UPDATE showcase SET rent=" + row.Cells[1].Value.ToString() + " ,genre ='" + row.Cells[2].Value.ToString() + "' ,category='" + row.Cells[3].Value.ToString() + "' WHERE showcaseid='" + row.Cells[0].Value.ToString() + "';";
                            res += "Showcase:" + row.Cells[0].Value.ToString() + " IN " + branchName + " rent : " + row.Cells[1].Value.ToString() + ", genre : " + row.Cells[2].Value.ToString() + ", category : " + row.Cells[3].Value.ToString() + " Is updated \n";
                            cmd = new MySqlCommand(SQL, FormContainer.conn);
                            myData = cmd.ExecuteReader();
                            myData.Close();

                    }
                    
                }

            //reset table
            dgvShowcaseList.Rows.Clear();
            dgvSelected.Rows.Clear();
            initializeShowcaseRecord(formID);
            initializeAvailibility();
            }catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
            MessageBox.Show(res);
        }

        private void dgvSelected_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            row = this.dgvSelected.Rows[e.RowIndex];
            String sclSCid = row.Cells[0].Value.ToString();
            int i = 0;
            String selectedSCid = "";
            do
            {
                selectedSCid = dgvShowcaseList.Rows[i].Cells[0].Value.ToString();
                i++;

            } while (sclSCid != selectedSCid);
            bandlist = dgvShowcaseList.Rows[i-1];
            bandlist.Visible = true;
            bandSelected = dgvSelected.Rows[e.RowIndex];
            bandSelected.Visible = false;
        }
    }
}
