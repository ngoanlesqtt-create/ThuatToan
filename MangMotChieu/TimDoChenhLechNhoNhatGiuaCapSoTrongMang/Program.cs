class Solution
{
    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[1005];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap a[{i}]:");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int res = 1000000000;

        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (Math.Abs(nums[i] - nums[j]) < res)
                    res = Math.Abs(nums[i] - nums[j]);
        Console.WriteLine(res);
    }
}
