// k - prices of per pcs banana
//n - the dollar he has
//w - the number of banana he want to buy

string[] line = Console.ReadLine().Split(' ');
int k = int.Parse(line[0]);
int n = int.Parse(line[1]);
int w = int.Parse(line[2]);

int TotalK = 0;

for(int i = 1; i <= w; i++)
{
    TotalK += k * i;
}
if (TotalK < n)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(TotalK - n);
}
