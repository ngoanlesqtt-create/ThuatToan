public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;
      

        Dictionary<char, char> mapStoT = new Dictionary<char, char>();
        Dictionary<char, char> mapTtoS = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char charS = s[i];
            char charT = t[i];

            if (mapStoT.ContainsKey(charS))
            {
                if (mapStoT[charS] != charT) return false;
            }
            else mapStoT[charS] = charT;

            if (mapTtoS.ContainsKey(charT))
            {
                if (mapTtoS[charT] != charS) return false;
            }
            else mapTtoS[charT] = charS;
        }

        return true;
    }
}
