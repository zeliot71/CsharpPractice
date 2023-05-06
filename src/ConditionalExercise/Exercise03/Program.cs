//Write a program that asks the user to enter a password. If the password is "password123", the program should print "Access granted"; otherwise, it should print "Access denied".
string pass = Console.ReadLine();
bool equalPass = pass.Equals("password123");

if (equalPass == true)
{
    Console.WriteLine("Access granted");
}
else
{
    Console.WriteLine("Access denied");
}