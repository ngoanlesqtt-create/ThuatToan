﻿public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        int n = nums.Length;
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if (map.ContainsKey(nums[i]))
                if (Math.Abs(i - map[nums[i]]) <= k) return true;

            map[nums[i]] = i;
        }

        return false;
    }
}