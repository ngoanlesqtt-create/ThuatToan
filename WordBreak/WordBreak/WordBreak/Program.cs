public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        HashSet<string> words = new HashSet<string>(wordDict);
            
        int n = s.Length;

        bool[] dp = new bool[n + 1];
        dp[0] = true;

        for (int i = 1; i <= n; i++)
            for (int j = 0; j < i; j++)
                if (words.Contains(s.Substring(j, i - j)) && dp[j])
                {
                    dp[j] = true;
                    break;
                }
        return true;

    }
}
