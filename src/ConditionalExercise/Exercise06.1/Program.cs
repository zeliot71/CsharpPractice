//I repeated it another way
double Year = double.Parse(Console.ReadLine());
var step1 = Year / 4;
var step2 = Year / 100;
var step3 = Year / 400;

if(step1 % 1 == 0 && step2 % 1 != 0)
{
    Console.WriteLine("Leap Year!");
}
else if(step3 % 1 == 0)
{
    Console.WriteLine("lEAP yEAR!");
}
else
{
    Console.WriteLine("Not Leap Year!");
}