public class Solution
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dicS = new Dictionary<char, int>();
        Dictionary<char, int> dicT = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!dicS.ContainsKey(c))
                dicS[c] = 1;
            else dicS[c]++;
        }


        foreach (char c in t)
        {
            if(!dicT.ContainsKey(c)) 
                dicT[c] = 1;
            else dicT[c]++;
        }
            

        foreach (var c in dicS.Keys)
        {
            if (!dicT.ContainsKey(c)) return false;

            if (dicT[c] != dicS[c]) return false;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        string s = "anagram";
        string t = "nagaram";

        bool ketQua = IsAnagram(s, t);

        Console.WriteLine("ket qua:" + ketQua);
    }
}
