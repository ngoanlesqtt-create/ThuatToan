﻿class Solution
{
    public static int count(int n)
    {
        int count = 0;

        for (int i = 5; i <= n; i *= 5)
            count += n / i;
        return count;
    }
}
