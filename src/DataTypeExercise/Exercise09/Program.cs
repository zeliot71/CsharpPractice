// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your birth year: ");
int bYear = int.Parse(Console.ReadLine());
Console.WriteLine($"Your age is: {DateTime.Now.Year - bYear}");
