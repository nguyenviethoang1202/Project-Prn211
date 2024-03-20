using Microsoft.EntityFrameworkCore;
using Project_Prn211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Prn211
{
    public partial class UserManagement : Form
    {
        User loggedUser;
        Prn211dbContext context = new Prn211dbContext();
        int choseUserId = 0;
        public UserManagement(User loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            btnBan.Enabled = false;
            btnUnban.Enabled = false;
            Load();
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = context.Users.Where(x => x.UserId != 1)
                .Select(x => new
                {
                    x.UserId,
                    x.Username,
                    x.FullName,
                    x.Email,
                    x.Phone,
                    isBanned = x.IsBanned.Value ? "True" : "False"
                }).ToList();
        }

        private void Load()
        {
            var availabilityOptions = new List<ComboBoxItem>
            {
                new ComboBoxItem { Value = -1, Text = "All" },
                new ComboBoxItem { Value = 0, Text = "False" },
                new ComboBoxItem { Value = 1, Text = "True" }
             };
            cbsIsBanned.DataSource = availabilityOptions.ToList();
            cbsIsBanned.DisplayMember = "Text";
            cbsIsBanned.ValueMember = "Value";
        }
        public UserManagement()
        {
            InitializeComponent();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                choseUserId = Convert.ToInt32(row.Cells["UserId"].Value);
                btnBan.Enabled = true;
                btnUnban.Enabled = true;

            }
            else
            {
                btnUnban.Enabled = false;
                btnBan.Enabled = false;
            }
            LoadUserHiredBook();
        }
        private void LoadUserHiredBook()
        {
            if (choseUserId != 0)
            {
                dgvUserHiredBooks.DataSource = null;
                dgvUserHiredBooks.DataSource = context.Books
                    .Include(x => x.Author).Include(x => x.Publisher).Include(x => x.Type)
                    .Where(x => (x.IsDeleted == false)
                             && (x.HiredBy == choseUserId))
                    .Select(x => new
                    {
                        x.BookId,
                        x.Name,
                        Type = x.Type.Name,
                        Author = x.Author.AuthorName,
                        Publisher = x.Publisher.Name,
                        Avaiable = x.IsAvailable.Value ? "Hired" : "Avaiable",
                        x.HiredDate,
                        x.ReturnDate
                    }).ToList();
                dgvUserHiredBooks.Columns["HiredDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvUserHiredBooks.Columns["ReturnDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
            {
                dgvUserHiredBooks.DataSource = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbsIsBanned_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            string userId = txtUserId.Text;
            string fullname = txtUserFullname.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            int? isBanned = cbsIsBanned.SelectedItem != null ? ((Models.ComboBoxItem)cbsIsBanned.SelectedItem).Value : -1;
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = context.Users
                .Where(x => (userId == "" || x.UserId.ToString().Contains(userId))
                         && (fullname == "" || x.FullName.Contains(fullname))
                         && (phone == "" || x.Phone.Contains(phone))
                         && (email == "" || x.Email.Contains(email))
                         && (isBanned == -1 || x.IsBanned == (isBanned == 1))
                         && (x.UserId != 1))
                .Select(x => new
                {
                    x.UserId,
                    x.Username,
                    x.FullName,
                    x.Email,
                    x.Phone,
                    isBanned = x.IsBanned.Value ? "True" : "False"
                }).ToList();
            dgvUserHiredBooks.DataSource = null;
            choseUserId = 0;
        }
        private void btnBan_Click(object sender, EventArgs e)
        {
            User user = context.Users.FirstOrDefault(x => x.UserId == choseUserId);
            user.IsBanned = true;
            context.SaveChanges();
            MessageBox.Show("Ban successfully");
            Search();
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            User user = context.Users.FirstOrDefault(x => x.UserId == choseUserId);
            user.IsBanned = false;
            context.SaveChanges();
            MessageBox.Show("Unban successfully");
            Search();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtUserId.Text = "";
            txtUserFullname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cbsIsBanned.SelectedIndex = 0;
            dgvUserHiredBooks.DataSource = null;
            choseUserId = 0;
            LoadDgv();
        }
    }
}
