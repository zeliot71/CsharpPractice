//Write a program that creates an array of integers with the values 1, 2, 3, 4, and 5, and then multiplies each value by 2 and outputs the result to the console.

int[] nums = new int[] { 1, 2, 3, 4, 5, };
for(int i = nums[0]; i<=nums.Length; i++)
{
     i *= 2;
}
foreach(int i in nums)
{
    Console.WriteLine(i);
}