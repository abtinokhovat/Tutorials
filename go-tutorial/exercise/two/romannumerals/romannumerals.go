package romannumerals

import (
	"errors"
	"strings"
)

type roman struct {
	number int
	sign   string
}

var m = [13]roman{
	{1000, "M"},
	{900, "CM"},
	{500, "D"},
	{400, "CD"},
	{100, "C"},
	{90, "XC"},
	{50, "L"},
	{40, "XL"},
	{10, "X"},
	{9, "IX"},
	{5, "V"},
	{4, "IV"},
	{1, "I"},
}

func ToRomanNumeral(input int) (string, error) {
	if input > 3999 || input <= 0 {
		return "", errors.New("value should be under 4000")
	}

	var str strings.Builder

	for i := 0; input != 0; {
		now := m[i]

		if input >= now.number {
			str.WriteString(now.sign)
			input -= now.number
		} else {
			i++
		}
	}

	return str.String(), nil
}
