class Solution
{
    public static void Main(String[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        int x = 5;

        int left = 0;
        int right = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < x)
                left++;

            if (nums[i] > x)
                right++;
        }

        Console.WriteLine(left + " " + right);
    }
}
