class Solution
{
    public static void Main(String[] args)
    {
        char[] arr = { 'a', 'b', 'a', 'a', 'b' };
        int[] count = new int[26];

        for (int i = 0; i < arr.Length; i++)
        {
            count[arr[i] - 'a']++;
        }

        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] != 0)
                Console.WriteLine((char)(i + 'a') + " " + count[i]);

        }
    }
}
