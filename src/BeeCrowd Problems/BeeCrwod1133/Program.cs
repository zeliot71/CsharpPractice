//== BeeCrowd 1133 Rest of Division ==>
var x = int.Parse(Console.ReadLine());
var y = int.Parse(Console.ReadLine());
var temp =0;
if (x > y)
{
    temp = x;
    x = y;
    y = temp;
}
for (int i= x; i <y; i++)
{
  if (i % 5 == 2 || i % 5 == 3)
      Console.WriteLine(i);
}

