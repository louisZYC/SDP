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

namespace SDP_Project
{

    public partial class FormGenerateMonthlyStatement : Form
    {
        List<contract> contractList;
        List<tenant> tenantList;
        private String SQL = "";
        private MySqlCommand cmd;
        private MySqlDataReader myData;
        public FormGenerateMonthlyStatement(List<contract> contractList)
        {
            InitializeComponent();
            this.contractList = contractList;
            tenantList = new List<tenant>();
        }

        private void FormGenerateMonthlyStatement_Load(object sender, EventArgs e)
        {
            initializeTenantList(contractList);
            contractAppendTenant();
            loaddgvTenant();
            dtpPeriod.Value = DateTime.Today.AddMonths(1);
        }


        private void initializeTenantList(List<contract> contractList)
        {
            foreach (contract c in contractList)
            {
                try
                {
                    SQL = "select * from Tenant where TenantID = '" + c.tenantID + "';";
                    cmd = new MySqlCommand(SQL, FormContainer.conn);
                    myData = cmd.ExecuteReader();
                    if (myData.HasRows)
                    {
                        while (myData.Read())
                        {
                            tenantList.Add(new tenant
                            {
                                tenantid = myData["TenantID"].ToString(),
                                name = myData["Name"].ToString(),
                                phonenumber = Convert.ToInt32(myData["PhoneNumber"]),
                                prepaid = Convert.ToDecimal(myData["prepaid"])
                            });
                        }
                    }
                    myData.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
                }
            }

        } // initialzie tenantList


        private void contractAppendTenant()
        {
            int i = 0;
            foreach (contract c in contractList)
            {
                c.tenant = null;
                c.tenant = tenantList[i];
                i++;
            }
        }  //contractList append tennat obj

        private void loaddgvTenant()
        {
            for (int i = 0; i < tenantList.Count(); i++)
            {
                dgvTenant.Rows.Add();
                dgvTenant.Rows[i].Cells["showcaseid"].Value = contractList[i].showcaseID;
                dgvTenant.Rows[i].Cells["tenantid"].Value = contractList[i].tenant.tenantid;
                dgvTenant.Rows[i].Cells["tenantname"].Value = contractList[i].tenant.name;
                dgvTenant.Rows[i].Cells["telephone"].Value = contractList[i].tenant.phonenumber;
            }

        } // load dgv tenant

        private void dgvTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colname = dgvTenant.Columns[e.ColumnIndex].Name;
            DateTime period = dtpPeriod.Value;
            if (colname == "generate" && e.RowIndex >= 0)
            {
                FormMonthlyStatement frmMonthlyStatement = new FormMonthlyStatement(contractList[e.RowIndex], period);
                frmMonthlyStatement.ShowDialog();
            }
        } //click on dgv to generate 

    }
}
