class Solution
{
    private static int[] prime = new int[10000001];

    private static void sieve()
    {
        for (int i = 0; i < prime.Length; i++)
            prime[i] = 1;

        prime[0] = prime[1] = 0;

        for (int i = 2; i <= 1000; i++)
            if (prime[i] == 1)
            {
                for (int j = i * i; j < prime.Length; j += i)
                    prime[j] = 0;
            }
    }

    public static void Main(string[] args)
    {
        sieve();
        for (int i = 0; i <= 20; i++)
            if (prime[i] == 1)
                Console.Write(i + " ");
    }
}
