class Solution
{
    public static void Main(String[] args)
    {
        int n = 10;

        int tong = 0;

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
                tong += i;

                if (n / i != i)
                {
                    Console.WriteLine(n / i);
                    tong += n / i;
                }
            }
        }

        Console.WriteLine(tong);
    }
}
