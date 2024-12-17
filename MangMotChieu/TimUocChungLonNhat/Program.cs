class Solution
{
    public static int GCD(int a, int b)
    {
        if (b == 0) return a;

        return GCD(b, a % b);
    }
    public static void Main(String[] args)
    {
        int[] nums = { 24, 4, 6, 8, 4 };
        int ketQua = 0;

        foreach (int num in nums)
        {
            ketQua = GCD(ketQua, num);

        }
        Console.WriteLine(ketQua);
    }
}
