//Calculate the factorial of a number entered by the user using a do while loop.
Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());
var sum = 0;
var i = 1;
do
{
    i++;
    sum += num;
}
while (i<=num);
Console.WriteLine(sum);