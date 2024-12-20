class Solution
{
    public static bool CheckChinhPhuong(long n)
    {
        int can = (int)Math.Sqrt(n);

        return (long)can * can == n;
    }
    public static void Main(String[] args)
    {
        int a = 10;
        int b = 20;

        int c1 = (int)Math.Sqrt(a);
        int c2 = (int)Math.Sqrt(b);

        if (!CheckChinhPhuong(c1))
            c1++;

        for (int i = c1; i <= c2; i++)
            Console.WriteLine(i * i);   
    }
}