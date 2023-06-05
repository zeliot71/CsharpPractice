//==== Beecrowd 1021 ====>>
double m = double.Parse(Console.ReadLine());
int x = Convert.ToInt32(m * 100);
Console.WriteLine("NOTAS:");
Console.WriteLine($"{x / 10000} nota(s) de R$ 100,00");
x = x % 10000;
Console.WriteLine($"{x / 5000} nota(s) de R$ 50,00");
x = x % 5000;
Console.WriteLine($"{x / 2000} nota(s) de R$ 20,00");
x = x % 2000;
Console.WriteLine($"{x / 1000} nota(s) de R$ 10,00");
x = x % 1000;
Console.WriteLine($"{x / 500} nota(s) de R$ 5,00");
x = x % 500;
Console.WriteLine($"{x / 200} nota(s) de R$ 2,00");
x = x % 200;
Console.WriteLine("MOEDAS:");

Console.WriteLine($"{x / 100} moeda(s) de R$ 1.00");
x = x % 100;
Console.WriteLine($"{x / 50} moeda(s) de R$ 0.50");
x = x % 50;
Console.WriteLine($"{x / 25} moeda(s) de R$ 0.25");
x = x % 25;
Console.WriteLine($"{x / 10} moeda(s) de R$ 0.10");
x = x % 10;
Console.WriteLine($"{x / 5} moeda(s) de R$ 0.05");
x = x % 5;
Console.WriteLine($"{x} moeda(s) de R$ 0.01");