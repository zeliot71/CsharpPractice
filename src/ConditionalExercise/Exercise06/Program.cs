//Write a program that asks the user to enter a year and then prints out whether the year is a leap year or not. Hint: A leap year is a year that is divisible by 4, except for years that are divisible by 100 but not by 400.

int Year = int.Parse(Console.ReadLine());


if(Year % 4 == 0 && Year % 100 != 0)
{
    Console.WriteLine("Leap Year!");
}
else if(Year % 400 == 0)
{
    Console.WriteLine("Leap Year!");
}
else
{
    Console.WriteLine("Not Leap Year!");
}
