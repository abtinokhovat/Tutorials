package listnode

import (
	"bytes"
	"fmt"
)

type ListNode struct {
	Val  int
	Next *ListNode
}

func New(values []int) *ListNode {
	var head *ListNode
	for i := len(values) - 1; i >= 0; i-- {
		head = &ListNode{
			Val:  values[i],
			Next: head,
		}
	}
	return head
}

func TraverseNode(node *ListNode, f func(*ListNode) any) {
	for node != nil {
		f(node)
		node = node.Next
	}
}

func TraverseNodeRecursive(node *ListNode, f func(*ListNode)) *ListNode {
	if node == nil {
		return nil
	}
	f(node)
	return TraverseNodeRecursive(node.Next, f)
}

func (n ListNode) String() string {
	var buffer bytes.Buffer

	adder := func(node *ListNode) any {
		buffer.WriteString(fmt.Sprintf("%d", node.Val))
		if node.Next != nil {
			buffer.WriteString(" -> ")
		}
		return 0
	}

	TraverseNode(&n, adder)

	return buffer.String()
}
