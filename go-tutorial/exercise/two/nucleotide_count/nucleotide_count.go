package dna

import "errors"

type Histogram map[rune]int

type DNA string

func (d DNA) Counts() (Histogram, error) {
	h := Histogram{
		'A': 0,
		'C': 0,
		'G': 0,
		'T': 0,
	}
	for _, n := range d {
		if n == 'A' || n == 'C' || n == 'G' || n == 'T' {
			h[n]++
		} else {
			return nil, errors.New("invalid character")
		}
	}

	return h, nil
}
