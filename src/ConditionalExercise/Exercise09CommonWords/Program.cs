//Write a program that asks the user to enter a sentence and then determines the most common word in the sentence. Ignore capitalization and punctuation.
using System.Linq.Expressions;

string sentence = Console.ReadLine().ToLower();

string cleanSentence = "";
foreach (char c in sentence)
{
    if (char.IsLetter(c) || c == ' ')
    {
        cleanSentence += c;
    }
}

string[] newSentence = cleanSentence.Split(' ');
for(int i = 0;i < newSentence.Length; i++)
{
    for(int j = 0; j< newSentence.Length-1; j++)
    {
        if (newSentence[i] == newSentence[j])
            Console.WriteLine(newSentence[j]);
        break;

    }
}
