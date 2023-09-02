package leetcode

import (
	"awesomeProject/pkg/listnode"
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestRemoveFromListNode(t *testing.T) {
	tests := []struct {
		name         string
		nums         []int
		val          int
		expectedNums []int
	}{
		{
			name:         "[1,2,3,4,5]",
			val:          2,
			nums:         []int{1, 2, 3, 4, 5},
			expectedNums: []int{1, 2, 3, 5},
		},
		{
			name:         "[1]",
			val:          1,
			nums:         []int{1},
			expectedNums: nil,
		},
		{
			name:         "[1,2]",
			val:          1,
			nums:         []int{1, 2},
			expectedNums: []int{1},
		},
		{
			name:         "[1,2] - 2",
			val:          2,
			nums:         []int{1, 2},
			expectedNums: []int{2},
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			// 1. setup
			node := listnode.New(tc.nums)
			expected := listnode.New(tc.expectedNums)

			// 2. execution
			removed := removeNthFromEnd(node, tc.val)

			// 3. assertion
			if expected == nil {
				assert.Nil(t, removed)
			} else {
				assert.Equal(t, expected.String(), removed.String())
			}

		})
	}
}
