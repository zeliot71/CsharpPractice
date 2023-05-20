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

#region Concat Methods
//Concatenate two or more strings together to create a new string.
var newString = string.Concat(str1,str2,str3);
Console.WriteLine(newString);
#endregion

#region Contains Methods
//Determine whether a string contains a specified substring
var res = str1.Contains("H");
Console.WriteLine(res);

//Determine whether a string contains a specified substring ignoring case
var res2 = str2.Contains("E",StringComparison.OrdinalIgnoreCase);
Console.WriteLine(res2);
#endregion

#region EndsWith Methods
//Determine whether a string ends with a specified suffix.
Console.WriteLine($"{string2} endsWith shi: {string2.EndsWith("Shi")}");

//Determine whether a string ends with a specified suffix ignoring case.
Console.WriteLine($"{string2} endsWith shi: {string2.EndsWith("Shi",StringComparison.OrdinalIgnoreCase)}");
#endregion

#region Format() Methods
//Format a string by replacing placeholders with values.
string name = "Supreme";
int id = 100200;
Console.WriteLine("The id of {0} is {1}", name,id);

//Format a string using a specific culture.
double prices = 456.557561;
CultureInfo culture1 = new CultureInfo("fr-FR");
string formattedString = string.Format(culture1, "The value is {0:N}", prices);
Console.WriteLine(formattedString);
#endregion

#region IndexOf() Methods
//Find the index of the first occurrence of a specified substring within a string.
var index = string2.IndexOf("BASHI");
Console.WriteLine(index);

//Find the index of the first occurrence of a specified substring within a string starting from a specified position.
var indexX = string2.IndexOf("VALO", 5);
Console.WriteLine(indexX);
#endregion

#region IndexOfAny() Methods
//Find the index of the first occurrence of any of a set of specified characters within a string.
string text = "The quick brown fox jumps over the lazy dog.";
char[] indexToFind = { 'a', 'e', 'i', 'o','u'};
var inDex = text.IndexOfAny(indexToFind);
Console.WriteLine(inDex);
//Find the index of the first occurrence of any of a set of specified characters within a string starting from a specified position.
var startingIndex = 10;
var InDex = text.IndexOfAny(indexToFind,startingIndex);
Console.WriteLine(InDex);
#endregion

#region Insert() Methods
string txt = "Hello guys, ey hocche amar bikkhato __";
string subtxt = "khais";
var rslt = txt.Insert(37, subtxt);
Console.WriteLine(rslt);
#endregion

#region IsNullOrEmpty() Methods
string texttt = null;
var resulttt = string.IsNullOrEmpty(texttt);
Console.WriteLine(resulttt); //output: true, karon string null
string texttt2 = " ";
Console.WriteLine(string.IsNullOrEmpty(texttt2));//output: false, karon string whitespace
string texttt3 = "";
Console.WriteLine(string.IsNullOrEmpty(texttt3)); //output: true, karon string Empty

Console.WriteLine(string.IsNullOrWhiteSpace(texttt2)); //Output: true, karon string white spaec
#endregion

#region Join() Methods
//Join an array of strings into a single string with a specified delimiter.

string[] stringArray = { "Hello", "Maisha", "ami", "Tomake", "Valobashi" };
string delimiter = " ";
string joinedString = string.Join(delimiter, stringArray);
Console.WriteLine(joinedString);
#endregion

#region LastIndexOf() Methods
//Find the index of the last occurrence of a specified substring within a string.

string jnstring = "AMi tomake valo bashi na";
string sbstring = "a";
Console.WriteLine(jnstring.LastIndexOf(sbstring));
//Find the index of the last occurrence of a specified substring within a string starting from a specified position.
Console.WriteLine(jnstring.LastIndexOf(sbstring,10));
#endregion

#region PadLeft() Methods
//Pad a string with a specified character or whitespace on the left to a specified length.
string padLeftString = "Hello, ami ekjon artifitial intelligent";
Console.WriteLine(padLeftString);
int padlength = 100;
char paddingChar = '-';
string paddedText = padLeftString.PadLeft(padlength,paddingChar);
Console.WriteLine(paddedText);
string paddedText2 = padLeftString.PadLeft(padlength);
Console.WriteLine(paddedText2);
#endregion

#region Remove() Methods
//Remove a specified number of characters from a string starting at a specified position.
string rmvText = "Hello, anyone from us can be gayeb!";
int strtIndex = 7;
int indexToRemove = 6;
Console.WriteLine(rmvText.Remove(strtIndex, indexToRemove));

#endregion

#region Replace() Methods
string title = "Replace all occurrences of a specified" +
    "\n substring in a string " +
    "\n with a new substring";
string subString = "s";
string newSbstring = "**";
Console.WriteLine(title.Replace(subString,newSbstring));
#endregion

#region ReplaceLineEndings() Methods
//Replace all line endings in a string with a specified string.
string ending = "#";
Console.WriteLine(title.ReplaceLineEndings(ending));

#endregion

#region Split() Methods
string splitString = "Split a string into an array of substrings using a specified delimiter.";
string[] splitArray = splitString.Split(' ');

    Console.WriteLine(splitArray[0]);
#endregion

#region StartsWith() Methods
string strtwith = "Determine whether a string starts with a specified prefix ignoring case";
Console.WriteLine(strtwith.StartsWith("D", StringComparison.OrdinalIgnoreCase));
#endregion

#region SubString() Methods 
string sbstringmthd = "Get a substring of a string starting at a specified position and with a specified length.";
int stpos = 4;
int l = 12;
string nSbstring = sbstringmthd.Substring(stpos, l);
Console.WriteLine(nSbstring);

string sbstringmthd2 = "Get a substring of a string starting at a specified position and continuing to the end of the string.";
int strtpos = 83;
Console.WriteLine(sbstringmthd2.Substring(strtpos));
#endregion

#region Trim() Methods
string stringTrim = "    The quick brown fox jumps over the lazy dog    ";
string newStrigTrim = stringTrim.Trim(' ');
Console.WriteLine("Trimmed String: " +newStrigTrim);
Console.WriteLine("Normal String: "+ stringTrim);
string stringForTrim = "*-*Trim a specified set of characters from the beginning and end of a string*-*";
char[] charForTrim = { '*', '-'};
string trimmedtext = stringForTrim.Trim(charForTrim);
Console.WriteLine(trimmedtext);
#endregion

#region TrimEnd()  Methods

#endregion

#region TrimStart()  Methods

#endregion

#region ToUpper()  Methods

#endregion

#region ToLower()  Methods

#endregion

#region ToCharArray()  Methods

#endregion
