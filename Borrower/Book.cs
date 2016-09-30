using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace BorrowerLibrary
{
    public enum BookStatus
    {
        Available,
        Borrowed
    }
    public enum BookType
    {
        Fiction,
        Filipiniana,
        HealthSciences,
        Circulation,
        Reserve
    }
    public class Book
    {
        public int Id { get; set; }
        public BookType Type { get; set; }
        public string Title { get; set; }
        public BookStatus Status { get; set; } //Available, Borrowed
        public int BorrowerId { get; set; }
        public string BorrowerEmail { get; set; }
        public DateTime Due { get; set; }

        private List<Book> bookList;

        public Book()
        {
            bookList = new List<Book>();
        }

        public void InitializeBookList()
        {
            bookList = new List<Book>();
            bookList.Add(new Book { Id = 1, Type = BookType.Circulation, Title = "Title 1 - Circ", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 2, Type = BookType.Circulation, Title = "Title 2 - Circ", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 3, Type = BookType.Circulation, Title = "Title 3 - Circ", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 4, Type = BookType.Circulation, Title = "Title 4 - Circ", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 5, Type = BookType.Circulation, Title = "Title 5 - Circ", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });

            bookList.Add(new Book { Id = 6, Type = BookType.Fiction, Title = "Title 1 - F", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 7, Type = BookType.Fiction, Title = "Title 2 - F", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 8, Type = BookType.Fiction, Title = "Title 3 - F", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 9, Type = BookType.Fiction, Title = "Title 4 - F", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 10, Type = BookType.Fiction, Title = "Title 5 - F", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });

            bookList.Add(new Book { Id = 11, Type = BookType.Filipiniana, Title = "Title 1 - Filipiniana", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 12, Type = BookType.Filipiniana, Title = "Title 2 - Filipiniana", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 13, Type = BookType.Filipiniana, Title = "Title 3 - Filipiniana", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 14, Type = BookType.Filipiniana, Title = "Title 4 - Filipiniana", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 15, Type = BookType.Filipiniana, Title = "Title 5 - Filipiniana", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });

            bookList.Add(new Book { Id = 16, Type = BookType.HealthSciences, Title = "Title 1 - HealthSciences", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 17, Type = BookType.HealthSciences, Title = "Title 2 - HealthSciences", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 18, Type = BookType.HealthSciences, Title = "Title 3 - HealthSciences", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 19, Type = BookType.HealthSciences, Title = "Title 4 - HealthSciences", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 20, Type = BookType.HealthSciences, Title = "Title 5 - HealthSciences", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });

            bookList.Add(new Book { Id = 21, Type = BookType.Reserve, Title = "Title 1 - Reserve", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 22, Type = BookType.Reserve, Title = "Title 2 - Reserve", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 23, Type = BookType.Reserve, Title = "Title 3 - Reserve", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 24, Type = BookType.Reserve, Title = "Title 4 - Reserve", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });
            bookList.Add(new Book { Id = 25, Type = BookType.Reserve, Title = "Title 5 - Reserve", Status = BookStatus.Available, BorrowerId = 0, Due = DateTime.MinValue });

            string json = JsonConvert.SerializeObject(bookList);
            File.WriteAllText(Environment.CurrentDirectory + "\\books.txt", json);
        }
        public void LoadBooks()
        {
            var json = File.ReadAllText(Environment.CurrentDirectory + "\\books.txt");
            bookList = JsonConvert.DeserializeObject<List<Book>>(json);
        }
        public void SaveBooks()
        {
            string json = JsonConvert.SerializeObject(bookList);
            File.WriteAllText(Environment.CurrentDirectory + "\\books.txt", json);
        }

        public bool Borrow(int bookId, int borrowerId, string borrowerEmail, BorrowerType userType)
        {
            var book = bookList.FirstOrDefault(h => h.Id == bookId);

            if (book.Type == BookType.Fiction && MaxLimitFiction(borrowerId, userType))
                return false;
            if (book.Type == BookType.Reserve && MaxLimitReserved(borrowerId, userType))
                return false;
            if (book.Type != BookType.Reserve && book.Type != BookType.Fiction && MaxLimitOthers(borrowerId, userType))
                return false;

            if (book.Status == BookStatus.Available)
            {
                book.Status = BookStatus.Borrowed;
                book.BorrowerId = borrowerId;
                book.BorrowerEmail = borrowerEmail;
                book.Due = GetDueDate(bookId);
                SaveBooks();

                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Return(int bookId)
        {
            var book = bookList.FirstOrDefault(h => h.Id == bookId);
            if (book.Status == BookStatus.Borrowed)
            {
                book.Status = BookStatus.Available;
                book.BorrowerId = 0;
                book.BorrowerEmail = "";
                book.Due = DateTime.MinValue;
                SaveBooks();
            }
            return true;
        }

        public List<Book> GetAvailableBooks()
        {
            if (bookList.Count() == 0)
                LoadBooks();

            return bookList.Where(h => h.Status == BookStatus.Available).ToList();
        }
        public List<Book> GetBorrowedBooks(int BorrowerId)
        {
            if (bookList.Count() == 0)
                LoadBooks();

            return bookList.Where(h => h.Status == BookStatus.Borrowed && h.BorrowerId == BorrowerId).ToList();
        }

        private DateTime GetDueDate(int bookId)
        {
            var book = bookList.FirstOrDefault(h => h.Id == bookId);
            if (book.Type == BookType.Circulation)
                return DateTime.Now.AddDays(14);
            else if (book.Type == BookType.Reserve)
                return DateTime.Now.AddDays(1).Date.AddHours(10);
            else
                return DateTime.Now.AddDays(7);

        }

        public bool MaxLimitFiction(int borrowerId, BorrowerType userType)
        {
            int BorrowedFiction = bookList.Where(h => h.BorrowerId == borrowerId && h.Type == BookType.Fiction).Count();
            if (BorrowedFiction < 3)
                return false;
            else
                return true;
        }
        public bool MaxLimitReserved(int borrowerId, BorrowerType userType)
        {
            int BorrowedReserved = bookList.Where(h => h.BorrowerId == borrowerId && h.Type == BookType.Reserve).Count();
            if (BorrowedReserved < 1 && userType == BorrowerType.Student)
                return false;
            else if (BorrowedReserved < 2 && userType != BorrowerType.Student)
                return false;
            else
                return true;
        }
        public bool MaxLimitOthers(int borrowerId, BorrowerType userType)
        {
            int BorrowedOthers = bookList.Where(h => h.BorrowerId == borrowerId && h.Type != BookType.Reserve && h.Type != BookType.Fiction).Count();
            if (BorrowedOthers < 5 && userType == BorrowerType.Faculty)
                return false;
            else if (BorrowedOthers < 3 && userType != BorrowerType.Faculty)
                return false;
            else
                return true;
        }
    }
}
