//Create a program that asks the user to enter their name and age.
//Then, display a message that says "Hello [name], you are [age] years old!".

Console.WriteLine("Enter your name and Age: ");
var input = Console.ReadLine().Split(' ');

string name = input[0];
uint age = uint.Parse(input[1]);

Console.WriteLine($"Hello {name}, you are {age} years old!");
