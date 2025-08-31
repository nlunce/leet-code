namespace _58;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string trimmed = s.TrimEnd();
        char[] charArray = trimmed.ToCharArray();
        Array.Reverse(charArray);

        int counter = 0;
        foreach (char c in charArray)
        {
            if (c == ' ') break;

            counter++;
        }

        return counter;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}