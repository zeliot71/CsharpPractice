//== BeeCrwod 1043 | Triangle ===>
double a, b, c;
string[] input = Console.ReadLine().Split(' ');
a = Convert.ToDouble(input[0]);
b = Convert.ToDouble(input[1]);
c = Convert.ToDouble(input[2]);

if(a + b > c && b + c > a && c + a > b)
{
    Console.WriteLine($"Perimitro = {(a+b+c).ToString("0.0")}");
}
else
{
    Console.WriteLine($"Area = {(((a + b )* c) / 2).ToString("0.0")}");
}