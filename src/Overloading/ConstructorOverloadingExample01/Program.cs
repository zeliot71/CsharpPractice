// See https://aka.ms/new-console-template for more information
using ConstructorOverloadingExample01;

Rectangle rectangle1 = new Rectangle();
int area1 = rectangle1.CalculateArea();

Rectangle rectangle2  = new Rectangle(10,50);
int area2 = rectangle2.CalculateArea();

Rectangle rectangle3 = new Rectangle(10);
int area3 = rectangle3.CalculateArea();

Console.WriteLine(area1);
Console.WriteLine(area2);
Console.WriteLine(area3);
