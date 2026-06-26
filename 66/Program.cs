namespace _66;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i] = digits[i] + 1;
                return digits;
            }

        return new[] { 1 }.Concat(digits).ToArray();
    }
}