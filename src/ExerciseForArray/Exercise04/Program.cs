// Write a program that creates an array of integers with the values 1, 2, 3, 4, and 5, and then calculates the sum of all the values in the array and outputs the result to the console.

int[] nums = new int[] { 1, 2, 3, 4, 5 };
var sum = 0;
for (int i = 0;i < nums.Length; i++)
{
    sum += nums[i];
}
Console.WriteLine(sum);
