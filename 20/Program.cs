namespace _20;

public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length < 2) return false;

        Stack<char> stack = new();
        Dictionary<char, char> map = new();
        map.Add('(', ')');
        map.Add('[', ']');
        map.Add('{', '}');

        if (map.ContainsKey(s[0]))
            stack.Push(s[0]);
        else
            return false;


        for (int i = 1; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                stack.Push(s[i]);
                continue;
            }

            if (stack.Count == 0) return false;

            if (map[stack.Peek()] == s[i])
                stack.Pop();
            else
                return false;
        }

        if (stack.Count() == 0) return true;
        return false;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        Console.WriteLine(solution.IsValid("()")); // true
    }
}