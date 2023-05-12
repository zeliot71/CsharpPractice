// See https://aka.ms/new-console-template for more information

int wordsNum = int.Parse(Console.ReadLine());

for (int i = 0; i < wordsNum; i++)
{
    string words = Console.ReadLine();
    if (words.Length > 10)
    {
        string result = words.Substring(1, words.Length - 2);
        int lengthMinusTwo = words.Length - 2;
        string lengthResult = lengthMinusTwo.ToString();
        string newResult = words.Replace(result, lengthResult);
        Console.WriteLine(newResult);
    }
    else
    {
        Console.WriteLine(words);
    }
}




