using System.Text;

string input = Console.ReadLine().ToLower();


StringBuilder sb = new StringBuilder();
foreach (char c in input)
{
    if ("aeiouy".Contains(c))
    {
        sb.Replace(c.ToString(),"");
    }
    else
    {
        sb.Append('.').Append(c);
        
    }
   
}

string result = sb.ToString();
Console.Write(result);