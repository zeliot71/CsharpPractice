// Write a program that calculates the area of a rectangle.
// Ask the user to enter the length and width of the rectangle and then display the result

Console.WriteLine("Enter the length and width of rectangle: ");
var input = Console.ReadLine().Split(' ');
uint length = uint.Parse(input[0]);
uint width = uint.Parse(input[1]);
Console.WriteLine($"The area of rectangle is: {length * width} sqrft");