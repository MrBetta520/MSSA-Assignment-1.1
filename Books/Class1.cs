using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Books
{
    public enum Department
    {
        Arts,
        Business,
        Children,
        Religion,
        Comics,
        Technology,
        Crafts,
        Education,
        Engineering,
        Health,
        History,
        Humor,
        Law,
        Fiction,
        Medical,
        Politics,
        Romance,
        Sports,
        Travel
    }
    public class Book
    {
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public float Price { get; set; }
        public Department Department { get; set; }
        public string Url { get; set; }
    }

    public class BookCart
    {
        private List<Book> bookslist;

        public BookCart()
        {
            bookslist = new List<Book>() { new Book() { ISBN = "0805047905", BookName = "Brown Bear, Brown Bear, What Do You See?", AuthorName ="Bill Martin", Price=5.36f, Department = Department.Children, Url = "https://images-na.ssl-images-amazon.com/images/I/51430n+9jlL._SX355_BO1,204,203,200_.jpg" },
                                           new Book() { ISBN = "7519852565", BookName = "Will", AuthorName = "Will Smith", Price = 14.99f, Department = Department.Fiction, Url = "https://m.media-amazon.com/images/I/61gS6EWmWwL.jpg"} };
        }

        public List<Book> GetBooks()
        {
            return bookslist;
        }
        public void AddBook(string isbn, string name, string author, float price, Department department, string url)
        {
            Book newBook = new Book();
            newBook.ISBN = isbn;
            newBook.BookName = name;
            newBook.AuthorName = author;
            newBook.Price = price;
            newBook.Department = department;
            newBook.Url = url;

            bookslist.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            bookslist.RemoveAt(id);
        }
    }
}
