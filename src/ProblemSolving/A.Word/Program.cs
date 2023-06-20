string word = Console.ReadLine();
var Lower = 0;
var Upper = 0;

foreach(var c in word)
{
    if (char.IsLower(c))
    {
        Lower++;
    }
    else if (char.IsUpper(c))
    {
        Upper++;
    }
}
if(Upper > Lower)
{
    Console.WriteLine(word.ToUpper());
}
else if(Lower > Upper)
{
    Console.WriteLine(word.ToLower());
}
else if(Upper == Lower)
{
    Console.WriteLine(word.ToLower());
}