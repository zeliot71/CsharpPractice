// Write a program that creates an array of integers with the values 1, 2, 3, 4, and 5, and then sorts the array in ascending order and outputs the sorted array to the console.
int[] nums = new int[] {4,5,3,1,2};
for (int i = 0;i < nums.Length; i++)
{
    if (i > nums[0]+1)
    {
        Console.WriteLine(i);
    }
}