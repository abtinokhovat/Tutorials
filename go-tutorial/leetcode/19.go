package leetcode

import "awesomeProject/pkg/listnode"

func removeNthFromEnd(head *listnode.ListNode, n int) *listnode.ListNode {
	if head == nil {
		return head
	}

	// Create a dummy node to handle edge cases.
	dummy := &listnode.ListNode{Next: head}
	first, second := dummy, dummy

	// Move the first pointer n+1 steps ahead.
	for i := 0; i <= n; i++ {
		if first == nil {
			// Handle the case when n is greater than the length of the list.
			return head
		}
		first = first.Next
	}

	// Move both pointers until the first pointer reaches the end.
	for first != nil {
		first = first.Next
		second = second.Next
	}

	// Remove the nth node from the end.
	second.Next = second.Next.Next

	return dummy.Next
}
