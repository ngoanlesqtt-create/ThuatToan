class Solution
{
    public static bool Prime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    public static bool digitPrime(int n)
    {
        while (n != 0)
        {
            int tmp = n % 10;
            if (tmp != 2 && tmp != 3 && tmp != 5 && tmp != 7)
                return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        int left = 10;
        int right = 100;

        int count = 0;

        for (int i = left; i <= right; i++)
            if (Prime(i) && digitPrime(i))
                count++;

        Console.WriteLine(count);
    }
}
