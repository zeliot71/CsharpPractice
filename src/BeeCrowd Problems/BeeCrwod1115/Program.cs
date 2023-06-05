//== BeeCrowd Problem 1115 / Quadrant ==>
string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

if (a > 0 && b > 0)
    Console.WriteLine("primeiro");
else if (a > 0 && b < 0)
    Console.WriteLine("quarto");
else if (a < 0 && b < 0)
    Console.WriteLine("terceiro");
else if (a < 0 && b > 0)
    Console.WriteLine("segundo");
else if (a == 0 || b == 0)
    return;
Console.ReadLine();