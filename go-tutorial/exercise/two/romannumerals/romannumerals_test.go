package romannumerals

import "testing"

type romanNumeralTest struct {
	description string
	input       int
	expected    string
}

var validRomanNumeralTests = []romanNumeralTest{
	{
		description: "1 is I",
		input:       1,
		expected:    "I",
	},
	{
		description: "2 is II",
		input:       2,
		expected:    "II",
	},
	{
		description: "3 is III",
		input:       3,
		expected:    "III",
	},
	{
		description: "4 is IV",
		input:       4,
		expected:    "IV",
	},
	{
		description: "5 is V",
		input:       5,
		expected:    "V",
	},
	{
		description: "6 is VI",
		input:       6,
		expected:    "VI",
	},
	{
		description: "9 is IX",
		input:       9,
		expected:    "IX",
	},
	{
		description: "27 is XXVII",
		input:       27,
		expected:    "XXVII",
	},
	{
		description: "48 is XLVIII",
		input:       48,
		expected:    "XLVIII",
	},
	{
		description: "49 is XLIX",
		input:       49,
		expected:    "XLIX",
	},
	{
		description: "59 is LIX",
		input:       59,
		expected:    "LIX",
	},
	{
		description: "93 is XCIII",
		input:       93,
		expected:    "XCIII",
	},
	{
		description: "141 is CXLI",
		input:       141,
		expected:    "CXLI",
	},
	{
		description: "163 is CLXIII",
		input:       163,
		expected:    "CLXIII",
	},
	{
		description: "402 is CDII",
		input:       402,
		expected:    "CDII",
	},
	{
		description: "575 is DLXXV",
		input:       575,
		expected:    "DLXXV",
	},
	{
		description: "911 is CMXI",
		input:       911,
		expected:    "CMXI",
	},
	{
		description: "1024 is MXXIV",
		input:       1024,
		expected:    "MXXIV",
	},
	{
		description: "3000 is MMM",
		input:       3000,
		expected:    "MMM",
	},
	{
		description: "16 is XVI",
		input:       16,
		expected:    "XVI",
	},
	{
		description: "66 is LXVI",
		input:       66,
		expected:    "LXVI",
	},
	{
		description: "166 is CLXVI",
		input:       166,
		expected:    "CLXVI",
	},
	{
		description: "666 is DCLXVI",
		input:       666,
		expected:    "DCLXVI",
	},
	{
		description: "1666 is MDCLXVI",
		input:       1666,
		expected:    "MDCLXVI",
	},
	{
		description: "3001 is MMMI",
		input:       3001,
		expected:    "MMMI",
	},
	{
		description: "3999 is MMMCMXCIX",
		input:       3999,
		expected:    "MMMCMXCIX",
	},
}

func TestRomanNumerals(t *testing.T) {
	for _, tc := range validRomanNumeralTests {
		t.Run(tc.description, func(t *testing.T) {
			actual, err := ToRomanNumeral(tc.input)
			if err != nil {
				// expect no error for all valid tests cases (canonical-data.json contains only valid cases)
				t.Fatalf("ToRomanNumeral(%d) returned error: %v, want: %q", tc.input, err, tc.expected)
			}
			if actual != tc.expected {
				t.Fatalf("ToRomanNumeral(%d) = %q, want: %q", tc.input, actual, tc.expected)
			}
		})
	}
}
func TestRomanNumeralsInvalid(t *testing.T) {
	invalidRomanNumeralTests := []romanNumeralTest{
		{description: "0 is out of range", input: 0},
		{description: "-1 is out of range", input: -1},
		{description: "4000 is out of range", input: 4000},
	}
	for _, tc := range invalidRomanNumeralTests {
		t.Run(tc.description, func(t *testing.T) {
			actual, err := ToRomanNumeral(tc.input)
			if err == nil {
				t.Fatalf("ToRomanNumeral(%d) expected error, got: %q", tc.input, actual)
			}
		})
	}
}
func BenchmarkRomanNumerals(b *testing.B) {
	if testing.Short() {
		b.Skip("skipping benchmark in short mode.")
	}
	for i := 0; i < b.N; i++ {
		for _, tc := range validRomanNumeralTests {
			_, _ = ToRomanNumeral(tc.input)
		}
	}
}
