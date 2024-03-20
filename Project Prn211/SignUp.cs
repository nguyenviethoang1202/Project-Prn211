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
    public partial class SignUp : Form
    {
        Prn211dbContext context = new Prn211dbContext();
        Encryption encryption = new Encryption();
        public SignUp()
        {
            InitializeComponent();
        }
        private void btnSignup_Click(object sender, EventArgs e)
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
            if (!Regex.IsMatch(txtUsername.Text, "^[a-zA-Z0-9_]{4,20}$"))
            {
                MessageBox.Show("Username must be from 4 to 20 characters and not contains any special character!");
                return;
            }
            if (context.Users.FirstOrDefault(x => x.Username == txtUsername.Text) != null)
            {
                MessageBox.Show("Username is already existed!");
                return;
            }
            if (!Regex.IsMatch(txtPassword.Text, "^[a-zA-Z0-9_]{1,}$"))
            {
                MessageBox.Show("Password can not null and not contains any special character!");
                return;
            }
            if (txtPassword.Text != txtRepass.Text)
            {
                MessageBox.Show("Repassword is not the same with password!");
                return;
            }
            User user = new User()
            {
                FullName = txtFullname.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Username = txtUsername.Text,
                Password = encryption.HashPassword(txtPassword.Text),
            };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Sign up successfully!");
            this.Close();
        }

        private void llbSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

        }
    }
}
