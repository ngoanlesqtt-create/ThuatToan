public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {

        Dictionary<char, int> ransomNoteCount = new Dictionary<char, int>();
        Dictionary<char, int> magazineCount = new Dictionary<char, int>();

        foreach (char c in ransomNote)
        {
            if (ransomNoteCount.ContainsKey(c)) ransomNoteCount[c]++;
            else ransomNoteCount[c] = 1;
        }

        foreach (char c in magazine)
        {
            if (magazineCount.ContainsKey(c)) magazineCount[c]++;
            else magazineCount[c] = 1;
        }

       foreach(var c in ransomNoteCount)
        {
            if (!magazineCount.ContainsKey(c.Key) || magazineCount[c.Key] <c.Value ) return false;
        }



        return true;
    }
}
