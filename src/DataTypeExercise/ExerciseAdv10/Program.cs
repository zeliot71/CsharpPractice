//Advance 01

Console.WriteLine("Enter any string: ");
var input = Console.ReadLine();

if(double.TryParse(input, out var value))
{
    Console.WriteLine($"The parsed double value is: {input}");
}
else
{
    Console.WriteLine("The input is not a valid input!");
}

