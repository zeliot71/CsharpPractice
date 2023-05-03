//Create a program that asks the user to enter a number and then displays whether it is even or odd.

Console.WriteLine("Enter a number: ");
int input =  int.Parse(Console.ReadLine());

if(input % 2 == 0)
{
    Console.WriteLine($"{input} is a Even number!");
}
else
{
    Console.WriteLine($"{input} is a Odd number!");
}