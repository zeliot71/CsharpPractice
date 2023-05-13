// See https://aka.ms/new-console-template for more information
#region Compare methods
//Compare two strings and return a value indicating whether one is less than, equal to, or greater than the other.

using System.Globalization;
using System.Runtime.Serialization;

string str1 = "Hello World";
string str2 = "Hello_World";
var result = string.Compare(str1, str2);
if(result > 0)
    Console.WriteLine($"{str1} is greater.");
else if(result < 0) 
    Console.WriteLine($"{str2} is greater.");
else
    Console.WriteLine($"{str1} & {str2} boths are equal!");


//Compare two strings ignoring case and return a value indicating whether one is less than, equal to, or greater than the other.

string str3 = "Hello world i'm from Bangladesh!";
string str4 = "hello world i'm from bangladesh!";
var result2 = string.Compare(str3, str4, StringComparison.OrdinalIgnoreCase);
if (result2 > 0)
    Console.WriteLine($"{str3} is greater.");
else if (result2 < 0)
    Console.WriteLine($"{str4} is greater.");
else
    Console.WriteLine($"{str3} & {str4} boths are equal!");


//Compare two strings using a specific culture and return a value indicating whether one is less than, equal to, or greater than the other.
string str5 = "আমি";
string str6 = "তুমি";
CultureInfo culture = new CultureInfo("bn-BD");
var result3 = string.Compare(str6, str4,true,culture);
if (result3 > 0)
    Console.WriteLine("str5 is greater.");
else if (result3 < 0)
    Console.WriteLine($"str6 is greater.");
else
    Console.WriteLine($"{str5} & {str6} boths are equal!");

#endregion

#region CompareOrdinal
//Compare two strings based on their ASCII values and return a value indicating whether one is less than, equal to, or greater than the other.
string string1 = "AMITOMAKEVALOBASHi";
string string2 = "AMITOMAKEVALOBASHI";
var CmprisnResult = string.Compare(string1,string2, StringComparison.Ordinal);
if(CmprisnResult > 0)
{
    Console.WriteLine("String1 is greater!");
}
else if(CmprisnResult < 0)
{
    Console.WriteLine("string2 is greater!");
}
else
    Console.WriteLine("they are equal!");


#endregion