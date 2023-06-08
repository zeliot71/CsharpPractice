// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
//StrinBuilder somporke duita kotha: (1) Ey method string Manipulation/Modification er jonno use hoi (2) 



//String'k jokhon amra copy kori seta value copy korena eta mainly new onno ekta string create kore
//bar bar evabe string create korle devices er memory consume beshi hobe so String builder use kora jai

StringBuilder builder = new StringBuilder();

builder.Append("Hello");
builder.Append(" World");

String final = builder.ToString();
Console.WriteLine(final);

//We can also use it to solve problem in competetive programming where string's character need to modify or put into variables[i]
//mane index dhore kono ekta value change korte parbo
builder[5] = 'Z';