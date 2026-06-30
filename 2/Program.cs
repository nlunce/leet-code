namespace _2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        int currentSum = 0;

        ListNode sum = new();
        ListNode tail = sum;

        while (l1 != null || l2 != null || carry != 0)
        {
            if (l1 == null) l1 = new ListNode();
            if (l2 == null) l2 = new ListNode();

            if (l1.val + l2.val + carry > 9)
            {
                if (l1.val + l2.val + carry == 10)
                {
                    tail.next = new ListNode();
                }
                else
                {
                    currentSum = (l1.val + l2.val + carry) % 10;
                    tail.next = new ListNode(currentSum);
                }

                tail = tail.next;

                carry = (l1.val + l2.val + carry) / 10;
            }
            else
            {
                currentSum = l1.val + l2.val + carry;
                carry = 0;
                tail.next = new ListNode(currentSum);
                tail = tail.next;
            }

            l1 = l1.next;
            l2 = l2.next;
        }

        return sum.next;
    }
}