namespace _21;

internal class Program
{
    private static void Main(string[] args)
    {
        ListNode list1 = new(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new(1, new ListNode(3, new ListNode(4)));

        Solution solution = new();

        ListNode result = solution.MergeTwoLists(list1, list2);
        ListNode current = result;
        while (current != null)
        {
            Console.Write(current.val);
            if (current.next != null) Console.Write(" -> ");
            current = current.next;
        }

        Console.WriteLine();
    }
}

public class ListNode(int val = 0, ListNode next = null)
{
    public ListNode next = next;
    public int val = val;
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new();
        ListNode tail = dummy;

        while (list1 != null && list2 != null)
            if (list1.val < list2.val)
            {
                tail.next = new ListNode(list1.val);
                list1 = list1.next;
                tail = tail.next;
            }
            else
            {
                tail.next = new ListNode(list2.val);
                list2 = list2.next;
                tail = tail.next;
            }

        tail.next = list1 ?? list2;
        return dummy.next;
    }
}