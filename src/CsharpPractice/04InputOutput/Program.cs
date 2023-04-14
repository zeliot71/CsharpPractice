// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//console.writeline string return kore/

int x = 5;
Console.WriteLine(x);
//amra jodi int write kori, eta ashole int'k string convert kore automatic vabe string e return kore

Console.Write("Hello");
//Console.write ekoi line e print kore kintu WriteLine new line nei

string line = Console.ReadLine();

Console.WriteLine(line+ ", Welcome to c# course");
//ReadLine use kore string input neya jai

Console.ReadKey();
//readkey jekono key press korlei input niye nei, entner press korete hoina

int a = Console.Read();
// Console.Read ekta key(int) input neya jai,ja asole charecter er Ascii vlaue
//tobe etake amra charecter e convert kore nite pari

char c = (char)a;
//Ey type casting'k explicit type casting ba convertin bole kintu eta sob khetre kora jabena
Console.WriteLine(c);

float f = (float)5.0;
//Ey type casting'o explicit type casting bole, ekhetre () er vitor type deya lage

double d = f;
//eta implicit type casting ekhane choto value(float)'k boro valute(double) e rakha hoyeeche

string number = Console.ReadLine();
string[] numbers = number.Split(' ');

//ekta line er vitor ekadik jinish input neyar upay, split(' ') method space diye vag kore ekta strig theke alada alada vag kore ekadik items dei
//ekhetre ekadik item diyeo split kora jai jemon:
number.Split(' ', ',', '-');
//ekhane space( ), comma(,) and Dash(-) jekono ekta pelei ta diye split kore pelbe