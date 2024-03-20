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
    public partial class LibraryAction : Form
    {
        string action;
        User loggedUser;
        Library library = null;
        int choseBookId;
        MyHiredBook myHiredBook = null;
        Prn211dbContext context = new Prn211dbContext();
        public LibraryAction()
        {
            InitializeComponent();
        }
        public LibraryAction(MyHiredBook myHiredBook, string action, User loggedUser, int choseBookId)
        {
            InitializeComponent();

            this.myHiredBook = myHiredBook;
            this.action = action;
            this.loggedUser = loggedUser;

            cbsType.DataSource = context.Types.ToList();
            cbsType.DisplayMember = "Name";
            cbsType.ValueMember = "TypeId";

            Book book = context.Books.Include(x => x.Author)
                .Include(x => x.Type).Include(x => x.Publisher)
                .FirstOrDefault(x => x.BookId == choseBookId);

            btnSave.Visible = false;
            txtBookName.Enabled = false;
            cbsType.Enabled = false;
            txtAuthor.Enabled = false;
            txtPublisher.Enabled = false;
            rtxtDescription.Enabled = false;
            txtHiredBy.Enabled = false;
            txtHireDate.Enabled = false;
            txtReturnDate.Enabled = false;

            txtBookId.Text = book.BookId.ToString();
            cbsType.SelectedValue = book.TypeId;
            txtBookName.Text = book.Name;
            txtAuthor.Text = book.Author.AuthorName;
            txtPublisher.Text = book.Publisher.Name;
            rtxtDescription.Text = book.Description;
            txtHiredBy.Text = book.HiredBy.ToString();
            txtHireDate.Text = book.HiredDate != null ? book.HiredDate.Value.ToString("dd/MM/yyyy") : "";
            txtReturnDate.Text = book.ReturnDate != null ? book.ReturnDate.Value.ToString("dd/MM/yyyy") : "";

        }
        public LibraryAction(Library library, string action, User loggedUser)
        {
            InitializeComponent();

            this.library = library;
            this.action = action;
            this.loggedUser = loggedUser;

            cbsType.DataSource = context.Types.ToList();
            cbsType.DisplayMember = "Name";
            cbsType.ValueMember = "TypeId";

            if (loggedUser.UserId != 1)
            {
                pnAdmin.Visible = false;
            }

        }
        public LibraryAction(Library library, string action, User loggedUser, int choseBookId)
        {
            InitializeComponent();
            this.library = library;
            this.action = action;
            this.loggedUser = loggedUser;
            this.choseBookId = choseBookId;
            cbsType.DataSource = context.Types.ToList();
            cbsType.DisplayMember = "Name";
            cbsType.ValueMember = "TypeId";

            if (loggedUser.UserId != 1)
            {
                pnAdmin.Visible = false;
            }

            Book book = context.Books.Include(x => x.Author)
                .Include(x => x.Type).Include(x => x.Publisher)
                .FirstOrDefault(x => x.BookId == choseBookId);

            if (action == "Details" || action == "Update")
            {
                
                if (action == "Details")
                {
                    btnSave.Visible = false;
                    txtBookName.Enabled = false;
                    cbsType.Enabled = false;
                    txtAuthor.Enabled = false;
                    txtPublisher.Enabled = false;
                    rtxtDescription.Enabled = false;
                    txtHiredBy.Enabled = false;
                    txtHireDate.Enabled = false;
                    txtReturnDate.Enabled = false;
                }

                txtBookId.Text = book.BookId.ToString();
                cbsType.SelectedValue = book.TypeId;
                txtBookName.Text = book.Name;
                txtAuthor.Text = book.Author.AuthorName;
                txtPublisher.Text = book.Publisher.Name;
                rtxtDescription.Text = book.Description;
                txtHiredBy.Text = book.HiredBy.ToString();
                txtHireDate.Text = book.HiredDate != null ? book.HiredDate.Value.ToString("dd/MM/yyyy") : "";
                txtReturnDate.Text = book.ReturnDate != null ? book.ReturnDate.Value.ToString("dd/MM/yyyy") : "";

            }
        }
        private void Add()
        {
            Book book = new Book();

            book.Name = txtBookName.Text;

            book.TypeId = (int)cbsType.SelectedValue;

            book.Description = rtxtDescription.Text;

            string authorName = txtAuthor.Text;
            Author author = context.Authors.FirstOrDefault(x => x.AuthorName == authorName);
            if (author == null)
            {
                author = new Author { AuthorName = authorName };
                context.Authors.Add(author);
                context.SaveChanges();
            }
            book.AuthorId = author.AuthorId;

            string publisherName = txtPublisher.Text;
            Publisher publisher = context.Publishers.FirstOrDefault(x => x.Name == publisherName);
            if (publisher == null)
            {
                publisher = new Publisher { Name = publisherName };
                context.Publishers.Add(publisher);
                context.SaveChanges();
            }
            book.PublisherId = publisher.PublisherId;

            if (txtHiredBy.Text != "")
            {
                book.HiredBy = int.Parse(txtHiredBy.Text);
                book.IsAvailable = true;
            }
            else
            {
                book.HiredBy = null;
                book.IsAvailable = false;
            }

            if (txtHireDate.Text != "")
            {
                book.HiredDate = DateTime.ParseExact(txtHireDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                book.HiredDate = null;
            }

            if (txtReturnDate.Text != "")
            {
                book.ReturnDate = DateTime.ParseExact(txtReturnDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                book.ReturnDate = null;
            }

            context.Books.Add(book);
            context.SaveChanges();
            MessageBox.Show("Add book successfully!");
        }
        private void Update()
        {
            Book book = context.Books.FirstOrDefault(x => x.BookId == choseBookId);

            book.Name = txtBookName.Text;

            book.TypeId = (int)cbsType.SelectedValue;

            book.Description = rtxtDescription.Text;

            string authorName = txtAuthor.Text;
            Author author = context.Authors.FirstOrDefault(x => x.AuthorName == authorName);
            if (author == null)
            {
                author = new Author { AuthorName = authorName };
                context.Authors.Add(author);
                context.SaveChanges();
            }
            book.AuthorId = author.AuthorId;

            string publisherName = txtPublisher.Text;
            Publisher publisher = context.Publishers.FirstOrDefault(x => x.Name == publisherName);
            if (publisher == null)
            {
                publisher = new Publisher { Name = publisherName };
                context.Publishers.Add(publisher);
                context.SaveChanges();
            }
            book.PublisherId = publisher.PublisherId;

            if (txtHiredBy.Text != "")
            {
                book.HiredBy = int.Parse(txtHiredBy.Text);
                book.IsAvailable = true;
            }
            else
            {
                book.HiredBy = null;
                book.IsAvailable = false;
            }

            if (txtHireDate.Text != "")
            {
                book.HiredDate = DateTime.ParseExact(txtHireDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture); 
            }
            else
            {
                book.HiredDate = null;
            }

            if (txtReturnDate.Text != "")
            {
                book.ReturnDate = DateTime.ParseExact(txtReturnDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) ;
            }
            else
            {
                book.ReturnDate = null;
            }

            context.SaveChanges();
            MessageBox.Show("Update book successfully!");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "" || txtAuthor.Text == "" || txtPublisher.Text == "")
            {
                MessageBox.Show("Please fill Book name, author, and publisher!");
                return;
            }

            if (!((txtHireDate.Text == "" && txtHiredBy.Text == "" && txtReturnDate.Text == "")
                || (txtHireDate.Text != "" && txtHiredBy.Text != "" && txtReturnDate.Text != "")))
            {
                MessageBox.Show("HiredBy, HireDate and ReturnDate must be null, or HiredBy, HireDate and ReturnDate must not be null !");
                return;
            }
            
            if (txtHiredBy.Text != "" && int.TryParse(txtHiredBy.Text, out int tempHiredBy))
            {
                if (context.Users.FirstOrDefault(x => x.UserId == tempHiredBy) == null)
                {
                    MessageBox.Show("HiredBy must be a valid id!");
                    return;
                }
            }

            if (txtHireDate.Text != "" && !DateTime.TryParseExact(txtHireDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime tempHireDate))
            {
                MessageBox.Show("HireDate must be in format dd/MM/yyyy!");
                return;
            }

            if (txtReturnDate.Text != "" && !DateTime.TryParseExact(txtReturnDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime tempReturnDate))
            {
                MessageBox.Show("ReturnDate must be in format dd/MM/yyyy!");
                return;
            }

            if (txtHireDate.Text != "" && DateTime.Now.Date != DateTime.ParseExact(txtHireDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Date)
            {
                MessageBox.Show("HireDate must be today!");
                return;
            }

            if (txtHireDate.Text != "" && txtReturnDate.Text != "")
            {
                DateTime hireDate = DateTime.ParseExact(txtHireDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime returnDate = DateTime.ParseExact(txtReturnDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if ((returnDate - hireDate).TotalDays < 7)
                {
                    MessageBox.Show("ReturnDate must be after HireDate at least 7 days!");
                    return;
                }
            }

            if (action == "Add")
            {
                Add();
            }
            else if(action == "Update")
            {
                Update();
            }

            if(action == "Details2")
            {
                myHiredBook.LoadDgv();
            }
            else
            {
                if (loggedUser.UserId == 1)
                {
                    library.LoadDgvAdmin();
                }
                else
                {
                    library.LoadDgvUser();
                }
            }
            this.Close();
        }
    }
}
