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
    public partial class FormReceipt : Form
    {
        String SQL = "";
        MySqlDataReader myData;
        MySqlCommand cmd;
        String SalesRecordID;
        List<SalesItem> shoppingcart;
        decimal cashTendered;
        public FormReceipt(List<SalesItem> shoppingcart,String SalesRecordID,decimal cashTendered)
        {
            InitializeComponent();
            this.SalesRecordID = SalesRecordID;
            this.shoppingcart = shoppingcart;
            this.cashTendered = cashTendered;
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            loadReport();
            this.reportViewer1.Refresh();
        }

        public void loadReport()
        {
            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSetReceipt datasetreceipt = new DataSetReceipt();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();

                //fill data set
                SQL = "select r.salesrecordID, r.salesdate, i.productID, i.productName, i.Quantity, i.discount, i.total, i.price from SalesRecord as r inner join SalesItem as i on r.salesrecordID = i.salesrecordID where i.salesrecordID like '"+ SalesRecordID + "';";
                dataadapter.SelectCommand = new MySqlCommand(SQL,FormContainer.conn);
                dataadapter.Fill(datasetreceipt.Tables["Receipt"]);

                //declare report parameter
                decimal TotalAmount = 0;
                decimal TotalDiscount = 0;
                decimal Subtotal = 0;
                foreach (SalesItem s in shoppingcart)
                {
                    TotalAmount += s.calTotal();
                    TotalDiscount += s.discount;
                    Subtotal += s.calSubTotal();
                }
                decimal Change = TotalAmount - cashTendered;
                ReportParameter pTotalAmount = new ReportParameter("pTotalAmount", TotalAmount.ToString());
                ReportParameter pTotalDiscount = new ReportParameter("pTotalDiscount",  TotalDiscount.ToString());
                ReportParameter pSubtotal = new ReportParameter("pSubtotal", Subtotal.ToString());
                ReportParameter pCashTendered = new ReportParameter("pCashTendered", cashTendered.ToString());
                ReportParameter pChange = new ReportParameter("pChange", Change.ToString());
                //set report viewer's parameter.
                reportViewer1.LocalReport.SetParameters(pTotalAmount);
                reportViewer1.LocalReport.SetParameters(pTotalDiscount);
                reportViewer1.LocalReport.SetParameters(pSubtotal);
                reportViewer1.LocalReport.SetParameters(pCashTendered);
                reportViewer1.LocalReport.SetParameters(pChange);

                //declare data source
                rptDataSource = new ReportDataSource("DataSetReceipt", datasetreceipt.Tables["Receipt"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
