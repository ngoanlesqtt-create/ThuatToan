class Solution
{
    public static bool CheckSoDep(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            int count = 0;
            while (n % i == 0)
            {
                count++;
                n /= i;
            }
            if (count >= 2)
                return true;
        }
        return false;
    }

}