class Solution
{
    public static double tinh(double x)
    {
        if (x == 1)
            return Math.Sqrt(2);

        return Math.Sqrt(2 + tinh(x - 1));
    }

    public static void Main(string[] args)
    {
        int n = 10;

        double ketQua = tinh(n);

        Console.WriteLine(ketQua);

    }
}