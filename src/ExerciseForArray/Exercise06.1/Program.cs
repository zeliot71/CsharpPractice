// Extra exercise to practice descending sort
int[] nums = new int[] { 3, 2, 4, 5, 1 };
int i, j;
for (i = 0; i < nums.Length -1; i++)
{
    for(j= 0; j< nums.Length -i -1; j++)
    {
        if (nums[j]< nums[j + 1])
        {
            var temp = nums[j+1];
            nums[j+1] = nums[j];
            nums[j] = temp;
        }
    }
}

foreach(int num in nums)
{
    Console.Write(num + " ");
}