class Solution
{

    public static double tinh(int x)
    {
        if (x == 2) return Math.Sqrt(2);

        return Math.Pow(x + tinh(x - 1), 1.0 / x);
    }
    public static void Main(string[] args)
    {
        int x = 3;

        double y = tinh(x);

        Console.WriteLine(y);

    }

}