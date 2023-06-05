//== BeeCrowd 1044 ===>
string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
if (a < b)
{
    var temp = a;
    a = b;
    b = temp;
}
if (a % b == 0)
    Console.WriteLine("Sao multiplos");
else
    Console.WriteLine("Nao sao Multiplos");
 