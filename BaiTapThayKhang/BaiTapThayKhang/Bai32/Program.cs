class Solution
{
    public static void Main(string[] args)
    {
        long n = 25;

        long can = (int)Math.Sqrt(n);

        if (can * can == n)
            Console.WriteLine($"{n} la so chinh phuong");
        else Console.WriteLine($"{n} khong la so chinh phuong");
    }
}