package leetcode

import (
	"fmt"
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestRemoveElement(t *testing.T) {
	testCases := []struct {
		nums         []int
		val          int
		expectedNums []int
		expected     int
	}{
		{
			nums:         []int{0, 1, 2, 2, 3, 0, 4, 2},
			val:          2,
			expectedNums: []int{0, 1, 3, 0, 4},
			expected:     5,
		},
		{
			nums:         []int{3, 2, 2, 3},
			val:          3,
			expectedNums: []int{2, 2},
			expected:     2,
		},
	}

	for _, tc := range testCases {
		t.Run(fmt.Sprintf("%v", tc.nums), func(t *testing.T) {
			// 2. execution
			k := removeElement(tc.nums, tc.val)

			// 3. assertion
			assert.Equal(t, tc.expected, k)
			assert.Equal(t, tc.expectedNums, tc.nums[:k])
		})
	}
}
