int n = int.Parse(Console.ReadLine());
string stones = Console.ReadLine();

int count = 0;
for (int i = 1; i < n; i++)
{
    if (stones[i] == stones[i - 1])
    {
        count++;
    }
}

Console.WriteLine(count);