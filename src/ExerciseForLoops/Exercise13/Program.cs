//Write an infinite loop that prompts the user to enter a number and then prints it back to them.
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
var i = 1;
while(i > 0)
{
    Console.WriteLine(number);
    i++;
    Thread.Sleep(500);
}