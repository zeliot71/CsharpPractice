// See https://aka.ms/new-console-template for more information
using _09ClassExamples;

WaterBottle bottle1 = new WaterBottle(250, "Red");
bottle1.addWater(250.000);

WaterBottle bottle2 = new WaterBottle(500,"Blue");
bottle2.addWater(500);


Console.WriteLine(bottle2.Capacity);
Console.WriteLine(bottle1.Color);