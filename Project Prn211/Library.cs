using Microsoft.EntityFrameworkCore;
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
    public partial class Library : Form
    {
        Prn211dbContext context = new Prn211dbContext();
        User loggedUser;
        int choseBookId = 0;
        string action = null;
        public Library()
        {
            InitializeComponent();
        }
        public Library(User loggedUser)
        {
            InitializeComponent();

            this.loggedUser = loggedUser;

            if (loggedUser.UserId != 1)
            {
                btnAdd.Hide();
                btnDelete.Hide();
                btnUpdate.Hide();
            }

            var types = context.Types.ToList();
            var allType = new Models.Type { TypeId = 0, Name = "All" };
            types.Insert(0, allType);
            cbsType.DataSource = types;
            cbsType.DisplayMember = "Name";
            cbsType.ValueMember = "TypeId";

            var availabilityOptions = new List<ComboBoxItem>
            {
                new ComboBoxItem { Value = -1, Text = "All" },
                new ComboBoxItem { Value = 0, Text = "Avaiable" },
                new ComboBoxItem { Value = 1, Text = "Hired" }
             };
            cbsIsAvaiable.DataSource = availabilityOptions.ToList();
            cbsIsAvaiable.DisplayMember = "Text";
            cbsIsAvaiable.ValueMember = "Value";

            if (loggedUser.UserId != 1)
            {
                LoadDgvUser();
            }
            else
            {
                LoadDgvAdmin();
            }
        }
        public void LoadDgvAdmin()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = context.Books.Include(x => x.Author)
                .Include(x => x.Publisher).Include(x => x.Type)
                .Where(x => x.IsDeleted == false)
                .Select(x => new
                {
                    x.BookId,
                    x.Name,
                    Type = x.Type.Name,
                    Author = x.Author.AuthorName,
                    Publisher = x.Publisher.Name,
                    Avaiable = x.IsAvailable.Value ? "Hired" : "Avaiable"
                }).ToList();
        }
        public void LoadDgvUser()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = context.Books.Include(x => x.Author)
                .Include(x => x.Publisher).Include(x => x.Type)
                .Where(x => (x.HiredBy != loggedUser.UserId)
                            && (x.IsDeleted == false))
                .Select(x => new
                {
                    x.BookId,
                    x.Name,
                    Type = x.Type.Name,
                    Author = x.Author.AuthorName,
                    Publisher = x.Publisher.Name,
                    Avaiable = x.IsAvailable.Value ? "Hired" : "Avaiable"
                }).ToList();
        }
        private void txtBookId_TextChanged(object sender, EventArgs e)
        {
            if (loggedUser.UserId == 1)
            {
                SearchByAdmin();
            }
            else
            {
                SearchByUser();
            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (loggedUser.UserId == 1)
            {
                SearchByAdmin();
            }
            else
            {
                SearchByUser();
            }
        }

        private void cbsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loggedUser.UserId == 1)
            {
                SearchByAdmin();
            }
            else
            {
                SearchByUser();
            }
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            if (loggedUser.UserId == 1)
            {
                SearchByAdmin();
            }
            else
            {
                SearchByUser();
            }
        }

        private void txtPublisher_TextChanged(object sender, EventArgs e)
        {
            if (loggedUser.UserId == 1)
            {
                SearchByAdmin();
            }
            else
            {
                SearchByUser();
            }
        }
        private void SearchByAdmin()
        {
            string bookId = txtBookId.Text;
            string bookName = txtBookName.Text;
            int? typeId = cbsType.SelectedItem != null ? ((Models.Type)cbsType.SelectedItem).TypeId : 0; 
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;
            int? isAvaiable = cbsIsAvaiable.SelectedItem != null ? ((Models.ComboBoxItem)cbsIsAvaiable.SelectedItem).Value : -1;

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = context.Books
                .Include(x => x.Author).Include(x => x.Publisher).Include(x => x.Type)
                .Where(x => (bookId == "" || x.BookId.ToString().Contains(bookId))
                         && (bookName == "" || x.Name.Contains(bookName))
                         && (typeId == 0 || x.TypeId == typeId)
                         && (author == "" || x.Author.AuthorName.Contains(author))
                         && (publisher == "" || x.Publisher.Name.Contains(publisher))
                         && (isAvaiable == -1 || x.IsAvailable == (isAvaiable == 1))
                         && (x.IsDeleted == false))
                .Select(x => new
                {
                    x.BookId,
                    x.Name,
                    Type = x.Type.Name,
                    Author = x.Author.AuthorName,
                    Publisher = x.Publisher.Name,
                    Avaiable = x.IsAvailable.Value ? "Hired" : "Avaiable"
                }).ToList();
        }
        private void SearchByUser()
        {
            string bookId = txtBookId.Text;
            string bookName = txtBookName.Text;
            int? typeId = cbsType.SelectedItem != null ? ((Models.Type)cbsType.SelectedItem).TypeId : 0; 
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;
            int? isAvaiable = cbsIsAvaiable.SelectedItem != null ? ((Models.ComboBoxItem)cbsIsAvaiable.SelectedItem).Value : -1;

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = context.Books
                .Include(x => x.Author).Include(x => x.Publisher).Include(x => x.Type)
                .Where(x => (bookId == "" || x.BookId.ToString().Contains(bookId))
                         && (bookName == "" || x.Name.Contains(bookName))
                         && (typeId == 0 || x.TypeId == typeId)
                         && (author == "" || x.Author.AuthorName.Contains(author))
                         && (publisher == "" || x.Publisher.Name.Contains(publisher))
                         && (isAvaiable == -1 || x.IsAvailable == (isAvaiable == 1))
                         && (x.HiredBy != loggedUser.UserId)
                         && (x.IsDeleted == false))
                .Select(x => new
                {
                    x.BookId,
                    x.Name,
                    Type = x.Type.Name,
                    Author = x.Author.AuthorName,
                    Publisher = x.Publisher.Name,
                    Avaiable = x.IsAvailable.Value ? "Hired" : "Avaiable"
                }).ToList();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookId.Text = "";
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";

            cbsType.SelectedIndex = 0;
            cbsIsAvaiable.SelectedIndex = 0;

            choseBookId = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDetails.Enabled = false;

            if (loggedUser.UserId == 1)
            {
                LoadDgvAdmin();
            }
            else
            {
                LoadDgvUser();
            }
        }

        private void cbsIsAvaiable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (loggedUser.UserId == 1)
            {
                SearchByAdmin();
            }
            else
            {
                SearchByUser();
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
                choseBookId = Convert.ToInt32(row.Cells["BookId"].Value);
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnDetails.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnDetails.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = "Add";
            LibraryAction libraryAction = new LibraryAction(this,action,loggedUser)
            {
                Text = "Add Book",
            };
            libraryAction.ShowDialog();
            libraryAction.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            action = "Update";
            LibraryAction libraryAction = new LibraryAction(this, action, loggedUser, choseBookId)
            {
                Text = "Update Book",
            };
            libraryAction.ShowDialog();
            libraryAction.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (choseBookId != 0)
            {
                Book book = context.Books.FirstOrDefault(x => x.BookId == choseBookId);
                if (book != null)
                {
                    book.IsDeleted = true;
                    book.DeletedAt = DateTime.Now;
                    context.SaveChanges();
                }
                if (loggedUser.UserId != 1)
                {
                    LoadDgvUser();
                }
                else
                {
                    LoadDgvAdmin();
                }
                choseBookId = 0;
            }

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            action = "Details";
            LibraryAction libraryAction = new LibraryAction(this, action, loggedUser, choseBookId)
            {
                Text = "Book details ",
            };
            libraryAction.ShowDialog();
            libraryAction.Dispose();
        }
    }
}
