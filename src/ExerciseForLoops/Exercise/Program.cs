//Write an infinite loop that counts up from 1 to 10 and then starts over again.

var num = 1;
while (num> 0)
{
    var num2 = 0;
    while (num2 < 10)
    {
        num2++;
        Console.WriteLine(num2);
        Thread.Sleep(100);
    }
    num++;
    Thread.Sleep(1000);
}