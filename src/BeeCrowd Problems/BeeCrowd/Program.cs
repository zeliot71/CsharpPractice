using System;

class URI
{

    static void Main(string[] args)
    {
        int a, b, c;
        string[] input = Console.ReadLine().Split(' ');
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        c = int.Parse(input[2]);
        if(a>b && a >c)
        {
            Console.WriteLine($"{a} eh o maior");
        }
        else if(b>c && b>a)
        {
            Console.WriteLine($"{b} eh o maior");
        }
        else
        {
            Console.WriteLine($"{c} eh o maior");
        }
       

    }

}