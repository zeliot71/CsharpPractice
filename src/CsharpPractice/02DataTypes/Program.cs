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


////Task 01 for basic data type practice ---->>
//Console.WriteLine("Enter your name: ");
//var name = Console.ReadLine();
//Console.WriteLine("Enter your age: ");
//uint age = uint.Parse(Console.ReadLine());
//Console.WriteLine($"Hello {name}, you are {age} years old!");
////task02
//Console.WriteLine("Enter the length: ");
//uint length = uint.Parse(Console.ReadLine());
//Console.WriteLine("Enter the width: ");
//uint width = uint.Parse(Console.ReadLine());
//var aRectangle = length * width;
//Console.WriteLine($"The area of rectangel is : {aRectangle} sqrft!");
////task 03
//Console.WriteLine("Enter a integer Number: ");
//int number = int.Parse(Console.ReadLine()); 
//if(number % 2 == 0)
//{
//    Console.WriteLine("Your number is Even!");
//}
//else
//{
//    Console.WriteLine("Your number is ODD!");
//}
//Task 04
//Console.WriteLine("Enter the Temp in Farenhite: ");
//double f = double.Parse(Console.ReadLine());
//double celcius = f - 32 * 0.5555555556;
//Console.WriteLine($"The Temp is {celcius} Degree Celcius!");
//Task 07
//Console.WriteLine("Enter the number n: ");
//int n = int.Parse(Console.ReadLine());
//var sn = (n * (n + 1)) / 2;
//Console.WriteLine(sn);
//task 09
//Console.WriteLine("Enter your birth year");
//int bYear = int.Parse(Console.ReadLine());
//int year = DateTime.Now.Year;
//var age = year - bYear;
//Console.WriteLine(age);


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

//using System.Security.Cryptography;

//Console.WriteLine("Enter a decimal Number: ");
//decimal decIn = decimal.Parse(Console.ReadLine());

//string BinaryNumber = "";
//BinaryNumber += Convert.ToString((int)decIn, toBase: 2);

//if(decIn % 1 != 0)
//{
//    decimal FractionPart = decIn % 1;
//    BinaryNumber += ".";

//    for (int i= 0; i < 10; i++)
//    {
//        FractionPart *= 2;
//        BinaryNumber += ((int)FractionPart).ToString();
//        FractionPart -= (int)FractionPart;
//    }
//}
//Console.WriteLine(BinaryNumber);


