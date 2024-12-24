class Solution
{
    public static void Main(string[] args)
    {
        int n = 10;

        int tong = 0;

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                tong += i;

                if (n / i != i && n / i < n)
                    tong += n / i;
            }
        }

        Console.WriteLine(tong);
    }
}