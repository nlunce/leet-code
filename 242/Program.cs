namespace _242;

public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = new();

        if(s.Length != t.Length) return false;

        for(int i = 0; i < s.Length; i++)
        {
            if(!map.ContainsKey(s[i]))
            {
                map.Add(s[i], 1);
            }
            else
            {
                map[s[i]]++; 
            }
        }

        for(int i = 0; i < t.Length; i++)
        {
            if(!map.ContainsKey(t[i])) return false;

            if(map[t[i]] < 1) return false;

            map[t[i]]--;
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