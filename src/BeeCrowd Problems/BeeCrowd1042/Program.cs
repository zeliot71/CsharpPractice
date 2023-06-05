//===== BeeCrowd 1040 =====>
double a, b, c,i,j,k;
string[] input = Console.ReadLine().Split();
a = int.Parse(input[0]);
b = int.Parse(input[1]);
c = int.Parse(input[2]);
i = a;
j = b;
k = c;
if(a <b && a < c)
{
    if(b < c)
    {
        Console.WriteLine(a.ToString()+"\n"+ b.ToString() + "\n" + c.ToString());
    }
    else
    {
        Console.WriteLine(a.ToString()+ "\n"+c.ToString()+"\n" +b.ToString());
    }
}
else if(b<c&&b < a)
{
    if(a < c)
    {
        Console.WriteLine(b.ToString() + "\n" + a.ToString() + "\n" + c.ToString());
    }
    else
    {
        Console.WriteLine(b.ToString() + "\n" + c.ToString() + "\n" + a.ToString());
    }
}
else if(c<a&& c < b)
{
    if (b < a)
    {
        Console.WriteLine(c.ToString() + "\n" + b.ToString() + "\n" + a.ToString());
    }
    else
    {
        Console.WriteLine(c.ToString() + "\n" + a.ToString() + "\n" + b.ToString());
    }
}
Console.WriteLine();
Console.WriteLine(i.ToString() + "\n" + j.ToString() + "\n" + k.ToString());

