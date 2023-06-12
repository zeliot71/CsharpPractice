// Class13 [1:26:25 - 1:44:00]


using System.Xml.Linq;

int? x = null;
//reference type var'k sorasori null declare kora jai, kintu value type er khetre hoina ? use korte hoi
string? Name = null;

DateTime? Date = null;

x = 5;
Name = "Zihad";

if (x.HasValue)
{
    Console.WriteLine(x.Value);
}
//we should check weather a variable is null or not by using this syntax

int y = x ?? 5;
//Null Coalasceaing operator: etar mane x jodi null hoi tahole y = 5; or x er man y te assign hobe
//eta nullable var er upr applicable

int? z = 10;
z ??= 5;
//etar mane z er value null hole z = 5; r joid null na hoi ja ache ta thakbe
//eta non nullable typer upor o applicable



