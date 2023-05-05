// Write a program that creates an array of integers with the values 1, 2, 3, 4, and 5, and then removes the value 3 from the array and outputs the resulting array to the console.
int[] array = new int[5];
for(int i = 0; i<=array.Length-1; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
int item = 3;
int indexOFNewArray = 0;
int[] newArray =new int[array.Length-1];

for(int j = 0; j < array.Length; j++)
{
    if (array[j] != item)
    {
        newArray[indexOFNewArray] = array[j];
        indexOFNewArray++;
    }
}
foreach(int n in newArray)
{
    Console.WriteLine(n);
}