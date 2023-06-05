//=== BeeCrowd Problem No 1142 ===>
int i, j, n;
n = int.Parse(Console.ReadLine());

for ( i = 1;i <= (4*n -1); i+=4)
{
   for(j = i; j <= i+2; j++)
    {
        Console.Write(j );
    }
   Console.WriteLine("PUM");
}
Console.ReadLine();
