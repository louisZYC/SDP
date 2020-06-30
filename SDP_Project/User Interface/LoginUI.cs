using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SDP_Project
{
    public partial class LoginUI : Form
    {
        private FormContainer frmContainer;
        public LoginUI(FormContainer frmContainer)
        {
            InitializeComponent();
            this.frmContainer = frmContainer;
            this.MdiParent = frmContainer;
            this.Dock = DockStyle.Fill; //fit in container
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //call loginController's verifLogin() method for verification.
            if(LoginController.verifyLogin(txtStaffID.Text, txtPassword.Text, out Staff staff)){
                if (staff.getRank().Equals("admin"))
                {
                    frmContainer.displayAdminUI();
                }else if (staff.getRank().Equals("Staff"))
                {
                    frmContainer.displayStaffUI(staff);
                }
            }
            else
            {
                MessageBox.Show("login fail");
            }
            
        }  

        public void clearTextbox()
        {
            txtPassword.Clear();
            txtStaffID.Clear();
            txtStaffID.Focus();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }
    }
}
