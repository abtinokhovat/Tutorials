package main // Replace "main" with your package name if different

import (
	"awesomeProject/exercise"
	"strconv"
	"testing"
)

func TestIsIsogram(t *testing.T) {
	// Test cases
	testCases := []struct {
		word     string
		expected bool
	}{
		{"background", true},
		{"downstream", true},
		{"isograms", false},
		{"six-year-old", true},
		{"six year old", true},
	}

	// Test each case
	for _, tc := range testCases {
		t.Run(tc.word, func(t *testing.T) {
			result := exercise.IsIsogram(tc.word)
			if result != tc.expected {
				t.Errorf("Expected %v, but got %v for word '%s'", tc.expected, result, tc.word)
			}
		})
	}
}

func TestDiffOfSquares(t *testing.T) {
	testCases := []struct {
		number   int
		expected int
	}{
		{10, 2640},
	}

	for _, tc := range testCases {
		t.Run(strconv.Itoa(tc.number), func(t *testing.T) {
			result := exercise.DiffOfSquares(tc.number)
			if result != tc.expected {
				t.Errorf("Expected %v, but got %v for number '%d'", tc.expected, result, tc.number)
			}
		})
	}
}

func TestValidateLuhn(t *testing.T) {
	testCases := []struct {
		str      string
		expected bool
	}{
		{"4539 3195 0343 6467", true},
		{"8273 1232 7352 0569", false},
		{"309", false},
	}

	for _, tc := range testCases {
		t.Run(tc.str, func(t *testing.T) {
			result := exercise.ValidateLuhn(tc.str)
			if result != tc.expected {
				t.Errorf("Expected %v, but got %v for number '%s'", tc.expected, result, tc.str)
			}

		})
	}
}
