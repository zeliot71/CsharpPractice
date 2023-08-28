//A Anton and Danik

int n = int.Parse(Console.ReadLine());
string s = Console.ReadLine();
var Danik = 0;
var Anton = 0;

for(int i = 0;i < s.Length; i++)
{
    if (s[i] == 'A')
        Anton++;
    else if(s[i] == 'D')
        Danik++;
}

if (Danik > Anton)
{
    Console.WriteLine("Danik");
}
else if (Anton == Danik) 
    Console.WriteLine("Friendship");
else
    Console.WriteLine("Anton");