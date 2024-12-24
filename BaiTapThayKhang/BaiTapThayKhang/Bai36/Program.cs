class Solution
{
    public static long tinhGiaiThua(long n)
    {
        if (n == 0) return 1;

        return n * tinhGiaiThua(n - 1);
    }

    public static double tinh(int n)
    {
        if (n == 1) return 1;

        return Math.Sqrt(tinhGiaiThua(n) + tinh(n - 1));
    }

    public static void Main(string[] args)
    {
        int n = 10;
        double ketQua = tinh(n);

        Console.WriteLine(ketQua);
    }
}