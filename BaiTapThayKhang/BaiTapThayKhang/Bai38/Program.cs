
class Solution
{
    private static double tinh(int n)
    {
        if (n == 1) return 1;

        return Math.Pow(n + 1 + tinh(n - 1), 1.0 / (n + 1));
    }

    public static void Main(string[] args)
    {
        int n = 4;

        double ketQua = tinh(n);

        Console.WriteLine(ketQua);
    }

}   