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

#region Bitwise complement operator ~
uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint s = ~t;
Console.WriteLine(s);
Console.WriteLine(Convert.ToString(s, toBase: 2));

#endregion

#region Shift Operator>>><<<<
uint m = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
Console.WriteLine($"before: {Convert.ToString(m, toBase: 2)}");
uint y = m << 4;
Console.WriteLine($"after : {Convert.ToString(y, toBase: 2)}");

uint n = 0b_1001;
Console.WriteLine($"Before: {Convert.ToString(n, toBase:2),4}");
uint n2 = n >> 2;
Console.WriteLine($"After : {Convert.ToString(n2, toBase:2),4}");

#endregion

#region Logical Operator

//AND Operator
uint a1 = 0b_1111_1000;
uint b1 = 0b_1001_1101;
uint c1 = a1 & b1;
Console.WriteLine(Convert.ToString(c1, toBase: 2));

//OR Operator
uint p1 = 0b_1111_1000;
uint q1 = 0b_1001_1101;
uint r = p1 | q1;
Console.WriteLine(Convert.ToString(r,toBase: 2));

//X-OR Operator
uint w = 0b_1111_1000;
uint v = 0b_0001_1100;
uint z = w ^ v;
Console.WriteLine(Convert.ToString(z, toBase: 2));

#endregion