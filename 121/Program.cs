namespace _121;

public class Solution {
    public int MaxProfit(int[] prices) {
        
        int lowest = 0;
        int maxProfit = 0;

        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < prices[lowest])
            {
                lowest = i;
            }

            if(prices[i] - prices[lowest] > maxProfit)
            {
                maxProfit = prices[i] - prices[lowest];
            }
        }

        return maxProfit;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}