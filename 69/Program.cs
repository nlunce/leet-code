namespace _69;

public class Solution
{
    public int MySqrt(int x)
    {
        if (x < 2) return x;


        long root = x / 2;


        while (root * root > x) root = root / 2;

        while (root * root <= x) root++;

        return (int)(root - 1);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        int x = 2147395599;
        int result = solution.MySqrt(x);
        Console.WriteLine(result);
    }
}