// Write a program that creates an array of integers with the values 1, 2, 3, 4, and 5, and then sorts the array in ascending order and outputs the sorted array to the console.
int[] nums = new int[] {4,5,3,1,2};
int i,j;
for (i = 0;i < nums.Length - 1; i++)
{
    for(j = 0; j< nums.Length-i-1; j++)
    {
        if (nums[j] > nums[j + 1])
        {
            var temp = nums[j];

            nums[j] = nums[j + 1];
            nums[j + 1] = temp;
        }
    }
}
foreach(int n in nums)
{
    Console.Write(n + " ");
}