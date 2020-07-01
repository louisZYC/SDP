using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using SDP_Project.Entity;
using System.Windows.Forms;

namespace SDP_Project.Controller
{
    public class ListManager
    {

        public static List<salesrecord> loadSalesrecords()
        {
            String SQL = "";
            MySqlCommand cmd;
            MySqlDataReader myData;
            List<salesrecord> _salesrecords = new List<salesrecord>();
            try
            {
                SQL = "select sr.salesrecordID, sr.staffID, sr.salesdate ,b.branchid from SalesRecord as sr " +
                        "inner join SalesItem as si on sr.salesrecordID = si.salesrecordID " +
                        "inner join product as p on p.productID = si.productID " +
                        "inner join showcase as s on s.showcaseid = p.showcaseid " +
                        "inner join branch as b on b.branchid = s.branchid "+
                        "order by sr.salesdate;";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                    salesrecord s = new salesrecord
                    {
                        salesrecordID = myData["salesrecordID"].ToString(),
                        staffID = myData["staffID"].ToString(),
                        salesdate = Convert.ToDateTime(myData["salesdate"]),
                        branchid = myData["branchid"].ToString(),
                    };
                    _salesrecords.Add(s);
                }
                myData.Close();
                
                //bind salesrecord._salesitems
                foreach(salesrecord salesrecord in _salesrecords)
                {
                    salesrecordBindsalesItemList(salesrecord);
                }
                return _salesrecords;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
                return null;
            }


        }

        public static void salesrecordBindsalesItemList(salesrecord salesrecord)
        {
            String SQL;
            MySqlCommand cmd;
            MySqlDataReader myData;
            List<SalesItem> _salesItems = new List<SalesItem>();
            try
            {
                SQL = "select productName, Quantity, discount,price from SalesItem where salesrecordID = '"+ salesrecord.salesrecordID+ "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                    SalesItem si = new SalesItem {
                        productname = myData["productName"].ToString(),
                        amount = Convert.ToInt32(myData["Quantity"]),
                        discount = Convert.ToInt32(myData["discount"]),
                        price = Convert.ToDecimal(myData["price"])
                    };
                    _salesItems.Add(si);
                }
                myData.Close();
                salesrecord._salesitems = _salesItems;
                _salesItems = null;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
        }
    }
}
