//==== BeeCrowd 1046 ====>
int x, y;
string[] input = Console.ReadLine().Split(' ');
x = int.Parse(input[0]);
y = int.Parse (input[1]);

var hours = 0;
if (x>y)
{
   hours = (24 - x) + y;
}
else if (x <y)
{
    hours = y-x;
}
else if (x == y)
{
    hours = 24;
}
Console.WriteLine($"O JOGO DUROU {hours} HORA(S)");
