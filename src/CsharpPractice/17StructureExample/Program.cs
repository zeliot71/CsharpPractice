// See https://aka.ms/new-console-template for more information
using _17StructureExample;

Console.WriteLine("Hello, World!");

//Stack: Eti ek dhoroner memory allocation jekhane datar value gulo sequantialy store hoy
//Example:Primitive Data Types(number, boolean, string, null and undefined) are stored in STACK and they are always assigned by value.

//Heap: eti arek dhoroner memory allocation jekhane datar referance/memory address non sequantialy store hoy
//Example: Non primitive data types(String,object) are stored in Heap and aboiously assigned by referance


//STRUCTURE: Class er moto kintu class er poriborte struct likhte hoy, eti nije value type and er moddhe thaka refarence type keo value type e conert kore
//Interface implement kora jai kintu inheritance kora jaina
//always ekta default constructor thake paramiterized constructor declare korar por o

//Stack
int x = 5;
int y = x;

x = y + 1;
Console.WriteLine(y);

//Heap
Person person = new Person();
person.Name= "Test";
person.Id = 1;
person.child= new Child() { age = 8};

Person person2 = person;
person2.Name = "OnTest";
person2.Id = 2;
person2.child.age = 10;
Console.WriteLine($"Person2 name: {person2.Name} age: {person2.Id} child age: {person2.child.age}");

