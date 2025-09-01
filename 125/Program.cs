namespace _125;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;


        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }

            if (char.ToLower(s[left]) == char.ToLower(s[right]))
            {
                left++;
                right--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        string s = "A man, a plan, a canal: Panama";
        bool result = solution.IsPalindrome(s);
        Console.WriteLine(result);
    }
}