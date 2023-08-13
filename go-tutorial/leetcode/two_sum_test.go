package leetcode_test

import (
	"awesomeProject/leetcode"
	"reflect"
	"sort"
	"testing"
)

var testCases = []struct {
	description string
	nums        []int
	target      int
	expected    []int
}{
	{
		"TwoSum_NotSortedArray",
		[]int{1, 3, 4, 2},
		6,
		[]int{2, 3},
	},
	{
		"TwoSum_NegetiveValues",
		[]int{-1, -2, -3, -4, -5},
		-8,
		[]int{2, 4},
	},
	{
		"TwoSum_SimpleValues",
		[]int{2, 7, 11, 15},
		9,
		[]int{0, 1},
	},
}

func TestTwoSum(t *testing.T) {
	testRunner(t, leetcode.TwoSum)
}

func TestTwoSum2(t *testing.T) {
	testRunner(t, leetcode.TwoSum2)
}

func sliceEquals(slice1, slice2 []int) bool {
	if len(slice1) != len(slice2) {
		return false
	}
	// Sort the slices before comparison
	sort.Ints(slice1)
	sort.Ints(slice2)
	return reflect.DeepEqual(slice1, slice2)
}

func testRunner(t *testing.T, f func([]int, int) []int) {
	for _, tc := range testCases {
		t.Run(tc.description, func(t *testing.T) {
			result := f(tc.nums, tc.target)
			if !sliceEquals(result, tc.expected) {
				t.Errorf("Expected %v, but got %v", tc.expected, result)
			}
		})

	}
}
