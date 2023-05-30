// See https://aka.ms/new-console-template for more information
int[,] matrix = new int[5,5];
for(int i = 0;i < 5; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for(int j = 0; j< 5; j++)
    {
        matrix[i,j] = int.Parse(row[j]);
        if(matrix[i,j]== 1)
        {
            Console.WriteLine(matrix[i,j]);
        }
    }
}
