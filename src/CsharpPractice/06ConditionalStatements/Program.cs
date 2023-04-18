// See https://aka.ms/new-console-template for more information

#region if condition
int y = 10;
if (y > 10 || y >= 10)
{
    Console.WriteLine("Y is greater");
}
#endregion

#region else if condition
int x = 5;
if (x > 10)
{
    Console.WriteLine("X is Greater than 10!");
}
else
{
    Console.WriteLine("X is less than 10!");
}
#endregion

#region if, else if, else condition
int m = 10;

if (m > 10 || m < 10)
{
    Console.WriteLine("Duitar ekta true!");
}
else if (m == 0)
    Console.WriteLine("M er man zero!");
else
    Console.WriteLine("M er man onno kichu!");

#endregion

#region Switch statement
var ex = 0;
switch (ex) 
{
    case 1:
        Console.WriteLine("Dighi");
        break;
    case 2:
        Console.WriteLine("Sharmin");
        break;
    case 3:
        Console.WriteLine("Rafi");
        break;
    case 4:
        Console.WriteLine("Shompa");
        break;
    case 5:
        Console.WriteLine("Salma");
        break;
    case 6:
        Console.WriteLine("Tabassum");
                break;
        case 7:
        Console.WriteLine("Juma");
        break;
        default:
        Console.WriteLine("Sadia");
        break;
}
#endregion

