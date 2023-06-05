//== beeCrowd 1047 ==>
string[] input = Console.ReadLine().Split();
int strTime = int.Parse(input[0]);
int strMnt = int.Parse(input[1]);
int endTime = int.Parse(input[2]);  
int endMnt = int.Parse(input[3]);

if(strTime<endTime && strMnt < endMnt)
{
    Console.WriteLine($"O JOGO DUROU {endTime-strTime} HORA(S) E {endMnt-strMnt} MINUTO(S)");
}