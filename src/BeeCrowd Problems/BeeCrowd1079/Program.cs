//== BeeCrwod 1079 ===>
int i, n;
string[] input;
float a, b, c, total;
n = int.Parse(Console.ReadLine());

for (i = 0; i <= n; i++)
{
    input = Console.ReadLine().Split(' ');
    
    a = float.Parse(input[0]);
    b = float.Parse(input[1]);
    c = float.Parse(input[2]);
    total = ((float)(a * 2.0 + b * 3.0 + c * 5.0));
    Console.WriteLine($"{(total/10).ToString("0.0")}");

}


