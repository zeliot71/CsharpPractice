// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a decimal number: ");
decimal input  = decimal.Parse(Console.ReadLine());

int intPart = (int)input;
string Binary = Convert.ToString((byte)input, toBase: 2);

if(input % 1 != 0)
{

}