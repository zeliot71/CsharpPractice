//=== BeeCrowd 1064 ====>
float n,sum = 0;
int count = 0;
for (int i = 0; i < 6; i++)
{
    n = float.Parse(Console.ReadLine());
    if (n > 0)
    {
        count++;
        sum += n;
        
    }
}
Console.WriteLine($"{count} valores positivos");
Console.WriteLine((sum/count).ToString("0.0"));


