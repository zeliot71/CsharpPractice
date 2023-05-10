//Print a multiplication table for a number entered by the user using a for loop.
Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());
var multiplication = 0;
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} * {i} = {num*i}");
}