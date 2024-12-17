class Solution
{
    public static void Main(String[] args)
    {
        int n = 5;
        int ketQua = 1;

        for (int i = 1; i <= n; i++)
            ketQua *= i;

        Console.WriteLine(ketQua);
    }
}