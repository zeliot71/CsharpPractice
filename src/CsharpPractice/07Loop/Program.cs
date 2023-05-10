// See https://aka.ms/new-console-template for more information
//#region Simple for loop syntax
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}
//#endregion

//#region Simple while loop syntax
//int c = 0;
//while (c < 10)
//{
//    Console.WriteLine("Hello!");
//    c++;
//}

////While loop: at first check the statement and go for action
//#endregion

//#region While infinite loop
//while (true)
//{
//    string line = Console.ReadLine();
//    if (line == string.Empty)
//        break;
//    else
//        Console.WriteLine("Hello " + line);
//}
//#endregion

#region Simple do while loop syntax
int d = 0;
do
{
    Console.WriteLine("Love You!");
    d++;
}
while (d < 10);

//Do while loop: do fast and then check statement
#endregion

//#region Foreach loop
//int[] ages = new int[10];
//foreach (int i in ages)
//{
//    Console.WriteLine(ages);
//}

////Foreach loop: Born to handle collections type, for loop diyeo collections(Arry, List, Dictionary)
////handle kora jai, kintu foreach loop most efficient
//#endregion

//#region Forceach loop to operate jagged array
//int[][] allScores = new int[4][];
//allScores[0] = new int[4] {30,40,50,40};
//allScores[1] = new int[2] {20,50};
//allScores[2] = new int[3] { 10, 30, 70 };
//allScores[3] = new int[4] { 10, 20, 30, 70 };


//foreach(int[] programmingScores in allScores)
//{
//    foreach (int scores in programmingScores)
//    {
//        Console.WriteLine(scores);
//    }
//}

////foreach implementetion on jagged array
//#endregion