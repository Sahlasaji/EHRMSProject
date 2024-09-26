using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHRMSProject
{
    public partial class UserManagementPage : Form
    {
        public UserManagementPage()
        {
            InitializeComponent();
        }
        private NewUser frmNewUser = new NewUser();

        private void UserManagementPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmNewUser.MdiParent = MyConfig.mainPage;
            frmNewUser.Show();
            frmNewUser.Activate();
        }
    }
}
