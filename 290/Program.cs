namespace _290;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> map = new();
        string[] words = s.Split(' ');

        if (pattern.Length != words.Length) return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            if (!map.ContainsKey(pattern[i]) && !map.ContainsValue(words[i])) map.Add(pattern[i], words[i]);


            if (map.ContainsKey(pattern[i]) && map[pattern[i]] == words[i]) continue;

            return false;
        }

        return true;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}