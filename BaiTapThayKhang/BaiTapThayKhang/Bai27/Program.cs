class Solution
{
    public static void Main(string[] args)
    {
        int n = 20;

        int dem = 0;

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                if (i % 2 == 0)
                    dem++;

                if (i != n / i && (n / i) % 2 == 0)
                    dem++;
            }
        }

        Console.WriteLine(dem);
    }
}