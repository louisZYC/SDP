using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDP_Project.User_Interface;

namespace SDP_Project
{
    public partial class StaffUI : Form
    {
        public static Staff staff;
        FormShowcaseRental frmShowcaseRental;
        FormRentalRecord frmRentalRecord;
         FormCustomerSalesManagement frmCSM;
        FormShowcaseManagement frmShowcaseManagement;
        FormInventory frmInventory;
        FormSalesRecord frmSalesrecord;
        FormShoppingCart frmCart;
        public StaffUI(FormContainer frmContainer, Staff s)
        {
            InitializeComponent();
            this.MdiParent = frmContainer;
            staff = new Staff();
            staff = s;
            this.Dock = DockStyle.Fill;
            frmShowcaseRental = new FormShowcaseRental();
            frmRentalRecord = new FormRentalRecord(this);
            frmCSM = new FormCustomerSalesManagement();
            frmShowcaseManagement = new FormShowcaseManagement();
            frmInventory = new FormInventory();
            frmSalesrecord = new FormSalesRecord();


            
        }
        private void StaffUI_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + staff.getName() + " " + staff.getRank() + " staff ID :" + staff.getStaffID();
        }


        Form activeForm;
        private void openChildForm(Form ChildForm)
        {
            lblWelcome.Visible = false;
            if (activeForm != null)
                activeForm.Visible = false;
            activeForm = ChildForm;
            activeForm.Visible = true;
            activeForm.TopLevel = false;//make the form become a control
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(ChildForm);
            ChildForm.Show();
        }

        private void btnShowcaseRental_Click(object sender, EventArgs e)
        {
            openChildForm(frmShowcaseRental);
        }

        private void btnRentalRecord_Click(object sender, EventArgs e)
        {
            openChildForm(frmRentalRecord);
        }

        private void btnCustomerSalesManagement_Click(object sender, EventArgs e)
        {
            openChildForm(frmCSM);
        }
        private void btnShowcaseManagement_Click(object sender, EventArgs e)
        {
            openChildForm(frmShowcaseManagement);
        }


        private void btnInventory_Click(object sender, EventArgs e)
        {
            openChildForm(frmInventory);
        }


        private void btnSalesRecord_Click(object sender, EventArgs e)
        {
            openChildForm(frmSalesrecord);
        }

        //callback function
        public void initializeAvailibility()
        {
            frmShowcaseRental.initializeAvailibility();
        } 

    }
}
