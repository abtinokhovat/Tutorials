package leetcode

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test605(t *testing.T) {
	testCases := []struct {
		name      string
		flowerbed []int
		n         int
		result    bool
	}{
		{name: "one", flowerbed: []int{1}, n: 1, result: false},
		{name: "one-false", flowerbed: []int{1}, n: 0, result: true},
		{name: "zero", flowerbed: []int{0}, n: 1, result: true},
		{name: "first", flowerbed: []int{1, 0, 0, 0, 1}, n: 1, result: true},
		{name: "second", flowerbed: []int{1, 0, 0, 0, 1}, n: 2, result: false},
		{name: "70th", flowerbed: []int{1, 0, 1, 0, 1, 0, 1}, n: 1, result: false},
		{name: "108th", flowerbed: []int{0, 0, 1, 0, 1}, n: 1, result: true},
		{name: "121th", flowerbed: []int{0, 0, 1, 0, 0}, n: 1, result: true},
		{name: "me1", flowerbed: []int{1, 0, 1, 0, 0}, n: 1, result: true},
	}

	for _, tc := range testCases {
		t.Run(tc.name, func(t *testing.T) {
			res := canPlaceFlowers(tc.flowerbed, tc.n)
			assert.Equal(t, tc.result, res)
		})
	}

}
