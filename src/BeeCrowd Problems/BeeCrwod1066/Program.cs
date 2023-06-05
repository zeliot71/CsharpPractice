//== BeeCrowd Problem 1066 ===>
int even=0,odd=0,positive=0,negative=0;
for (int i = 0; i < 5; i++) 
{
    int n = int.Parse(Console.ReadLine());
    if(n%2==0 || n >=0)
        even++;
    else if(n%2!=0 || n<=0)
        odd++;
    else if(n>0)
        positive++;
    else if(n<=0)
        negative++;
}
Console.WriteLine($"{even} valor(es) par(es)");
Console.WriteLine($"{odd} valor(es) impar()es");
Console.WriteLine($"{positive} valor(es) positivo(s)");
Console.WriteLine($"{negative} valor(es) negativo(s)");