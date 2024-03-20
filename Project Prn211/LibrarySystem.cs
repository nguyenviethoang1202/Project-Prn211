using Project_Prn211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Prn211
{
    public partial class LibrarySystem : Form
    {
        private Form currentFormChild;
        User loggedUser;
        Prn211dbContext context = new Prn211dbContext();
        public LibrarySystem()
        {
            InitializeComponent();
        }
        public LibrarySystem(User loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            Load();
        }
        public void Load()
        {
            lbFullname.Text = "Welcome " + loggedUser.FullName.ToString();
            lbHome.Text = "Home";
            if (loggedUser.UserId != 1)
            {
                btnUser.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pBody.Controls.Add(childForm);
            pBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnInfoForm_Click(object sender, EventArgs e)
        {
            var infoForm = new InfoForm(loggedUser);
            infoForm.UserInfoUpdated += InfoForm_UserInfoUpdated;
            openChildForm(infoForm);
            lbHome.Text = "Info";
        }
        private void InfoForm_UserInfoUpdated(object sender, EventArgs e)
        {

            User user = context.Users.FirstOrDefault(x => x.UserId == loggedUser.UserId);
            loggedUser = user;
            lbFullname.Text = "Welcome " + loggedUser.FullName.ToString();
        }

        private void btnMyHiredBook_Click(object sender, EventArgs e)
        {
            openChildForm(new MyHiredBook(loggedUser));
            lbHome.Text = "My Hired Book";
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            openChildForm(new Library(loggedUser));
            lbHome.Text = "Library";
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserManagement(loggedUser));
            lbHome.Text = "User Management";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                lbHome.Text = "Home";
            }
        }

        private void LibrarySystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
