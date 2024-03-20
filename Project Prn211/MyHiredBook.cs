using Microsoft.EntityFrameworkCore;
using Project_Prn211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Prn211
{
    public partial class MyHiredBook : Form
    {
        Prn211dbContext context = new Prn211dbContext();
        User loggedUser;
        int choseBookId = 0;
        string action = null;
        public MyHiredBook(User loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            btnDetails.Enabled = false;
            Load();
            LoadDgv();
        }

        private void Load()
        {
            var types = context.Types.ToList();
            var allType = new Models.Type { TypeId = 0, Name = "All" };
            types.Insert(0, allType);
            cbsType.DataSource = types;
            cbsType.DisplayMember = "Name";
            cbsType.ValueMember = "TypeId";
        }
        public void LoadDgv()
        {
            dgvHiredBooks.DataSource = null;
            dgvHiredBooks.DataSource = context.Books.Include(x => x.Author)
                .Include(x => x.Publisher).Include(x => x.Type)
                .Where(x => (x.IsDeleted == false)
                && (x.HiredBy == loggedUser.UserId))
                .Select(x => new
                {
                    x.BookId,
                    x.Name,
                    Type = x.Type.Name,
                    Author = x.Author.AuthorName,
                    Publisher = x.Publisher.Name,
                    x.HiredDate,
                    x.ReturnDate
                }).ToList();

            dgvHiredBooks.Columns["HiredDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHiredBooks.Columns["ReturnDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public MyHiredBook()
        {
            InitializeComponent();
        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtPublisher_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            string bookId = txtBookId.Text;
            string bookName = txtBookName.Text;
            int? typeId = cbsType.SelectedItem != null ? ((Models.Type)cbsType.SelectedItem).TypeId : 0;
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;

            dgvHiredBooks.DataSource = null;
            dgvHiredBooks.DataSource = context.Books
                .Include(x => x.Author).Include(x => x.Publisher).Include(x => x.Type)
                .Where(x => (bookId == "" || x.BookId.ToString().Contains(bookId))
                         && (bookName == "" || x.Name.Contains(bookName))
                         && (typeId == 0 || x.TypeId == typeId)
                         && (author == "" || x.Author.AuthorName.Contains(author))
                         && (publisher == "" || x.Publisher.Name.Contains(publisher))
                         && (x.IsDeleted == false)
                         && (x.HiredBy == loggedUser.UserId))
                .Select(x => new
                {
                    x.BookId,
                    x.Name,
                    Type = x.Type.Name,
                    Author = x.Author.AuthorName,
                    Publisher = x.Publisher.Name,
                    x.HiredDate,
                    x.ReturnDate
                }).ToList();
            dgvHiredBooks.Columns["HiredDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHiredBooks.Columns["ReturnDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvHiredBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHiredBooks.Rows[e.RowIndex];
                choseBookId = Convert.ToInt32(row.Cells["BookId"].Value);
                btnDetails.Enabled = true;
            }
            else
            {
                btnDetails.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookId.Text = "";
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            cbsType.SelectedIndex = 0;
            choseBookId = 0;
            LoadDgv();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            action = "Details2";
            LibraryAction libraryAction = new LibraryAction(this, action, loggedUser, choseBookId)
            {
                Text = "Book details ",
            };
            libraryAction.ShowDialog();
            libraryAction.Dispose();
        }
    }
}
