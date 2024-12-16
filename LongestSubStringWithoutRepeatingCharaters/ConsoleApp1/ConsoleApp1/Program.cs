public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> charMap = new Dictionary<char, int>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (charMap.ContainsKey(s[right]))
                left = Math.Max(left, charMap[s[right]] + 1);

            charMap[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
