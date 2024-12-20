class Solution
{
    private static long[] fibo = new long[100];
    public static bool CheckFibonacci(long n)
    {
        if (n == 0 || n == 1)
            return true;

        fibo[0] = 0;
        fibo[1] = 1;

        for (int i = 1; i <= 92; i++)
            fibo[i] = fibo[i - 1] + fibo[i - 2];

        for (int i = 0; i <= 92; i++)
            if (fibo[i] == n)
                return true;

        return false;
    }
}
