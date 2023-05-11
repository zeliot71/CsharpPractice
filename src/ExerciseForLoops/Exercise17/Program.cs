//Print a multiplication table for a number entered by the user using a do while loop.
Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());
var i = 0;
var sum = 0;
do
{
    i++;
    sum = i *num;
    Console.WriteLine($"{i} * {num} = {sum}");
}
while (i <num);