class Solution
{
    private static int[] prime = new int[1005];

    public static void Sang()
    {
        for (int i = 0; i < 1005; i++)
            prime[i] = 1;

        prime[0] = prime[1] = 0;

        for (int i = 2; i <= Math.Sqrt(1005); i++)
            for (int j = i * i; j < 1005; j += i)
                prime[j] = 0;
    }


    public static void Main(String[] args)
    {
        int n = 20;
        Sang();
        for (int i = 0; i <= n / 2; i++)
            if (prime[i] == 1 && prime[n - i] == 1)
                Console.WriteLine(i + " " + (n - i));
    }
}
