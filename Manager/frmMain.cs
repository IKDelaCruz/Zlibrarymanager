using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BorrowerLibrary;
namespace Manager
{
    public partial class frmMain : Form
    {
        Book _book;
        Borrower _borrower;
        public frmMain()
        {
            _book = new Book();
            _borrower = new Borrower();

            InitializeComponent();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frmLogin();
            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblWelcome.Text = string.Format("Welcome {0}! [{1}]", Program.CurrentBorrower.FirstName,
                    Program.CurrentBorrower.UserType.ToString());

                LoadAvailableBooks();
                LoadBorrowedBook();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void LoadAvailableBooks()
        {
            var list = new MySortableBindingList<Book>(_book.GetAvailableBooks());
            dvAvailable.DataSource = list;
            lblAvailableBooks.Text = "Available Books: " + dvAvailable.Rows.Count;
        }
        private void LoadBorrowedBook()
        {
            var list = new MySortableBindingList<Book>(_book.GetBorrowedBooks(Program.CurrentBorrower.Id));
            dvBorrowed.DataSource = list;
            lblBorrowedBooks.Text = "Borrowed Books: " + dvBorrowed.Rows.Count;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (dvAvailable.SelectedRows.Count != 0)
            {
                var bookId = int.Parse(dvAvailable.SelectedRows[0].Cells[0].Value.ToString());
                var bookTitle = dvAvailable.SelectedRows[0].Cells[2].Value.ToString();

                var result = MessageBox.Show("Are you sure you want to borrow this book (" + bookTitle + ")?", "Simplified Library System", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    Borrow(bookId);
            }
        }
        private void Borrow(int bookId)
        {
            if (_book.Borrow(bookId, Program.CurrentBorrower.Id,
                Program.CurrentBorrower.Email,
                Program.CurrentBorrower.UserType))
            {
                LoadAvailableBooks();
                LoadBorrowedBook();
            }
            else
            {
                MessageBox.Show("Unable to borrow this book! Please review your borrowed books and make sure that you are not over the limit", "Simplified Library System");
            }

        }

        private void initializeBookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to Re-Initialize your Book List and Users? This will clear all user-modified data such as borrowed books and newly created users. Please proceed with caution.", "Simplified Library System", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _book.InitializeBookList();
                _borrower.InitializeBorrower();
            }

        }

        private void initializeBorrowersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dvBorrowed.SelectedRows.Count != 0)
            {
                var bookTitle = dvBorrowed.SelectedRows[0].Cells[2].Value.ToString();
                var result = MessageBox.Show("Are you sure you want to return this book (" + bookTitle + ")?", "Simplified Library System", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _book.Return(int.Parse(dvBorrowed.SelectedRows[0].Cells[0].Value.ToString()));

                    LoadAvailableBooks();
                    LoadBorrowedBook();
                }
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRegister().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvAvailable.SelectedRows[0].DefaultCellStyle.BackColor = Color.Red;
        }
    }
}
