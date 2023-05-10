//Calculate the factorial of a number entered by the user using a for loop.
Console.WriteLine("Enter any number: ");
int number = int.Parse(Console.ReadLine());
var factorial = 1;

for(int i = 1; i <= number; i++)
{
   
    factorial *=i ;
}
Console.WriteLine(factorial);