
class Solution
{
    private static double tinh(int n)
    {
        if (n == 1) return 1;

        return 1 / (1 + tinh(n-1));
    }

    public static void Main(string[] args)
    {
        int n = 10;

        double ketQua = tinh(n);

        Console.WriteLine(ketQua);
    }

}