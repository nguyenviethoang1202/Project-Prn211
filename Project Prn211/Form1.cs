using Microsoft.IdentityModel.Tokens;
using Project_Prn211.Models;
using Project_Prn211.Utils;
using System.Diagnostics.Eventing.Reader;

namespace Project_Prn211
{
    public partial class LoginForm : Form
    {
        Encryption encrytion = new Encryption();
        Prn211dbContext context = new Prn211dbContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            User user = getUser();
            if (user != null&&user.IsBanned ==false)
            {
                LibrarySystem librarySystem = new LibrarySystem(user);
                this.Hide();
                librarySystem.Show();
            }
            else
            {
                MessageBox.Show("Username or password is not correct!", "Alert");
                return;
            }

        }
        public User getUser()
        {
            string pass = encrytion.HashPassword(txtPassword.Text);
            User user = context.Users.FirstOrDefault(x => x.Username == txtUsername.Text && x.Password == pass);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            signUp.Dispose();
            this.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
