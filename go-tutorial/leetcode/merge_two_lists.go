package leetcode

type ListNode struct {
	Val  int
	Next *ListNode
}

func mergeTwoLists(list1 *ListNode, list2 *ListNode) *ListNode {
	//var list ListNode
	main := &ListNode{}
	list := main

	for list1 != nil && list2 != nil {
		if list1.Val < list2.Val {
			list.Next = list1
			list1 = list1.Next
		} else {
			list.Next = list2
			list2 = list2.Next
		}

		list = list.Next
	}

	if list1 == nil {
		list.Next = list2
	} else {
		list.Next = list1
	}

	return main.Next
}
