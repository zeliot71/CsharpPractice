//Write a program that asks the user to enter three numbers and then prints out the smallest of the three.
string[] numbers = Console.ReadLine().Split(' ');
int num1 = int.Parse(numbers[0]);
int num2 = int.Parse(numbers[1]);
int num3 = int.Parse(numbers[2]);

if(num1 < num2 && num1 < num3)
{
    Console.WriteLine($"{num1} is the smallest!");
}
else if(num2 < num3 && num2 < num1)
{
    Console.WriteLine($"{num2} is the smallest!");
}
else
{
    Console.WriteLine($"{num3} is the smallest!");
}

