// See https://aka.ms/new-console-template for more information
string[] s = Console.ReadLine().Split('+');
int[] newS = new int[s.Length];

for(int i = 0; i < s.Length; i++)
{
    newS[i] = int.Parse(s[i]);
   
}
Array.Sort(newS);
string resulut = string.Join("+", newS);
Console.WriteLine(resulut);
