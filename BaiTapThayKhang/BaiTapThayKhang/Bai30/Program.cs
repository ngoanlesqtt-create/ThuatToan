class Solution
{
    public static void Main(string[] args)
    {
        int n = 1000;


        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0 && (n / i) % 2 != 0)
            {
                Console.WriteLine(n / i);
                break;
            }
        }

      
    }
}