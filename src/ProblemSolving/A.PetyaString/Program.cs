// See https://aka.ms/new-console-template for more information
string str1 = Console.ReadLine().ToLower();
string str2 = Console.ReadLine().ToLower();
var compaRes = str1.CompareTo(str2);

if (compaRes > 0)
{
    Console.WriteLine(1);
}
else if(compaRes == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(-1);
}

