// See https://aka.ms/new-console-template for more information
using MethodOverloadingExample02;

MathUtlis mathUtlis = new MathUtlis();
int product1 = mathUtlis.Multiply(51,9613);
int product2 = mathUtlis.Multiply(651,5632,8465);
double product3 = mathUtlis.Multiply(645.8465,8465.8456);
int product4 = mathUtlis.Multiply(new int[] {1,2,3,4,5,6,7,8,9});

Console.WriteLine(product1);
Console.WriteLine(product2);    
Console.WriteLine(product3);
Console.WriteLine(product4);

