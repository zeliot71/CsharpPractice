//=== BeeCrowd 1037 ====>
float n = float.Parse(Console.ReadLine());
if(n>=0 && n <= 25.0000)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if(n>=25.00001 && n <= 50.00000000)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (n>=50.0000001 && n <= 75.0000000)
{
    Console.WriteLine("Intervalo (50,75]");
}
else if(n >= 75.0000001 && n <= 100)
{
    Console.WriteLine("Intervalo (75,100]");
}
else
{
    Console.WriteLine("Fora de intervalo");
}
