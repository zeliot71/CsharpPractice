// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();
string newStr = new string(input.Distinct().ToArray());

int gender = newStr.Length;

if (gender % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}
