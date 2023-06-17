string[] weights = Console.ReadLine().Split(' ');

int a = int.Parse(weights[0]);
int b = int.Parse(weights[1]);
int Y = 0;

while(a <= b)
    {
        a *= 3;
        b *= 2;
        Y += 1;
    }


Console.WriteLine(Y);