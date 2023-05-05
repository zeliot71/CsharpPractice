// Write a program that creates two arrays of integers with the same length, and then calculates the sum of each corresponding element in the arrays and outputs the result to the console.
int[][] arrays = new int[2][];
arrays[0]  = new int[3];
arrays[1]  = new int[3];

arrays[0][0] = 1;
arrays[0][1] = 2;
arrays[0][2] = 3;
arrays[1][0] = 1;
arrays[1][1] = 2;
arrays[1][2] = 3;
var result = 0;
for(int i = 0; i < arrays.Length; i++)
{
    int[] arrayElements = arrays[i];
    for(int j = 0; j< arrayElements.Length; j++)
    {
        result += arrayElements[j];
        
    }
}
Console.WriteLine(result);