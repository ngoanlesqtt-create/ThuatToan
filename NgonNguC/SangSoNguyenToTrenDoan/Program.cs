class Solution
{
    public static void sang(int left, int right)
    {
        if (left < 2) left = 2;

        int n = right - left + 1;
        int[] prime = new int[n];

        for (int i = 0; i < n; i++)
            prime[i] = 1;

        for (int i = 2; i <= Math.Sqrt(right); i++)
        {
            int start = Math.Max(i * i, (left + i - 1) / i * i);

            for (int j = start; j <= right; j += i)
                prime[j - left] = 0;
        }

        for (int i = 0; i < n; i++)
            if (prime[i] == 1)
                Console.WriteLine(left + i);
    }

    public static void Main(string[] args)
    {
        int left = 10;
        int right = 100;

        sang(left, right);
    }
}
