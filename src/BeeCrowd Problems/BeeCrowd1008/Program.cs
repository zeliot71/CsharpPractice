//==== BeeCrowd 1008 ====>>
//p for PAYMENT,h for HOUR,n for ID NUMBER && tp for TOTAL PAYMENT

double n, h,p,tp;
Console.WriteLine("Enter Number");
n = double.Parse(Console.ReadLine());
Console.WriteLine("Enter your payment per hour");
p = double.Parse(Console.ReadLine());
Console.WriteLine("Enter total hour your worked in month");
h = double.Parse(Console.ReadLine());
tp = p * h;

Console.WriteLine("NUMBER = "+ n);
Console.WriteLine("SALARY = U$ "+ tp);
