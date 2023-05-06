// Write a program that asks the user to enter a number and then prints out "The number is positive" if the number is greater than zero, "The number is negative" if it is less than zero, or "The number is zero" if it is exactly zero.
int num = int.Parse(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine($"{num} is a positive number.");
}
else if(num <0)
{
    Console.WriteLine($"{num} is a negetive number.");
}
else
{
    Console.WriteLine($"{num} is zero!");
}