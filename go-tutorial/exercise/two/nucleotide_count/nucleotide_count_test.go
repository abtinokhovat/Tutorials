package dna

import (
	"reflect"
	"testing"
)

var testCases = []struct {
	description   string
	strand        string
	expected      Histogram
	errorExpected bool
}{
	{
		description:   "empty strand",
		strand:        "",
		errorExpected: false,
		expected:      Histogram{'A': 0, 'C': 0, 'G': 0, 'T': 0},
	},
	{
		description:   "can count one nucleotide in single-character input",
		strand:        "G",
		errorExpected: false,
		expected:      Histogram{'A': 0, 'C': 0, 'G': 1, 'T': 0},
	},
	{
		description:   "strand with repeated nucleotide",
		strand:        "GGGGGGG",
		errorExpected: false,
		expected:      Histogram{'A': 0, 'C': 0, 'G': 7, 'T': 0},
	},
	{
		description:   "strand with multiple nucleotides",
		strand:        "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC",
		errorExpected: false,
		expected:      Histogram{'A': 20, 'C': 12, 'G': 17, 'T': 21},
	},
	{
		description:   "strand with invalid nucleotides",
		strand:        "AGXXACT",
		errorExpected: true,
		expected:      Histogram{},
	},
}

func TestCounts(t *testing.T) {
	for _, tc := range testCases {
		t.Run(tc.description, func(t *testing.T) {
			dna := DNA(tc.strand)
			actual, err := dna.Counts()
			switch {
			case tc.errorExpected:
				if err == nil {
					t.Fatalf("DNA.Counts(%q) expected error, got: %#v", tc.strand, actual)
				}
			case err != nil:
				t.Fatalf("DNA.Counts(%q) returned error: %v, want: %#v", tc.strand, err, tc.expected)
			case !reflect.DeepEqual(actual, tc.expected):
				t.Fatalf("DNA.Counts(%q)\n got:%#v\nwant: %#v", tc.strand, actual, tc.expected)
			}
		})
	}
}
