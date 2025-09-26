namespace _228;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> summaryRanges = new();
        if (nums.Length == 0) return summaryRanges;
        int start = nums[0];
        int end = nums[0];
        for (int i = 0; i < nums.Length; i++)
            if (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
            {
                end = nums[i + 1];
            }
            else if (i + 1 < nums.Length && nums[i] + 1 != nums[i + 1])
            {
                end = nums[i];
                if (start == end)
                    summaryRanges.Add($"{start}");
                else
                    summaryRanges.Add($"{start}->{end}");
                start = nums[i + 1];
            }
            else
            {
                end = nums[i];
                if (start == end)
                    summaryRanges.Add($"{start}");
                else
                    summaryRanges.Add($"{start}->{end}");
            }

        return summaryRanges;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        IList<string> result = solution.SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 });
        Console.WriteLine(string.Join(", ", result)); // Output: ["0->2","4->5","7"]
    }
}