//Write a program that creates an array of integers with the values 1, 2, 3, 4, and 5, and then reverses the order of the values in the array and outputs the reversed array to the console.
int[] nums = new int[] {1,2,3,4,5};

Array.Reverse(nums);
foreach(int num in nums)
{
    Console.WriteLine(num);
}