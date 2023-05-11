//Calculate the sum of the digits of a number entered by the user using a while loop.
Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());

var sum = 0;
while (num > 0)
{
    int digit = num % 10;
    sum+= digit;
    num /= 10;
}
Console.WriteLine(sum);