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
        int x = a.Length - 1;
        int y = b.Length - 1;

        List<char> result = new();

        int carry = 0;


        while (x >= 0 || y >= 0 || carry != 0)
        {
            if ((x >= 0 ? a[x] - '0' : 0) + (y >= 0 ? b[y] - '0' : 0) + carry == 3)
            {
                carry = 1;

                result.Add('1');
            }
            else if ((x >= 0 ? a[x] - '0' : 0) + (y >= 0 ? b[y] - '0' : 0) + carry == 2)
            {
                carry = 1;

                result.Add('0');
            }
            else if ((x >= 0 ? a[x] - '0' : 0) + (y >= 0 ? b[y] - '0' : 0) + carry == 1)
            {
                carry = 0;

                result.Add('1');
            }
            else
            {
                carry = 0;

                result.Add('0');
            }

            x = x - 1;
            y = y - 1;
        }


        result.Reverse();
        string sum = new(result.ToArray());
        return sum;
    }
}