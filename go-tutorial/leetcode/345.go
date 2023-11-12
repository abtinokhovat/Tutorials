package leetcode

import (
	"fmt"
	"strings"
)

func isVowel(ch byte) bool {
	return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'
}

func reverseVowels(s string) string {
	chars := []byte(s)
	i, j := 0, len(chars)-1

	for i < j {
		for i < j && !isVowel(chars[i]) {
			print(i, j, false, s)
			i++
		}

		for i < j && !isVowel(chars[j]) {
			print(i, j, false, s)
			j--
		}

		chars[i], chars[j] = chars[j], chars[i]
		print(i, j, true, s)
		i++
		j--

	}

	return string(chars)
}

var Red = "\033[31m"
var Green = "\033[32m"
var Yellow = "\033[33m"

func ReverseVowels(s string) string {
	return reverseVowels(s)
}

func print(i, j int, swap bool, s string) {
	var builder strings.Builder

	if i > 0 {
		builder.WriteString(s[:i])
	}

	colorI, colorJ := Yellow, Green

	if swap {
		colorI, colorJ = Red, Red
	}

	// write i
	builder.WriteString(coloredRune(rune(s[i]), colorI))

	if i < j {
		// write mid
		builder.WriteString(s[i+1 : j])

		// write j
		if j != len(s)/2 {
			builder.WriteString(coloredRune(rune(s[j]), colorJ))
		}
	}

	if j < len(s)-1 {
		// write after
		builder.WriteString(s[j+1:])
	}

	fmt.Println(builder.String())
}

func coloredRune(s rune, color string) string {
	return fmt.Sprintf("%v%c\033[97m", color, s)
}
