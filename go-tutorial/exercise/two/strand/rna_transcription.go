package strand

import "strings"

func ToRNA(dna string) string {
	var str strings.Builder
	for _, value := range dna {
		str.WriteRune(transform(value))
	}
	return str.String()

}

func transform(part rune) rune {
	switch part {
	case 'C':
		return 'G'
	case 'G':
		return 'C'
	case 'T':
		return 'A'
	case 'A':
		return 'U'
	default:
		panic("invalid character")

	}
}
