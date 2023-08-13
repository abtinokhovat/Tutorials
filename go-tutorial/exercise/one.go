package exercise

import (
	"errors"
	"fmt"
	"math"
	"strconv"
	"strings"
)

func TwoFer(name string) {
	if name == "" {
		name = "You"
	}
	fmt.Printf("One for %s, one for me.\n", name)
}

func HammingDistance(strand1, strand2 string) (distance int, e error) {

	if len(strand1) != len(strand2) {
		return 0, errors.New("strands length's must be equal")
	}

	for i := 0; i < len(strand1); i++ {
		if strand1[i] != strand2[i] {
			distance++
		}
	}
	return distance, nil
}

func HammingDistanceTwo(strand1, strand2 string) (distance int, e error) {
	runes1 := []rune(strand1)
	runes2 := []rune(strand2)

	if len(runes1) != len(runes2) {
		return 0, errors.New("strands length's must be equal")
	}

	for i, value := range runes1 {
		if value != runes2[i] {
			distance++
		}
	}

	return distance, nil
}

func RainDrop(n int) string {
	var sound string

	if n%3 == 0 {
		sound += "Pling"
	}
	if n%5 == 0 {
		sound += "Plang"
	}
	if n%7 == 0 {
		sound += "Plong"
	}

	if len(sound) == 0 {
		sound = strconv.Itoa(n)
	}

	return sound
}

func IsIsogram(word string) bool {
	m := make(map[rune]bool)

	for _, value := range word {
		if value == '-' || value == ' ' {
			continue
		}
		if m[value] {
			return false
		}

		m[value] = true
	}

	return true
}

func DiffOfSquares(n int) int {
	squareSum := int(math.Pow(float64(n*(n+1)/2), 2))
	sumOfSquares := n * (n + 1) * ((2 * n) + 1) / 6
	return squareSum - sumOfSquares
}

func ValidateLuhn(str string) bool {
	// remove white spaces
	str = strings.ReplaceAll(str, " ", "")

	length := len(str)
	if length <= 1 {
		return false
	}

	// summation
	var sum int
	for i := length - 1; i >= 0; i-- {
		number := int(str[i]) - '0'
		if number > 9 {
			return false
		}
		if i%2 == length%2 {
			number *= 2
			if number > 9 {
				number -= 9
			}
		}
		sum += number
	}

	return sum%10 == 0
}

var mapping = map[rune]int{
	'A': 1, 'E': 1, 'I': 1, 'O': 1, 'U': 1, 'L': 1, 'N': 1, 'R': 1, 'S': 1, 'T': 1,
	'D': 2, 'G': 2,
	'B': 3, 'C': 3, 'M': 3, 'P': 3,
	'F': 4, 'H': 4, 'V': 4, 'W': 4, 'Y': 4,
	'K': 5,
	'J': 8, 'X': 8,
	'Q': 10, 'Z': 10,
}

func Score(word string) (score int) {
	for _, value := range strings.ToUpper(word) {
		score += mapping[value]
	}
	return
}
