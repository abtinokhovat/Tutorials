package leetcode

func canPlaceFlowers(flowerbed []int, n int) bool {

	clone := []int{0}
	clone = append(clone, flowerbed...)
	clone = append(clone, 0)

	for i := 1; i <= len(clone)-2 && n != 0; i++ {

		left := clone[i-1] == 0
		mid := clone[i] == 0
		right := clone[i+1] == 0

		if left && right && mid {
			clone[i] = 1
			n--
		}
	}

	return n == 0
}
