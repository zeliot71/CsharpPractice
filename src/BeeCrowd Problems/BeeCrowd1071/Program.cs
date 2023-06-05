//== BeeCrowd Problem 1071/Not solved & submitted ===>
int x, y, temp,sum =0;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

if (x < y)
{
    temp = x;
    x = y;
    y = temp;
}
for(x = x+1; x <= y-1; x++)
{
    if (x % 2 == 1 || x % 2 == -1)
        sum += x;
}

Console.WriteLine(sum);


