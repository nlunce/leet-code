namespace _205;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]) && !map.ContainsValue(t[i])) map.Add(s[i], t[i]);


            if (map.ContainsKey(s[i]) && map[s[i]] == t[i]) continue;

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