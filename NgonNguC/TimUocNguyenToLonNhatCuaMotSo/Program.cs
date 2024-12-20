class Solution
{
    public static int Solve(int n)
    {
        int res = -1;

        for (int i = 2; i <= Math.Sqrt(n); i++)
            while (n % i == 0)
            {
                res = i;
                n /= i;
            }
        if (n != 1)
            res = n;

        return res;
    }

    public static void Main(string[] args)
    {
        int ketQua = Solve(6);
        Console.WriteLine(ketQua);
    }
}