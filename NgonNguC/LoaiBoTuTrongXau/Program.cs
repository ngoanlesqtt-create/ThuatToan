class Solution
{
    public static string[] CustomSplit(string input, char[] delimiters)
    {
        List<string> result = new List<string>();
        int start = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (Array.Exists(delimiters, delimiter => delimiter == input[i]))
            {
                if (i > start)
                    result.Add(input.Substring(start, i - start));
                start = i + 1;
            }
        }

        if (start < input.Length)
            result.Add(input.Substring(start));

        return result.ToArray();
    }

    public static void Main(string[] args)
    {
        char[] delimiters = { ',', ';' };
        string[] results = CustomSplit("Can tach chuoi nay", new char[] { ',', ';', ' ' });

        foreach (string result in results)
            Console.WriteLine(result);
    }
}
