﻿//==== BeeCrowd Problem 1006 ====>
double a, b, c, media;
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());   
c = double.Parse(Console.ReadLine());

media = (a/10*2)+(b/10 * 3) +(c/10 * 5);
Console.WriteLine("MEDIA = "+ media.ToString("0.0"));