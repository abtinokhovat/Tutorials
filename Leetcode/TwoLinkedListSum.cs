namespace Leetcode;

public static class Solution1
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, bool carry = false)
    {
        if (l1 == null && l2 == null && carry == false) return null!;

        var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + (carry ? 1 : 0);
        return sum >= 10
            ? new ListNode(sum % 10, AddTwoNumbers(l1?.next!, l2?.next!, true))
            : new ListNode(sum, AddTwoNumbers(l1?.next!, l2?.next!));
    }
}

public class ListNode
{
    public ListNode? next;
    public int val;

    public ListNode(IList<int> nums)
    {
        if (nums.Count <= 0) return;
        val = nums[0];
        nums.RemoveAt(0);
        next = nums.Count > 0 ? new ListNode(nums) : null;
    }

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        var text = next != null ? $"{val.ToString()} -> " : $"{val.ToString()}";
        if (next != null)
            text += next.ToString();

        return text;
    }
}