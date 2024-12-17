class Solution
{
    public static void Main(string[] args)
    {
        int n = 5;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write("*");

            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i; j++)
                Console.Write("*");

            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                if (j < n - i - 1)
                    Console.Write(" ");
                else Console.Write("*");
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j < i)
                    Console.Write(" ");
                else Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
