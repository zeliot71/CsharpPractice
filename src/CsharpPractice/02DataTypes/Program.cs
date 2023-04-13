// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//boolean type
bool isTrue = false;

//integer type
int age;
age = 22;

Console.WriteLine(age);

//Floating point 
float r = 3.00f;

//doouble type 
double pi = 3.141592653589793238;

//decimal type
decimal dec = 0.12542654224235m;

//charecter type
char c = 'a';

//string type
string greetings = "Hi everyone!";

//object type: The base of all other type 
object obj = "Hello world";

//Nullable types
int? nulllableNUm = null;

//To assign a value to a nullable type, you can use the null coalescing operator "??"
//Example: 
int num = nulllableNUm ?? 42;
Console.WriteLine(num);