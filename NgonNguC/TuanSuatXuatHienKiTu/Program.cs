class Solution
{
    public static void Main(String[] args)
    {
        char[] c1 = { 'p', 'y', 't', 'h', 'o', 'n' };
        char[] c2 = { 'p', 'r', 'o', 'j', 'e', 'c', 't' };

        int[] count = new int[256];

        for (int i = 0; i < c1.Length; i++)
            count[c1[i]] = 1;

        for (int i = 0; i < c2.Length; i++)
            if (count[c2[i]] == 1)
                count[c2[i]] = 2;

        for (int i = 0; i < c1.Length; i++)
            if (count[c1[i]] == 2)
                Console.Write(c1[i]);

    }
}
