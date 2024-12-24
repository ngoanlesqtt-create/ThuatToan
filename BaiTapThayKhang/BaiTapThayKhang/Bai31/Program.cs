class Solution
{
    public static void Main(string[] args)
    {
        int n = 79;

        int dem = 0;

        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                dem++;

        if (dem > 0)
            Console.WriteLine($"{n} khong la so nguyen to");
        else Console.WriteLine($"{n} la so nguyen to");
    }
}