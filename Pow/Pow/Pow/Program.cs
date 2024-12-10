using System;

public class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0) return 1;

        double half = MyPow(x, n / 2);
        if (n > 0)
        {
            if (n % 2 == 0)
            {
                return half * half; // Nếu mũ chẵn.
            }
            else
            {
                return half * half * x; // Nếu mũ lẻ.
            }
        }
        else
        {
            if (n % 2 == 0)
            {
                return 1 / (half * half); // Nếu mũ chẵn.
            }
            else
            {
                return 1 / (half * half * x); // Nếu mũ lẻ.
            }
        }
    }

}
