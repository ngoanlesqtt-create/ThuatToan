class Solution
{
    private static long[] nums = new long[1005];
    public static bool checkFibonacci(long n)
    {
        if (n == 0 || n == 1) return true;

        int[] F = new int[100];

        F[0] = 0;
        F[1] = 1;

        for (int i = 2; i <= 92; i++)
        {
            F[i] = F[i - 1] + F[i - 2];

            if (n == F[i]) return true;
        }
        return false;
    }
    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
            nums[i] = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < n; i++)
            if (checkFibonacci(nums[i]))
            {
                found = true;
                Console.WriteLine(nums[i]);
            }

        if (!found) Console.WriteLine("None");





    }
}
