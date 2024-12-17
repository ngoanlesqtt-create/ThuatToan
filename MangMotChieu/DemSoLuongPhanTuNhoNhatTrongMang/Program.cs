class Solution
{
    public static void Main(String[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

        int res = int.MaxValue;
        int dem = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (res > nums[i])
            {
                res = nums[i];
                dem = 1;
            }
            else dem++;

        }
    }
}