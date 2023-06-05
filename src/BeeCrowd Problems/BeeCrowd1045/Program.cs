//== BeeCrowd 1045 ===>
string[] input = Console.ReadLine().Split();
double a = double.Parse(input[0]);
double b = double.Parse(input[1]);
double c = double.Parse(input[2]);

if (b + c <= a)
    Console.WriteLine("NAO FORMA TRIANGULO");
else if (b * b + c * c == a * a)
    Console.WriteLine("TRIANGULO RETANGULO");
else if (b * b + c * c > a * a)
    Console.WriteLine("TRIANGULO OBTUSANGULO");
else if (b * b + c * c < a * a)
    Console.WriteLine("TRIANGULO ACUTANGULO");
else if (a == b && a == c && b == c)
    Console.WriteLine("TRIANGULO EQUILATERO");
else if (a == b || a == c || b == c)
    Console.WriteLine("TRIANGULO ISOSCELES");


