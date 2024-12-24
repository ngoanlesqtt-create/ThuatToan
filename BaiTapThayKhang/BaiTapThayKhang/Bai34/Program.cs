class Solution
{
    public static double tinh(double x)
    {
        if (x == 1)
            return 1;

        return Math.Sqrt(x + tinh(x - 1));
    }
    public static void Main(string[] args)
    {
        double x = 10;
        double y = tinh(x);

        Console.WriteLine(y);
    }
}
