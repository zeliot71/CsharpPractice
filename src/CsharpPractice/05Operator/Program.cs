// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Increment/Decrement operator
//Post increment
int i = 3;
Console.WriteLine(i); //output 3
Console.WriteLine(i++); //output 3
Console.WriteLine(i); //output 4
//Post decrement
int j = 4;
Console.WriteLine(j); //output 3
Console.WriteLine(j--); //output 3
Console.WriteLine(j); //output 2
//Pre increment
double d = 1.5;
Console.WriteLine(d); //output 1.5
Console.WriteLine(++d); //output 2.5
Console.WriteLine(d); //output 2.5

//Pre decrement
double b = 3.25;
Console.WriteLine(b); //output 3.25
Console.WriteLine(--b); //output 2.25
Console.WriteLine(b); //output 2.25

#endregion

#region Unary plus and minus operator
Console.WriteLine(+4); //output 4
Console.WriteLine(-4); //output -4
Console.WriteLine(-(-4)); //output 4
#endregion

#region Math operators
Console.WriteLine(5*2); //output 10
Console.WriteLine(0.5 * 2.5); //output 1.5
Console.WriteLine(0.1m * 23.4m); //output 2.34

Console.WriteLine(13/5); //output: 2
Console.WriteLine(-13/5); //output: -2
Console.WriteLine(13 / -5); // output: -2
Console.WriteLine(-13 / -5); // output: 2

Console.WriteLine(16.8f /4.1f ); // output: 4.097561
Console.WriteLine(16.8d / 4.1d); // output: 4.09756097560976
Console.WriteLine(16.8m / 4.1m); // output: 4.09756097560975609756097560

Console.WriteLine(5 % 4); // output: 1
Console.WriteLine(5 % -4); // output: 1
Console.WriteLine(-5 % 4); // output: -1
Console.WriteLine(-5 % -4); // output: -1

Console.WriteLine(-5.2f % 2.0f); // output: -1.2
Console.WriteLine(5.9 % 3.1); // output: 2.8
Console.WriteLine(5.9m % 3.1m); // output: 2.8

Console.WriteLine(5 + 4); // output: 9
Console.WriteLine(5 + 4.3); // output: 9.3
Console.WriteLine(5.1m + 4.2m); // output: 9.3

Console.WriteLine(47 - 3); // output: 44
Console.WriteLine(5 - 4.3); // output: 0.7
Console.WriteLine(7.5m - 2.3m); // output: 5.2

int x = 5;
x += 9;
Console.WriteLine(x); //Output: 14
x -= 3;
Console.WriteLine(x); //Output: 10
x *= 3;
Console.WriteLine(x); //Output: 20
x /= 4;
Console.WriteLine(x); //:Output: 5
x %= 3;
Console.WriteLine(x); //Output: 2

#endregion


#region Bitwise operator ~
//Bitwise NOT Operator
uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint s = ~t;
Console.WriteLine(Convert.ToString(s, toBase: 2));

//output: 11110000111100001111000011110011
//in this example bitwise not operator actually replaced all the zero into one and all the one into zero

//AND Operator
uint a1 = 0b_1111_1000;
uint b1 = 0b_1001_1101;
Console.WriteLine("a1:     "+ Convert.ToString(a1, toBase: 2));
Console.WriteLine("b1:     "+ Convert.ToString(b1, toBase: 2));
uint c1 = a1 & b1;
Console.WriteLine("Output: "+ Convert.ToString(c1, toBase: 2));

//bitwise And operator replaced 1 

//OR Operator
uint p1 = 0b_1111_1000;
uint q1 = 0b_1001_1101;
uint r = p1 | q1;
Console.WriteLine(Convert.ToString(r, toBase: 2));

//X-OR Operator
uint w = 0b_1111_1000;
uint v = 0b_0001_1100;
uint z = w ^ v;
Console.WriteLine(Convert.ToString(z, toBase: 2));
//Bitwise right shift Operator
uint m = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
Console.WriteLine($"before: {Convert.ToString(m, toBase: 2)}");
uint y = m << 4;
Console.WriteLine($"after : {Convert.ToString(y, toBase: 2)}");

//Bitwise left shift Operator
uint n = 0b_1001;
Console.WriteLine($"Before: {Convert.ToString(n, toBase: 2),4}");
uint n2 = n >> 2;
Console.WriteLine($"After : {Convert.ToString(n2, toBase: 2),4}");
#endregion

#region Logical Operator
//Logical AND-(&&)
Console.WriteLine($"lOgical and operator: {(2<3)&&(4>1)}");

//this operator will return true when both conditions are true! if any conditions false this will return false;

//Logical OR- (||)
Console.WriteLine($"LOgical OR Operator: {(2>3)||(4<8)}");
//This operator will return true if at least one of the oprerands is true; otherwise,it will return false.

//Logical NOT Operator: (!)
Console.WriteLine($"Logical NOT OPerator: {!(2 < 5)}"); 
//this operator neagates the value of a boolean experassion. if the expression is true, it returns false. if the expreassion is false , it returns true.


#endregion

#region Conditional Operator
bool f = (a1 == b1);
bool f2 = (a1 > c1);
bool f3 = (a1 < b1);
bool f4 = (a1 <= c1);
bool f5 = (a1 >= b1);
bool f6 = (a1 != c1);
#endregion

#region Null Operator
//value type e null set korle error dibe! 
//Error: int o = null;
//Right way: 
int? u = null;
u = 5;
//nullable operator null rakha jai abar value o set kora jai
//Nullable type e value check korar jonno 
Console.WriteLine(u.Value);
//value return korbe
Console.WriteLine(u.HasValue);
//value thakle True and na thakle False return korbe

//string reference type , er karone ete ? sign use kora lagena
string NullExample = null;


string name = null;
string text = name ?? "N/A";
Console.WriteLine(text);
//Nullculas Operator: value null hole "N/A" and null na hole oi value return korbe

string k = a1 < b1 ? "Small" : "Big";
//ekhane a2 er cheye b1 boro hole Big and choto hole samall return korbe

#endregion