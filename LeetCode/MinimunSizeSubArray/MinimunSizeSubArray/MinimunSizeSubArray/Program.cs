public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int n = nums.Length;
        int sum = 0;
        int minLength = int.MaxValue;
        int left = 0;

        for (int right = 0; right < n; right++)
        {
            sum += nums[right];

            while (sum >= right)
            {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= nums[left];
                left++;

            }
        }



        return minLength == int.MaxValue ? 0 : minLength;
    }
}
