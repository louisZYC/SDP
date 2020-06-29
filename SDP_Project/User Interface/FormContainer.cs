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
using MySql.Data;
using SDP_Project.Entity;

namespace SDP_Project
{
    public partial class FormContainer : Form
    {
        public static string dbHost = "52.0.8.225"; // "dbms IP";
        public static string dbUser = "staff0"; //"dbms user name";
        public static string dbPass = "qwe-1234"; // "password";
        public static string dbName = "SDP_PROJ"; // "schema name";
                                                  // you may have to add CharSet if your are using different charset such as UTF8
        public static string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
        public static MySqlConnection conn = new MySqlConnection(connStr);

        //refer to other child forms
        public LoginUI loginUI ;
        public StaffUI staffUI;
        public AdminUI adminUI;

        //constructor
        public FormContainer()
        {
            InitializeComponent();
            if (loginUI == null)
            {
                loginUI = new LoginUI(this);
            }
            loginUI.Show();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            // connect to DBMS
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("unable to connect to DBMS");
                        break;
                    case 1045:
                        MessageBox.Show("login failed");
                        break;
                }
            }
       
        }

        public void displayStaffUI(Staff staff)
        {
            if(staffUI == null)
            {
                staffUI = new StaffUI(this,staff);
            }
            loginUI.Visible = false;
            staffUI.Show();
        }

        public void displayAdminUI()
        {
            if (adminUI == null)
            {
                adminUI = new AdminUI(this);
            }
            loginUI.Visible = false;
            adminUI.Show();
        }

        //log out
        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            if (staffUI != null)
            {
                staffUI.Dispose();
                staffUI = null;
            }else if (adminUI != null)
            {
                adminUI.Dispose();
                adminUI = null;
            }
            loginUI.Visible = true;
            loginUI.clearTextbox();
        }
    }
}
