class Solution
{
    public static int Sum(int n)
    {
        int tong = 0;

        while (n != 0)
        {
            tong += n % 10;
            n /= 10;
        }
        return tong;
    }

    public static bool Smith(int n)
    {
        int sum1 = Sum(n);
        int sum2 = 0;


        int tmp = n;

        for (int i = 2; i <= Math.Sqrt(n); i++)
            while (n % i == 0)
            {
                sum2 += Sum(i);
                n /= 10;
            }
        if (tmp == n)
            return false;

        if (n != 1)
            sum2 += Sum(n);
        return sum2 == sum1;
    }
}
