namespace _67;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int maxLen = Math.Max(a.Length, b.Length);
        a = a.PadLeft(maxLen, '0');
        b = b.PadLeft(maxLen, '0');

        char[] result = new char[maxLen];
        char carry = '0';

        for (int i = maxLen - 1; i > 0; i--)
        {
            if (a[i] == '0' && b[i] == '0' && carry == '0')
            {
                result[i] = '0';
                carry = '0';
            }

            if (a[i] == '1' && b[i] == '0' && carry == '0')
            {
                result[i] = '1';
                carry = '0';
            }

            if (a[i] == '0' && b[i] == '1' && carry == '0')
            {
                result[i] = '1';
                carry = '0';
            }


            if (a[i] == '0' && b[i] == '0' && carry == '1')
            {
                result[i] = '1';
                carry = '0';
            }

            if (a[i] == '1' && b[i] == '1' && carry == '0')
            {
                result[i] = '0';
                carry = '1';
            }

            if (a[i] == '1' && b[i] == '1' && carry == '1')
            {
                result[i] = '1';
                carry = '1';
            }
        }

        return new string(result);
    }
}