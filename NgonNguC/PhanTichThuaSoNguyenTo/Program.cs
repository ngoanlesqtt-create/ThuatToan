class Solution
{
    private static int[] prime = new int[1005];

    public static void Sang()
    {
        for (int i = 0; i < 1005; i++)
            prime[i] = i;

        for (int i = 2; i <= Math.Sqrt(1005); i++)
        {
            for (int j = i * i; j < 1005; j += i)
                if (prime[j] == j)
                    prime[j] = i;
        }
    }

    public static void PhanTich(int n)
    {
        while (n != 1)
        {
            int count = 0;
            int minPrime = prime[n];

            while (n % minPrime == 0)
            {
                count++;
                n /= minPrime;
            }

            Console.WriteLine(minPrime + "(" + count + ") ");
        }
    }
    public static void Main(string[] args)
    {
        Sang();

        PhanTich(101);
    }
}
