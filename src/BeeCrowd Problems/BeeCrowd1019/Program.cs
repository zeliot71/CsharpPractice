//====BeeCrowd 1019 ====>
int seconds, min, hours;
    seconds = int.Parse(Console.ReadLine());
hours = seconds / 3600;
seconds = seconds % 3600;
min = seconds / 60;
seconds = seconds % 60;
Console.WriteLine($"{hours}:{min}:{seconds}");
