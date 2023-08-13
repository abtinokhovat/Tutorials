package strand

import "testing"

var testCases = []struct {
	description string
	input       string
	expected    string
}{
	{
		description: "Empty RNA sequence",
		input:       "",
		expected:    "",
	},
	{
		description: "RNA complement of cytosine is guanine",
		input:       "C",
		expected:    "G",
	},
	{
		description: "RNA complement of guanine is cytosine",
		input:       "G",
		expected:    "C",
	},
	{
		description: "RNA complement of thymine is adenine",
		input:       "T",
		expected:    "A",
	},
	{
		description: "RNA complement of adenine is uracil",
		input:       "A",
		expected:    "U",
	},
	{
		description: "RNA complement",
		input:       "ACGTGGTCTTAA",
		expected:    "UGCACCAGAAUU",
	},
}

func TestRNATranscription(t *testing.T) {
	for _, tc := range testCases {
		t.Run(tc.description, func(t *testing.T) {
			if actual := ToRNA(tc.input); actual != tc.expected {
				t.Fatalf("ToRNA(%q) = %q, want: %q", tc.input, actual, tc.expected)
			}
		})
	}
}
func BenchmarkRNATranscription(b *testing.B) {
	if testing.Short() {
		b.Skip("skipping benchmark in short mode.")
	}
	for i := 0; i < b.N; i++ {
		for _, tc := range testCases {
			ToRNA(tc.input)
		}
	}
}
