//==== BeeCrowd 1040 ====>>
double a, b, c, d,extra,Media;
string[] input = Console.ReadLine().Split(' ');
a = Convert.ToDouble(input[0]);
b = Convert.ToDouble(input[1]);
c = Convert.ToDouble(input[2]); 
d = Convert.ToDouble(input[3]);
Media = (a * 2 + b * 3 + c * 4 + d * 1) / 10;
Console.WriteLine($"Media: {Media.ToString("0.0")}");
if (Media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (Media < 5.0)
{
    Console.WriteLine("Aluno reprovado.");
}
else if (Media >= 5.0 && Media <= 6.9)
{
    Console.WriteLine("Aluno em exame.");
    extra = double.Parse(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {extra}");
    Media = (Media +extra) / 2;
    if (Media >= 5)
    {
        Console.WriteLine("Aluno aprovado.");
    }
        
    else
    {
        Console.WriteLine("Aluno reprovado.");
        Console.WriteLine("Media final: " + Media.ToString("0.0"));
    }
}


