class Solution
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 4, 4, 5 };

        bool found = false;

        for (int i = 0; i < nums.Length; i += 2)
        {
            if (nums[i] % 2 == 0)
            {
                found = true;
                Console.Write(nums[i] + " ");
            }

        }
        if (!found) Console.WriteLine("None");
    }
}
