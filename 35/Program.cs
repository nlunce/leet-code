namespace _35;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int bottom = 0;
        int top = nums.Length;
        int mid = (bottom + top) / 2;

        if (nums[bottom] > target) return 0;

        if (nums[top - 1] < target) return top;


        while (true)
        {
            if (nums[mid] == target) return mid;

            if (bottom + 1 == top) return top;

            if (nums[mid] < target)
            {
                bottom = mid;
                mid = (bottom + top) / 2;
            }

            if (nums[mid] > target)
            {
                top = mid;
                mid = (bottom + top) / 2;
            }
        }
    }
}