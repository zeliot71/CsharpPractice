//=== BeeCrowd 1038 ====>>
int X, Y;
double bill = 0;

string[] input = Console.ReadLine().Split(' ');
X = int.Parse(input[0]);
Y = int.Parse(input[1]);

if (X == 1)
    bill = Y * 4.00;
else if (X == 2)
    bill = Y * 4.50;
else if (X == 3)
    bill = Y * 5.00;
else if (X == 4)
    bill = Y * 2.00;
else if (X == 5)
    bill = Y * 1.50;

Console.WriteLine("Total: R$ " + bill.ToString("0.00"));


