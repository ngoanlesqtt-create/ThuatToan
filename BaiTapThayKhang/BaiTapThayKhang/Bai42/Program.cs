

class Solution
{

    private static double tinh(int n)
    {
        int k = 0;
        int sum = 0;

        // Tính tổng S(k) cho đến khi S(k) >= n
        while (sum + (k + 1) < n)
        {
            k++;
            sum += k;  // Cập nhật tổng S(k)
        }
        return k;
    }


    public static void Main(string[] args)
    {
        int n = 10;

        double ketQua = tinh(n);

        Console.WriteLine(ketQua);
    }

}
