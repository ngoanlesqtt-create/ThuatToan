public class Solution
{
    public int MySqrt(int x)
    {
        if (x < 2) return x;

        long left = 0;
        long right = x;
        int t = 0;

        while (left <= right)
        {
            long mid = left + (right - left) / 2;

            if (mid * mid == x)
                return (int)mid;

            if (mid * mid > x)
                right = mid - 1;
            else if (mid * mid < x)
            {
                t = (int)mid;
                left = mid + 1;
            }

        }



        return t;
    }
}