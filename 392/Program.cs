namespace _392;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;

        if (t.Length == 0) return false;

        int j = 0;
        for (int i = 0; i < t.Length; i++)
            if (t[i] == s[j])
            {
                j++;

                if (j == s.Length) return true;
            }

        return false;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        bool result = solution.IsSubsequence("abc", "ahbgdc");
        Console.WriteLine(result);
    }
}