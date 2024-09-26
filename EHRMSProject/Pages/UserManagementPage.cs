using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EHRMSProject.Database;
using EHRMSProject.Repos;

namespace EHRMSProject
{
    public partial class UserManagementPage : Form
    {
        private ListMemoryRepo repo;
        public UserManagementPage()
        {
            InitializeComponent();
            repo = ListMemoryRepo.GetInstance();
        }
        
        private NewUser frmNewUser = new NewUser();
        private void DoLoadContacts()
        {
            lstUsersList.DataSource = null;
            lstUsersList.DataSource = repo.ReadAll();
        }

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

        private void UserManagementPage_Load(object sender, EventArgs e)
        {
            DoLoadContacts();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DoLoadContacts();
        }
    }
}
