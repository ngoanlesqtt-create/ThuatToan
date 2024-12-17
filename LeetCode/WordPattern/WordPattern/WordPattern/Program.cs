public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');
        Dictionary<string, string> dicPToS = new Dictionary<string, string>();
        Dictionary<string, string> dicSToP = new Dictionary<string, string>();
        int n = pattern.Length;

        if(words.Length != pattern.Length)
            return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            string pToS = new string(pattern[i], 1);
            string sToP = words[i];

            if (dicPToS.ContainsKey(pToS))
            {
                if (dicPToS[pToS] != sToP) return false;
            }
            else dicPToS[pToS] = sToP;

            if (dicSToP.ContainsKey(sToP))
            {
                if (dicSToP[sToP] != pToS) return false;
            }
            else dicSToP[sToP] = pToS;
        }

        return true;
    }
}
