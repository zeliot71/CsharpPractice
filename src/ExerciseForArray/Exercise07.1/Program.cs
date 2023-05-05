// exercise 07 repeate again for using foreach loop

using System.Security.Authentication.ExtendedProtection;

int[][] arrays = new int[2][];
arrays[0] = new int[3] {1,2,3};
arrays[1] = new int[3] {4,2,1};

var result = 0;
foreach (int[] arrayElement in arrays)
{
    foreach(int element in arrayElement)
    {
        result += element;
    }
}
Console.WriteLine(result);