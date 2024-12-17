public class Solution
{
    public int MaxArea(int[] height)
    {
        int i = 0;
        int j = height.Length - 1;
        int maxVolume = 0;

        while (i < j)
        {
            int area = Math.Min(height[i], height[j]) * (j - i);

            maxVolume = Math.Max(maxVolume, area);

            if (height[i] < height[j])
                i++;
            else j--;

        }

        return maxVolume;
    }
}
