public class Solution
{
    //s = "abc", t = "ahbgdc"
    public bool IsSubsequence(string s, string t)
    {
        int i = 0;
        int j = 0;

        while (j < t.Length)
        {
            if (i < s.Length && s[i] == t[j])
                i++;
            j++;
        }

        return i == s.Length;
    }
}