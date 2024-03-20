using Project_Prn211.Models;
using Project_Prn211.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Prn211
{
    public partial class InfoForm : Form
    {
        User loggedUser;
        Prn211dbContext context = new Prn211dbContext();
        Encryption encryption = new Encryption();
        public event EventHandler UserInfoUpdated;
        public InfoForm()
        {
            InitializeComponent();
        }
        public InfoForm(User loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            Load();
        }
        private void Load()
        {
            txtId.Text = loggedUser.UserId.ToString();
            txtUsername.Text = loggedUser.Username.ToString();
            txtFullname.Text = loggedUser.FullName.ToString();
            txtEmail.Text = loggedUser.Email.ToString();
            txtPhone.Text = loggedUser.Phone.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                MessageBox.Show("Full name can not null!");
                return;
            }
            if (!Regex.IsMatch(txtEmail.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Email must be the correct form!");
                return;
            }
            if (!Regex.IsMatch(txtPhone.Text, "^\\d{10,11}$"))
            {
                MessageBox.Show("Phone must be 10 or 11 numbers!");
                return;
            }
            User user = context.Users.FirstOrDefault(x => x.UserId == loggedUser.UserId);
            user.FullName = txtFullname.Text;
            user.Phone = txtPhone.Text;
            user.Email = txtEmail.Text;
            context.SaveChanges();
            MessageBox.Show("Update complete");
            UserInfoUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string oldPass = encryption.HashPassword(txtOldpass.Text);
            if (loggedUser.Password != oldPass)
            {
                MessageBox.Show("Old password is not correct!");
                return;
            }
            if (!Regex.IsMatch(txtNewpass.Text, "^[a-zA-Z0-9_]{1,}$"))
            {
                MessageBox.Show("New password can not null and not contains any special character!");
                return;
            }
            if(txtNewpass.Text==txtOldpass.Text)
            {
                MessageBox.Show("New password must be different than old password!");
                return;
            }
            if (txtNewpass.Text != txtRepass.Text)
            {
                MessageBox.Show("Repassword is not the same with password!");
                return;
            }

            string newPass = encryption.HashPassword(txtNewpass.Text);
            User user = context.Users.FirstOrDefault(x => x.UserId == loggedUser.UserId);
            user.Password = newPass;
            context.SaveChanges();
            loggedUser = user;

            UserInfoUpdated?.Invoke(this, EventArgs.Empty);

            txtOldpass.Text = "";
            txtNewpass.Text = "";
            txtRepass.Text = "";

            MessageBox.Show("Change password successfully");
        }
    }
}
