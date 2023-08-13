package leetcode

var m = map[string]int{
	"M":  1000,
	"CM": 900,
	"D":  500,
	"CD": 400,
	"C":  100,
	"XC": 90,
	"L":  50,
	"XL": 40,
	"X":  10,
	"IX": 9,
	"V":  5,
	"IV": 4,
	"I":  1,
}

func romanToInt(s string) int {
	num := 0
	for i := 0; i < len(s); i++ {
		if i+1 < len(s) {
			if _, ok := m[s[i:i+2]]; ok {
				num += m[s[i:i+2]]
				i++
				continue
			}
		}

		num += m[s[i:i+1]]
	}
	return num
}
