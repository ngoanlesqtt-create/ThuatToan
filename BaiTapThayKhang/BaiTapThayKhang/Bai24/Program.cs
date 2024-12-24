class Solution
{
    public static void Main(string[] args)
    {
        int n = 100;

        for (int i = 1; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
            {

                if (i % 2 != 0)
                    Console.WriteLine(i);

                if (i != n / i && (n / i) % 2 != 0)
                {
                    Console.WriteLine(n / i);
                }
            }
    }
}