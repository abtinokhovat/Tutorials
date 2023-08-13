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
	roman{1000, "M"},
	roman{900, "CM"},
	roman{500, "D"},
	roman{400, "CD"},
	roman{100, "C"},
	roman{90, "XC"},
	roman{50, "L"},
	roman{40, "XL"},
	roman{10, "X"},
	roman{9, "IX"},
	roman{5, "V"},
	roman{4, "IV"},
	roman{1, "I"},
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
