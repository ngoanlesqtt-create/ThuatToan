class Solution
{
    public static void Main(string[] args)
    {
        int n = 100;

        int tong = 0;

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                if (i % 2 != 0)
                    tong += i;

                if (i != n / i && (n / i) % 2 != 0)
                    tong += n / i;

            }
        }

        Console.WriteLine(tong);
    }
}