class Solution
{
    public static int count(int n)
    {
        int count = 0;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                count++;

                while (n % i == 0)
                {
                    n /= i;
                }
            }
            count++;
        }


        return count;
    }

    public static void Main(String[] args)
    {
        int ketQua = count(20);

        Console.WriteLine(ketQua);
    }
}