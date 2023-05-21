// See https://aka.ms/new-console-template for more information
using Exercise05;
Library library = new Library();

library.AddBook("Title1", "Author1", 2000);
library.AddBook("Title2", "Author2", 2005);
library.AddBook("Title3", "Author3", 2001);

List<Book> booksWithTitle = library.SearchByTitle("title");
foreach(Book book in booksWithTitle)
{
    Console.WriteLine("Book with title: "+ book.Title);
}

List<Book> booksWithAuthor = library.SearchByAuthor("author");
foreach(Book book in booksWithAuthor)
{
    Console.WriteLine("Book with author: "+book.Author);
}

library.DisplayCatalog();