//Write a program that asks the user to enter their age and whether they are a citizen or not. If the user is both over 18 and a citizen, the program should print "You are eligible to vote"; otherwise, it should print "You are not eligible to vote".

Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Are you citizen of Bangladesh?(true/false)");
bool citizenShip = bool.Parse(Console.ReadLine());

if(age> 18 && citizenShip)
{
    Console.WriteLine("You're eligible to vote!");
}
else
{
    Console.WriteLine("You're not eligible to vote!");
}

