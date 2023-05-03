// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"The sum of first n'th number is: {n*(n+1)/2}");