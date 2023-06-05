// === BeeCrowd 1036 ===>>
double a, b, c, x, y, z;
string[] input = Console.ReadLine().Split(' ');
a = double.Parse(input[0]);
b = double.Parse(input[1]);
c = double.Parse(input[2]);
z = (b * b) - (4 * a * c);
if (z< 0)
{
    Console.WriteLine("Impossivel calcular");
}
else if(a== 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    x = (-b+Math.Sqrt(z))/(a+a);
    y = (-b-Math.Sqrt(z))/(a+a);
    Console.WriteLine("R1 = "+ x.ToString("0.00000"));
    Console.WriteLine("R2 = "+ y.ToString("0.00000"));
}
