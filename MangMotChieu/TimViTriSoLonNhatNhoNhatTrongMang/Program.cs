class Solution
{
    public static void Main(String[] args)
    {
        int[] nums = { 1, 2, 4, 3, 4, 2, 1 };

        int maxVal = int.MinValue;
        int minVal = int.MaxValue;

        int maxPos = 0;
        int minPos = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxVal)
            {
                maxVal = nums[i];
                maxPos = i;
            }

            if (nums[i] <= minVal)
            {
                minVal = nums[i];
                minPos = i;
            }
        }

        Console.WriteLine(maxVal + " " + maxPos);
        Console.WriteLine(minVal + " " + minPos);
    }
}
