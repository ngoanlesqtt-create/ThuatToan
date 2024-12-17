public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        int n = nums.Length;
        List<string> result = new List<string>();

        if (n == 0) return result;

        int start = nums[0];

        for (int i = 1; i < n; i++)
        {
            if (nums[i] != nums[i - 1] + 1)
            {
                if (nums[i - 1] != start)
                    result.Add(start + "->" + nums[i - 1]);
                else result.Add(start.ToString());

                start = nums[i];
            }
        }

        if (start == nums[n - 1])
            result.Add(start.ToString());
        else result.Add(start + "->" + nums[n - 1]);


        return result;
    }
}