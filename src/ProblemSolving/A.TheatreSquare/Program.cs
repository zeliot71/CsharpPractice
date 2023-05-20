// See https://aka.ms/new-console-template for more information

string[] input = Console.ReadLine().Split(' ');
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);
int a = int.Parse(input[2]);

int vFlagstone = 0;
var count = 0;
int aTheatre = n * m;
int aFlagstone = a * a;
if (aTheatre == 1)
{
    Console.WriteLine(1);
}
else
{
    while (true)
    {
        vFlagstone = count * aFlagstone;
        count++;
        if (vFlagstone >= aTheatre)
            break;
    }
    Console.WriteLine(count);

}





