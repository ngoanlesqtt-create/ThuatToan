class Solution
{
    public static bool Prime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    public static void Main(string[] args)
    {
        int[] nums = new int[1005];

        Console.Write("Nhap n:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap a[{i}]:");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            int left = 0;
            int right = 0;

            for (int j = 0; j < i; j++)
                left += nums[j];

            for (int k = i + 1; k < n; k++)
                right += nums[k];

            if (Prime(left) && Prime(right))
                Console.WriteLine(i);
        }
    }
}
