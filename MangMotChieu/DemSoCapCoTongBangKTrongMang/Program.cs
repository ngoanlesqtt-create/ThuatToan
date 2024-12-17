class Solution
{
    public static void Main(String[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6 };
        int k = 6;

        int dem = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == k)
                    dem++;
        }
    }
}
