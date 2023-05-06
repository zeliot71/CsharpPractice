//Write a program that asks the user to enter their age and then prints out "You are an adult" if the user is over 18, or "You are a minor" if they are 18 or younger.
int age = int.Parse(Console.ReadLine());
if(age > 18)
{
    Console.WriteLine("You're an adult!");
}
else if(age<=18)
{
    Console.WriteLine("You're a minor!");
}