using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using SDP_Project.Entity;

namespace SDP_Project
{
    public partial class FormMonthlyStatement : Form
    {
        String SQL = "";
        MySqlDataReader myData;
        MySqlCommand cmd;
        contract contract;
        DateTime period;
        List<SalesItem> salesItems;
        DateTime endOfMonth;
        DateTime startOfMonth;
        public FormMonthlyStatement(contract contract, DateTime Rentalperiod)
        {
            InitializeComponent();
            this.contract = contract;
            this.period = Rentalperiod;
            salesItems = new List<SalesItem>();
            
        }

        private void FormMonthlyStatement_Load(object sender, EventArgs e)
        {
            //initialize salesItemList
            initializeSalesItemsList();
            contractBindSalesItemsList();

            //load report
            loadReport();
            this.reportViewer1.RefreshReport();
        }

        public void loadReport()
        {
            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSetMonthlyStatement datasetmonthlystatement = new DataSetMonthlyStatement();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();

                //fill data set
                /* declare start and end of period of salesrecord*/
                endOfMonth = (new DateTime(period.Year, period.Month, DateTime.DaysInMonth(period.Year, period.Month))).AddMonths(-1);
                startOfMonth = (new DateTime(period.Year, period.Month, 1)).AddMonths(-1);
                SQL = "select DATE_FORMAT(sr.salesdate, \"%d/%m/%Y\") as salesdate, p.productName, p.price, si.Quantity, si.discount, si.total, p.Remark from product as p inner join SalesItem as si on p.productID = si.productID inner join SalesRecord as sr on si.salesrecordID = sr.salesrecordID where showcaseID = '" + contract.showcaseID + "' and (salesdate >= '"+startOfMonth.ToString("yyyy-MM--dd")+"' and salesdate <='"+endOfMonth.ToString("yyyy-MM-dd")+"');";
                dataadapter.SelectCommand = new MySqlCommand(SQL, FormContainer.conn);
                dataadapter.Fill(datasetmonthlystatement.Tables["salesrecord"]);


                //declare report parameter
                ReportParameter pSalesrecordPeriod = new ReportParameter("pSalesrecordPeriod", startOfMonth.ToString("dd/MM/yyyy - ") + endOfMonth.ToString("dd/MM/yyyy"));
                ReportParameter pShowcaseid = new ReportParameter("pShowcaseid", contract.showcaseID);
                ReportParameter pTenantname = new ReportParameter("pTenantname", contract.tenant.name);
                ReportParameter pPhone = new ReportParameter("pPhone", contract.tenant.phonenumber.ToString());
                /* declare start and end of rental period*/
                endOfMonth = new DateTime(period.Year, period.Month, DateTime.DaysInMonth(period.Year, period.Month));
                startOfMonth = new DateTime(period.Year, period.Month, 1);
                ReportParameter pRentperiod = new ReportParameter("pRentperiod", startOfMonth.ToString("dd/MM/yyyy - ") + endOfMonth.ToString("dd/MM/yyyy"));
                ReportParameter pMonthlyrent = new ReportParameter("pMonthlyrent", contract.rent.ToString());
                ReportParameter pDiscount = new ReportParameter("pDiscount", (contract.discount * 100).ToString());
                ReportParameter pAmountdue = new ReportParameter("pAmountdue", contract.getAmountdue().ToString());
                ReportParameter pCommission = new ReportParameter("pCommission", (contract.commission*100).ToString()); // commission in percentage 
                ReportParameter pToday = new ReportParameter("pToday", DateTime.Today.ToString("yyyy-MM-dd"));
                ReportParameter pSalesreceivable = new ReportParameter("pSalesreceivable", getSalesReceivable().ToString());
                ReportParameter pTotalshowcase = new ReportParameter("pTotalshowcase", getTotalShowcase());
                ReportParameter pCharge = new ReportParameter("pCharge", getCharge().ToString());
                ReportParameter pAmountReceivable = new ReportParameter("pAmountReceivable", getAmountReceivable().ToString());
                ReportParameter pPrepaid = new ReportParameter("pPrepaid", contract.tenant.prepaid.ToString());
                ReportParameter pAmountPayable = new ReportParameter("pAmountPayable", getAmountPayable().ToString());
                ReportParameter pBanlanceDue = new ReportParameter("pBanlanceDue", getBanlanceDue().ToString());


                //set report viewer's parameter.
                reportViewer1.LocalReport.SetParameters(pSalesrecordPeriod);
                reportViewer1.LocalReport.SetParameters(pShowcaseid);
                reportViewer1.LocalReport.SetParameters(pTenantname);
                reportViewer1.LocalReport.SetParameters(pPhone);
                reportViewer1.LocalReport.SetParameters(pRentperiod);
                reportViewer1.LocalReport.SetParameters(pMonthlyrent);
                reportViewer1.LocalReport.SetParameters(pDiscount);
                reportViewer1.LocalReport.SetParameters(pAmountdue);
                reportViewer1.LocalReport.SetParameters(pCommission);
                reportViewer1.LocalReport.SetParameters(pToday);
                reportViewer1.LocalReport.SetParameters(pSalesreceivable);
                reportViewer1.LocalReport.SetParameters(pTotalshowcase);
                reportViewer1.LocalReport.SetParameters(pCharge);
                reportViewer1.LocalReport.SetParameters(pAmountReceivable);
                reportViewer1.LocalReport.SetParameters(pPrepaid);
                reportViewer1.LocalReport.SetParameters(pAmountPayable);
                reportViewer1.LocalReport.SetParameters(pBanlanceDue);

                //declare data source
                rptDataSource = new ReportDataSource("DataSetMonthlyStatement", datasetmonthlystatement.Tables["salesrecord"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void initializeSalesItemsList()
        {
            /* declare start and end of period of salesrecord*/
            endOfMonth = (new DateTime(period.Year, period.Month, DateTime.DaysInMonth(period.Year, period.Month))).AddMonths(-1);
            startOfMonth = (new DateTime(period.Year, period.Month, 1)).AddMonths(-1);
            SQL = "select DATE_FORMAT(sr.salesdate, \"%d/%m/%Y\") as salesdate, p.productName, p.price, si.Quantity, si.discount, si.total, p.Remark from product as p inner join SalesItem as si on p.productID = si.productID inner join SalesRecord as sr on si.salesrecordID = sr.salesrecordID where showcaseID = '" + contract.showcaseID + "' and (salesdate >= '" + startOfMonth.ToString("yyyy-MM--dd") + "' and salesdate <='" + endOfMonth.ToString("yyyy-MM-dd") + "');";
            cmd = new MySqlCommand(SQL, FormContainer.conn);
            myData = cmd.ExecuteReader();
            while (myData.Read())
            {
                salesItems.Add(new SalesItem
                {
                    salesdate = myData["salesdate"].ToString(),
                    productname = myData["productName"].ToString(),
                    price = Convert.ToDecimal(myData["price"]),
                    amount = Convert.ToInt32(myData["Quantity"]),
                    discount = Convert.ToInt32(myData["discount"]),
                    Remark = myData["Remark"].ToString()
                });
            }
            myData.Close();
        }

        private void contractBindSalesItemsList()
        {
            contract.salesitems = new List<SalesItem>();
            contract.salesitems.Clear();
            contract.salesitems = salesItems;

        }

        #region getter
        private decimal getSalesReceivable()
        {
            decimal salesreceivable = 0;
            foreach (SalesItem si in contract.salesitems)
            {
                salesreceivable += si.calTotal();
            }
            return salesreceivable;
        }

        private String getTotalShowcase()
        {
            String tenantid = contract.tenantID;
            SQL = "select count(contractID) as totalshowcase from contract where tenantid = '" + tenantid + "';";
            cmd = new MySqlCommand(SQL, FormContainer.conn);
            myData = cmd.ExecuteReader();
            while (myData.Read())
            {
                String totalshowcase = myData["totalshowcase"].ToString();
                myData.Close();
                return totalshowcase;
            }
            myData.Close();
            return "0";
        }

        private decimal getCharge()
        {
            return getSalesReceivable() * Convert.ToDecimal(contract.commission);
        }

        private decimal getAmountReceivable()
        {
            return getSalesReceivable() - getCharge();
        }

        private decimal getAmountPayable()
        {
            Decimal AmountPayable = contract.tenant.prepaid - Convert.ToDecimal(contract.getAmountdue());
            if (AmountPayable < 0)
            {
                return AmountPayable;
            }
            else
            {
                return 0;
            }
        }

        private decimal getBanlanceDue()
        {
            return getAmountReceivable() + getAmountPayable();
        }

        #endregion

    }
}
