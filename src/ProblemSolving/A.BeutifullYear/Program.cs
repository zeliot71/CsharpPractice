//A Beutifull Year
int Y = int.Parse(Console.ReadLine());

while (true)
{
    Y++;
    string year = Y.ToString();
    bool hasDistinctDigits = true;
    for(int i =0; i < year.Length -1; i++)
    {
        for(int j =i+1; j < year.Length; j++)
        {
            if (year[i] == year[j])
                hasDistinctDigits = false;
            break;
        }
        
    }
    break;
}