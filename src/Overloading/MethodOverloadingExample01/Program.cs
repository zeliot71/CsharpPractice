// See https://aka.ms/new-console-template for more information
using MethodOverloadingExample01;

Calculator calculator = new Calculator();
int sum1 = calculator.Add(5,3);
int sum2 = calculator.Add(5,3,2);
double sum3 = calculator.Add(5.84665, 3.384651);
int sum4 = calculator.Add(new int[] { 1, 2, 3, 4, 5, 6 });

Console.WriteLine(sum1);
Console.WriteLine(sum2);
Console.WriteLine(sum3);
Console.WriteLine(sum4);