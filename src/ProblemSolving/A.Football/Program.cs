//A. Football
string input = Console.ReadLine();

var danegerous = 0;
var notDangerous = 0;
for(int i = 0; i < input.Length; i++)
{
    //int m = int.Parse(i);
    //if(m == 0)
    //    danegerous++;
    //else if(m == 1)
        notDangerous++;
}
if (notDangerous >= 7)
    Console.WriteLine("No");
else if (danegerous >= 7)
    Console.WriteLine("Yes");