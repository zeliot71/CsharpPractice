//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
////boolean type
//bool isTrue = false;

////integer type
//int age;
//age = 22;

//Console.WriteLine(age);

////Floating point 
//float r = 3.00f;

////doouble type 
//double pi = 3.141592653589793238;

////decimal type
//decimal dec = 0.12542654224235m;

////charecter type
//char c = 'a';

////string type
//string greetings = "Hi everyone!";

////object type: The base of all other type 
//object obj = "Hello world";

////Nullable types
//int? nulllableNUm = null;

////To assign a value to a nullable type, you can use the null coalescing operator "??"
////Example: 
//int num = nulllableNUm ?? 42;
//Console.WriteLine(num);


//Task 01 for data type practice ---->>
/*
 var input = Console.ReadLine();
int number;
bool isNumeric = int.TryParse(input, out number);

if (isNumeric)
{
    
    Console.WriteLine(convert.ToDouble(input));
}
else
{
    Console.WriteLine("Enter a valid number!");
}

//Format exception!
//Updated one-->
var input = Console.ReadLine();
int number;

if (int.TryParse(input, out number))
{
    Console.WriteLine(convert.ToDouble(input));
}
else
{
    Console.WriteLine("Enter a valid number!");
}
*/

//Task02 ========>

Console.WriteLine("Enter a decimal number: ");
decimal DecInput = decimal.Parse(Console.ReadLine());

string BinaryOutput = "";

BinaryOutput += Convert.ToString((int)DecInput, toBase: 2);

if(DecInput % 1 != 0)
{
    decimal fractionalPart = DecInput % 1;
    BinaryOutput += ".";

    for(int i =0; i<10; i++)
    {
        fractionalPart *= 2;
        BinaryOutput += ((int)fractionalPart).ToString();
        fractionalPart -= (int)fractionalPart;
    }
}
Console.WriteLine(BinaryOutput);