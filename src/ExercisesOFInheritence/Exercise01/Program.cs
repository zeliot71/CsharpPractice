// See https://aka.ms/new-console-template for more information
using System;
using Exercise01;
static void Main()
{
    Circle circle = new Circle(20);
    double areaCircle = circle.CalculateArea();
    Console.WriteLine(areaCircle);

    Rectangle rectangle = new Rectangle(10, 20);
    double areaRectangle = rectangle.CalculateArea();
    Console.WriteLine(areaRectangle);

    Triangle triangle = new Triangle(20, 40);
    double areaTriangle = triangle.CalculateArea();
    Console.WriteLine(areaTriangle);
}
class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }

}
