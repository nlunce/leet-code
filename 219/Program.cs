namespace _219;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++)
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
            else
            {
                int j = map[nums[i]];
                if (Math.Abs(i - j) <= k) return true;
                map[nums[i]] = i;
            }

        return false;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new();
        Console.WriteLine(sol.ContainsNearbyDuplicate(new[] { 1, 2, 3, 1, 2, 3 }, 2)); // false
    }
}