using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Project
{
    public partial class AdminUI : Form
    {
        private FormContainer frmContainer;
        FormRegistration frmRegistration;
        FormAccountManagement frmAccountManagement;
        public AdminUI(FormContainer frmContainer)
        {
            InitializeComponent();
            this.frmContainer = frmContainer;
            this.MdiParent = this.frmContainer;
            this.Dock = DockStyle.Fill; //fit in container
        }
        

        private Form activeForm = null;

        // open child form in panel(pnlChildForm)
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Visible = false;
            activeForm = ChildForm;
            activeForm.Visible = true;
            activeForm.TopLevel = false;//make the form become a control
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(ChildForm);
            ChildForm.Show();
        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration = new FormRegistration();
            openChildForm(frmRegistration);
        }
        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            frmAccountManagement = new FormAccountManagement();
            openChildForm(frmAccountManagement);
        }
    }
}
