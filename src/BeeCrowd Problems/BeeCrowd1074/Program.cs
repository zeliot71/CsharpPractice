//== BeeCrowd 1074 Problem===>

int n, y, z;
z = int.Parse(Console.ReadLine()); ;

for (y = 0; y < z; y++)
{
    n = int.Parse(Console.ReadLine());
}
if (n > 0 && n % 2 == 0)
    Console.WriteLine("EVEN POSITIVE");
else if (n > 0 && n % 2 != 0)
    Console.WriteLine("ODD POSITIVE");
else if (n < 0 && n % 2 == 0)
    Console.WriteLine("EVEN NEGATIVE");
else if (n < 0 && n % 2 != 0)
    Console.WriteLine("ODD NEGATIVE");
else if (n == 0)
    Console.WriteLine("NULL");

