//=== BeeCrowd 1041 ===>
double x, y;
string[] input = Console.ReadLine().Split(' ');
x = double.Parse(input[0]);
y = double.Parse(input[1]);

if (x == 0.0)
{
    if (y == 0.0)
        Console.WriteLine("Origem");
    else
        Console.WriteLine("Exio Y");
}
else if (y == 0.0)
{
    if (x == 0.0)
        Console.WriteLine("Origem");
    else
        Console.WriteLine("Exio X");
}
else if (x < 0.0 && y < 0.0)
{
    Console.WriteLine("Q3");
}
else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("Q1");
}
else if(x > 0.0 && y < 0.0)
{
    Console.WriteLine("Q4");
}
else if(y > 0.0 && x < 0.0)
{
    Console.WriteLine("Q2");
}
