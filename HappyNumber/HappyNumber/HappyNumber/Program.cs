public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            if (seen.Contains(sum))
                return false;

            seen.Add(sum);

            n = sum;
        }

        return true;
    }
}
