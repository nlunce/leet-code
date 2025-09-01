namespace _28;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int j = 0;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[j])
            {
                j++;
            }
            else
            {
                i = i - j;
                j = 0;
            }

            if (j == needle.Length) return i - j + 1;
        }

        return -1;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        int result = solution.StrStr("mississippi", "issip");

        Console.WriteLine(result);
    }
}