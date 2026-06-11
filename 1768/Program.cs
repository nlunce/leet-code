using System.Text;

namespace _1768;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder result = new();
        int min = Math.Min(word1.Length, word2.Length);

        for (int i = 0; i < min; i++)
        {
            result.Append(word1[i]);
            result.Append(word2[i]);
        }

        result.Append(word1, min, word1.Length - min);
        result.Append(word2, min, word2.Length - min);
        return result.ToString();
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        string word1 = "abc";
        string word2 = "pq";
        Solution solution = new();
        string result = solution.MergeAlternately(word1, word2);
        Console.WriteLine(result);
    }
}