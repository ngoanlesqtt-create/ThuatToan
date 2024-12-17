class Solution
{
    public static void TimHaiSoLonNhatTrongMang(int[] nums)
    {
        int m1 = int.MinValue;
        int m2 = int.MinValue;

        foreach (int num in nums)
        {
            if (num > m1)
            {
                m2 = m1;
                m1 = num;
            }
            else if (num > m2) m2 = num;
        }

        Console.WriteLine(m1 + " " + m2);

    }
    public static void Main(string[] args)
    {
        int[] nums = { 1, 3, 2, 5, 4, 8 };
        TimHaiSoLonNhatTrongMang(nums);
    }
}