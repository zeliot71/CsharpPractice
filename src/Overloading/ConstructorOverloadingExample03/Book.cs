using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloadingExample03
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book() 
        {
            Title= string.Empty;
            Author= string.Empty;
            Year= 0;
        }
        public Book(string title)
        {
            Title= title;
            Author= string.Empty;
            Year= 0;
        }
        public Book(string title, string author)
        {
            Title= title;
            Author= author;
            Year= 0;
        }
        public Book(int year, string author,string title) 
        {
            Year= year;
            Author= author;
            Title = title;
        }


    }
}
