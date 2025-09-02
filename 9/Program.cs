namespace _9;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        if (x < 10) return true;

        int reversed = x % 10;
        int next = x / 10;
        while (next != 0)
        {
            reversed = reversed * 10 + next % 10;
            next = next / 10;
        }

        if (reversed == x) return true;

        return false;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();

        bool result = solution.IsPalindrome(1211);
        Console.WriteLine(result);
    }
}