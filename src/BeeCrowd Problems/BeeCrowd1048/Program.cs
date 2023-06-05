//====BeeCrowd 1048====>
double basic,extra;
basic = double.Parse(Console.ReadLine());

if (basic > 0 && basic <= 400.00)
{
    extra = basic * 0.15;
    basic = extra + basic;

    Console.WriteLine("Novo salario: "+ basic.ToString("0.00"));
    Console.WriteLine("Reajuste ganho: "+ extra.ToString("0.00"));
    Console.WriteLine("Em percentual: 15 %");
}
else if (basic >= 400.01 && basic <= 800.00)
{
    extra = basic * 0.12;
    basic = extra + basic;

    Console.WriteLine("Novo salario: " + basic.ToString("0.00"));
    Console.WriteLine("Reajuste ganho: " + extra.ToString("0.00"));
    Console.WriteLine("Em percentual: 12 %");
}
else if (basic >= 800.01 && basic <= 1200.00)
{
    extra = basic * 0.1;
    basic = extra + basic;

    Console.WriteLine("Novo salario: " + basic.ToString("0.00"));
    Console.WriteLine("Reajuste ganho: " + extra.ToString("0.00"));
    Console.WriteLine("Em percentual: 10 %");
}
else if (basic >= 1200.01 && basic <= 2000.00)
{
    extra = basic * 0.07;
    basic = extra + basic;

    Console.WriteLine("Novo salario: " + basic.ToString("0.00"));
    Console.WriteLine("Reajuste ganho: " + extra.ToString("0.00"));
    Console.WriteLine("Em percentual: 7 %");
}
else if (basic > 2000.00)
{
    extra = basic * 0.04;
    basic = extra + basic;

    Console.WriteLine("Novo salario: " + basic.ToString("0.00"));
    Console.WriteLine("Reajuste ganho: " + extra.ToString("0.00"));
    Console.WriteLine("Em percentual: 4 %");
}




