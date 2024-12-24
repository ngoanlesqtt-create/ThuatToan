class Solution
{
    public static void Main(string[] args)
    {
        int n = 20;

        int dem = 0;

        for (int i = 1; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
            {
                Console.WriteLine(i);
                dem++;

                if (n / i != i)
                {
                    Console.WriteLine(n / i);
                    dem++;
                }
            }

        Console.WriteLine(dem);
    }

}
