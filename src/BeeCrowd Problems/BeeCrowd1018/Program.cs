//==== BeeCrowd 1018 ===>
int x;
x = int.Parse(Console.ReadLine());
Console.WriteLine(x);

Console.WriteLine($"{x/100} nota(s) de R$ 100,00");
x = x % 100;
Console.WriteLine($"{x / 50} nota(s) de R$ 50,00");
x = x % 50;
Console.WriteLine($"{x / 20} nota(s) de R$ 20,00");
x = x % 20;
Console.WriteLine($"{x/10} nota(s) de R$ 10,00");
x = x % 10;
Console.WriteLine($"{x/5} nota(s) de R$ 5,00");
x = x % 5;
Console.WriteLine($"{x / 2} nota(s) de R$ 2,00");
x = x % 2;
Console.WriteLine($"{x} nota(s) de R$ 1,00");
