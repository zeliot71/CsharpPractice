using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    public class Book
    {
        public string Title{ get; set; }
        public string Author{ get; set; }
        public int Year{ get; set; }
    }
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
       
        public void AddBook(string title, string author, int year)
        {
            Book book = new Book
            {
                
                Title = title,
                Author = author,
                Year = year
            };
            Books.Add(book);
        }

        public List<Book> SearchByTitle(string title)
        {
            title = title.ToLower();
            return Books.FindAll(book => book.Title.ToLower().Contains(title));
        }
        public List<Book> SearchByAuthor(string author)
        {
            author = author.ToLower();
            return Books.FindAll(book => book.Author.ToLower().Contains(author));
        }
        public void DisplayCatalog()
        {
            foreach (Book book in Books)
            {
                    Console.WriteLine("Title: "+ book.Title);
                    Console.WriteLine("Author: "+ book.Author);
                    Console.WriteLine("Year: "+ book.Year);
                    Console.WriteLine("-----------------------");
            }
        }
    }
}
