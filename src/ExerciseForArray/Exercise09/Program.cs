//Write a program that creates an array of integers with the values 1, 2, 3, 4, and 5, and then finds the index of the value 3 in the array and outputs the index to the console.
int[] nums = new int[] { 5,3,4,2,1};

int item = 3;
int index = -1;
for(int i = 0; i< nums.Length; i++)
    {
    if (nums[i] == item)
        {
            index = i;
            break;
        }
    }
if (index != -1)
{
    Console.WriteLine($"The index of {item} is {index}");
}
else
{
    Console.WriteLine($"{item} was not found in the array!");
}