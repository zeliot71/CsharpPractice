//Write a program that asks the user to enter a letter and then prints out whether the letter is a vowel or a consonant.
Console.WriteLine("Enter any letter: ");
string Letter = Console.ReadLine().ToLower();

if (Letter.Length == 1)
{
    char letter = Letter[0];
    switch (Letter)
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("This is a vowel");
            break;
        default:
            Console.WriteLine("This is a consonant!");
            break;
    }
}
else
{
    Console.WriteLine("Please enter only one letter!");
}