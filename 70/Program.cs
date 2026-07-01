namespace _70;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;

        int[] dp = new int[n];
        dp[0] = 1;
        dp[1] = 2;

        for (int i = 2; i < dp.Length; i++) dp[i] = dp[i - 1] + dp[i - 2];

        return dp[^1];
    }
}