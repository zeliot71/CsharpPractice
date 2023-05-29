// See https://aka.ms/new-console-template for more information

string[] input = Console.ReadLine().Split(' ');
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);
int a = int.Parse(input[2]);

int x = (n + a - 1) / a;
int y = (m + a - 1) / a;

int nmbrOFlagstone = x * y;
Console.WriteLine(nmbrOFlagstone);





