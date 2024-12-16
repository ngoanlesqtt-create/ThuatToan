using System;

public class Solution
{

    // Reads two integers and prints their sum
    static public void basicIO()
    {
        string[] tokens = Console.ReadLine().Split();
        int a = int.Parse(tokens[0]);
        int b = int.Parse(tokens[1]);
        Console.WriteLine((a + b));
    }

    static public void Main()
    {
        basicIO();
    }
}