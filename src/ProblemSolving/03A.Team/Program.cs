// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
var count = 0;
/*
for(int i = 0;i < n; i++)
{
    string[] line = Console.ReadLine().Split(' ');
    int fnd1 = int.Parse(line[0]);
    int fnd2 = int.Parse(line[1]);
    int fnd3 = int.Parse(line[2]);
    if(fnd1 ==1 && fnd2 ==1 && fnd3 == 1 || fnd1 == 1 && fnd2 == 1 || fnd3 ==1 && fnd2 ==1 || fnd1 ==1 && fnd3 ==1)
    {
        count++;
    }
  
}
Console.WriteLine(count);
*/

//alternative

for (int i = 0; i < n; i++)
{
    string[] line = Console.ReadLine().Split(' ');
    for (int j =0; j < line.Length; j++)
    {
        int value = int.Parse(line[j]);
        if (value == 1)
        {
            count++;
        }
    }
}
Console.WriteLine(count);