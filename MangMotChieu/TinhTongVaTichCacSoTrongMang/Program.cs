class Solution
{
    private static int tong = 0;
    private static int tich = 1;
    private static int mod = 1000000007;
    public static void Main(String[] args)
    {
        int[] nums = { 1, 3, 2, 5, 7, 9, 10 };
        foreach (int x in nums)
        {
            tong += x;
            tong %= mod;
            tich *= x;
            tich %= mod;
        }

        Console.WriteLine(tong + " " + tich);
    }
}