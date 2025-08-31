namespace _14;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string longestPrefix = "";

        string[] sorted = strs.OrderBy(s => s.Length).ToArray();
        for (int letter = 0; letter < sorted[0].Length; letter++)
        {
            longestPrefix = sorted[0][..(letter + 1)];

            for (int word = 0; word < sorted.Length; word++)
                if (sorted[word].Length > letter && sorted[0][letter] != sorted[word][letter])
                    return sorted[0][..letter];
        }


        return longestPrefix;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        // string[] strs = new[] { "flower", "flow", "flight" };
        string[] strs = new[] { "a" };

        string result = solution.LongestCommonPrefix(strs);
        Console.WriteLine(result);
    }
}