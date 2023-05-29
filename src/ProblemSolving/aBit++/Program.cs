// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
var X = 0;
for (int i = 1; i <= n; i++)
{
    string input = Console.ReadLine();
    if (input.Contains('+'))
    {
        X++;
    }
    else if (input.Contains('-'))
    {
        X--;
    }
   
}
Console.WriteLine(X);
