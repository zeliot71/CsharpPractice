// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array practice process on");

//single dimentions array!
int[] ages = new int[10];

ages[0] = 22;
ages[1] = 23;
ages[2] = 24;
ages[3] = 25;
ages[4] = 26;
ages[5] = 27;
ages[6] = 28;
ages[7] = 29;
ages[8] = 30;
ages[9] = 31;
//iteration proccess of array==>
foreach (var age in ages)
{
    Console.WriteLine(age);
}

//another way to declare single dimentions array
int[] reg = new int[10] {10, 12,13,14,15,16,17,18,19,20};

Console.WriteLine(reg[3]);

//Multi dimentional array
int[,] score = new int[2,4];
score[0,0] = 33;
score[0,1] = 42;
score[0,2] = 43;

foreach(var s in score)
{
    Console.WriteLine($"Socores are: {s}");
}

//Jagged array
int[][] scores = new int[3][];
scores[0] = new int[5];
scores[1] = new int[5];
scores[2] = new int[5];

scores[1][3] = 5;

Console.WriteLine($"Jagged array: {scores[1][3]}"); 


//Taking input array size and array from user
int size = int.Parse( Console.ReadLine() );
int[][] scores2 = new int[size][];

for(int i = 0; i < size; i++)
{
    int rowSize = int.Parse( Console.ReadLine() );
    scores2[i] = new int[rowSize];
}