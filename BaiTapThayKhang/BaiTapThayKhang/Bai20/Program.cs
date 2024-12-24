class Solution
{
    public static void Main(String[] args)
    {
        int n = 10;

        List<int> uocSo = new List<int>();

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                uocSo.Add(i);

                if (i != n / i)
                    uocSo.Add(n / i);
            }
        }

        uocSo.Sort();

        foreach (int i in uocSo)
            Console.WriteLine(i);
    }
}