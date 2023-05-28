// See https://aka.ms/new-console-template for more information

using AbstractClassAndInheritenceExample;

Electronics electronics= new Electronics("printer");
electronics.Brand = "Brand";
electronics.Prices = 123015;
electronics.Description = "This is very big big descriptio i've ever seen";
Console.WriteLine(electronics.ShortenDescription());

Book book= new Book("Bela Purabar agee,change yourself!",300);
book.Author = "Arif Azad";
book.Description = "This is very big big descriptio i've ever seen";
Console.WriteLine(book.ShortenDescription());