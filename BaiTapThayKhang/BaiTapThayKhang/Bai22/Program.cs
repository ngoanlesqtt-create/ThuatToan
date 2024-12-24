class Solution
{
    public static void Main(string[] args)
    {
        int n = 10;

        int tich = 1;

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
                tich *= i;

                if (i != n / i)
                {
                    Console.WriteLine(n / i);
                    tich *= n / i;
                }
            }
        }

        Console.WriteLine(tich);
    }
}