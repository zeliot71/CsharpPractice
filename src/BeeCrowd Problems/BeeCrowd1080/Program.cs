//== BeeCrowd Problem 1080 ==>
int i, n, p, j = 0;
for(i = 0; i <=100; i++)
{
    n = int.Parse(Console.ReadLine());
    if (n > j)
    {
        j = n;
        p = i;
    }
       
}
Console.WriteLine(j);
Console.WriteLine(p);