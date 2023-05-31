// See https://aka.ms/new-console-template for more information
string input =Console.ReadLine();
string firstLetter = input.Substring(0,1).ToUpper();

string result =firstLetter+ input.Remove(0,1);
Console.WriteLine(result);