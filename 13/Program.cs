namespace _13;

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> numerals = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int integer = 0;
        for (int i = 0; i < s.Length; i++)
            if (i > 0 && numerals[s[i]] > numerals[s[i - 1]])
            {
                integer += numerals[s[i]];
                integer -= 2 * numerals[s[i - 1]];
            }
            else
            {
                integer += numerals[s[i]];
            }

        return integer;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        string s = "MCMXCIV"; // 1994
        // string s = "III";
        int result = solution.RomanToInt(s);
        Console.WriteLine(result);
    }
}