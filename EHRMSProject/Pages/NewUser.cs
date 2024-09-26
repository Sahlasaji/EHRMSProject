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
using EHRMSProject.Entities;
using EHRMSProject.Repos;

namespace EHRMSProject
{
    public partial class NewUser : Form
    {
        private ListMemoryRepo repo;
        public NewUser()
        {
            InitializeComponent();
            repo = ListMemoryRepo.GetInstance();
        }
        private User user = new User()
        {
            UserId = 0,
            Name = "",
            Email = "",
            Password = "",
            Role = "",
            CreatedAt = "",
            LastLogin = ""
        };

        

        private void DoNewUser()
        {
            //new contact object
            User user = new User()
            {
                UserId = 0,
                Name = "",
                Email = "",
                Password = "",
                Role = "",
                CreatedAt = "",
                LastLogin = ""
            };
            //object to UIs
            txtUserId.Text = user.UserId.ToString();
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            txtRole.Text = user.Role;
            txtCreatedAt.Text = user.CreatedAt;
            txtLastLogin.Text = user.LastLogin;

            //
            txtName.Focus();
        }

        private void DoCreate()
        {
            var result = MessageBox.Show(text: "Are you sure to create?",
                                         caption: "Confirm",
                                         buttons: MessageBoxButtons.YesNo,
                                         icon: MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            //UIs to object
            User newUser = new User()
            {
                UserId = int.Parse(txtUserId.Text),
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = txtRole.Text,
                CreatedAt = txtCreatedAt.Text,
                LastLogin = txtLastLogin.Text
            };

            //db create in CRUD
            repo.Create(newUser);
            //
            result = MessageBox.Show(text: "Created Successfully",
                                     caption: "Alert",
                                     buttons: MessageBoxButtons.OK,
                                     icon: MessageBoxIcon.Information);
            //Refresh the form 1. refresh list 2. referesh form (new contact mode)
            DoNewUser();
        }



        private void NewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DoCreate();
        }
    }
}
