package leetcode

import "testing"

func TestMergeTwoLists(t *testing.T) {
	// Example 1
	list1 := &ListNode{Val: 1, Next: &ListNode{Val: 2, Next: &ListNode{Val: 4, Next: nil}}}
	list2 := &ListNode{Val: 1, Next: &ListNode{Val: 3, Next: &ListNode{Val: 4, Next: nil}}}
	result := mergeTwoLists(list1, list2)
	expected := []int{1, 1, 2, 3, 4, 4}
	if !compareLinkedList(result, expected) {
		t.Errorf("Test case 1 failed. Expected: %v, got: %v", expected, linkedListToSlice(result))
	}

	// Example 2
	list1 = nil
	list2 = nil
	result = mergeTwoLists(list1, list2)
	expected = []int{}
	if !compareLinkedList(result, expected) {
		t.Errorf("Test case 2 failed. Expected: %v, got: %v", expected, linkedListToSlice(result))
	}

	// Example 3
	list1 = nil
	list2 = &ListNode{Val: 0, Next: nil}
	result = mergeTwoLists(list1, list2)
	expected = []int{0}
	if !compareLinkedList(result, expected) {
		t.Errorf("Test case 3 failed. Expected: %v, got: %v", expected, linkedListToSlice(result))
	}
}

func compareLinkedList(head *ListNode, expected []int) bool {
	curr := head
	for i := 0; i < len(expected); i++ {
		if curr == nil || curr.Val != expected[i] {
			return false
		}
		curr = curr.Next
	}
	return curr == nil
}

func linkedListToSlice(head *ListNode) []int {
	var result []int
	curr := head
	for curr != nil {
		result = append(result, curr.Val)
		curr = curr.Next
	}
	return result
}
