public class Solution
{
    public int RomanToInt(string s)
    {
        // Map of Roman numeral symbols to integer values
        Dictionary<char, int> romanToIntMap = new Dictionary<char, int> {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };

        int total = 0;

        // Loop through the string, checking the current and next characters
        for (int i = 0; i < s.Length; i++)
        {
            // If we are not at the last character and the current value is less than the next value,
            // we subtract the current value (this is the subtraction rule).
            if (i < s.Length - 1 && romanToIntMap[s[i]] < romanToIntMap[s[i + 1]])
            {
                total -= romanToIntMap[s[i]];
            }
            else
            {
                // Otherwise, add the current value
                total += romanToIntMap[s[i]];
            }
        }

        return total;
    }
}
