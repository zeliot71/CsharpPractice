//===BeeCrowd 1020 =====>
int days, months, year;
    days = int.Parse(Console.ReadLine());

Console.WriteLine($"{year = days / 365} ano(s)");
days = days % 365;
Console.WriteLine($"{months = days / 30} mes(es)");
days = days % 30;
Console.WriteLine($"{days} dia(s)");