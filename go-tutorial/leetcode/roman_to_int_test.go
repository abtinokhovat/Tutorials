package leetcode

import (
	"testing"
)

func TestRomanToInt(t *testing.T) {
	testCases := []struct {
		input    string
		expected int
	}{
		// Example 1
		{input: "III", expected: 3},
		// Example 2
		{input: "LVIII", expected: 58},
		// Example 3
		{input: "MCMXCIV", expected: 1994},
		// Additional test cases
		{input: "IX", expected: 9},
		{input: "CDXLIV", expected: 444},
		{input: "CMXCIX", expected: 999},
		{input: "MCMLIV", expected: 1954},
		{input: "MMXIX", expected: 2019},
	}

	for _, testCase := range testCases {
		result := romanToInt(testCase.input)
		if result != testCase.expected {
			t.Errorf("Test failed for input '%s'. Expected: %d, Got: %d", testCase.input, testCase.expected, result)
		}
	}
}
