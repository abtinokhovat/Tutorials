package leetcode

func TwoSum(nums []int, target int) []int {

	for i, value := range nums {
		for j := i + 1; j < len(nums); j++ {
			if value+nums[j] == target {
				return []int{i, j}
			}
		}
	}

	return []int{}
}

func TwoSum2(nums []int, target int) []int {
	m := make(map[int]int)

	for i, value := range nums {
		complement := target - value
		if _, ok := m[complement]; ok {
			return []int{i, m[complement]}
		}
		m[value] = i
	}

	return []int{}
}
