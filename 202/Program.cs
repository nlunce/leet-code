namespace _202;

public class Solution
{
    public bool IsHappy(int n)
    {
        Dictionary<int, int> map = new();
        while (n != 1)
        {
            List<int> listOfInts = new();
            int num = n;
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }

            int sum = 0;

            foreach (int i in listOfInts) sum += i * i;

            if (map.ContainsKey(sum)) return false;

            map.Add(n, sum);

            n = sum;
        }

        return true;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        Console.WriteLine(solution.IsHappy(19)); // true
    }
}