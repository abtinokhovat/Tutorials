package main

import (
	"math/rand"
	"testing"
)

func gcd(x, y int) int {
	if y == 0 {
		return x
	} else {
		return gcd(y, x%y)
	}
}

func gcd2(a, b int) int {
	for b != 0 {
		a, b = b, a%b
	}
	return a
}

func gcdBinary(a, b int) int {
	if a == b {
		return a
	}
	if a == 0 {
		return b
	}
	if b == 0 {
		return a
	}

	if a%2 == 0 {
		if b%2 == 1 {
			return gcdBinary(a>>1, b)
		} else {
			return gcdBinary(a>>1, b>>1) << 1
		}
	}
	if b%2 == 0 {
		return gcdBinary(a, b>>1)
	}

	if a > b {
		return gcdBinary((a-b)>>1, b)
	}
	return gcdBinary(a, (b-a)>>1)
}

func BenchmarkBinaryGCD(b *testing.B) {
	inputs := generateInputs(b.N)
	b.ResetTimer()

	for i := 0; i < b.N; i++ {
		_ = gcdBinary(inputs[i].a, inputs[i].b)
	}
}

func BenchmarkEuclideanGCD(b *testing.B) {
	inputs := generateInputs(b.N)
	b.ResetTimer()

	for i := 0; i < b.N; i++ {
		_ = gcd2(inputs[i].a, inputs[i].b)
	}
}

func BenchmarkGCD(b *testing.B) {
	inputs := generateInputs(b.N)
	b.ResetTimer()

	for i := 0; i < b.N; i++ {
		_ = gcd(inputs[i].a, inputs[i].b)
	}
}

type inputPair struct {
	a, b int
}

func generateInputs(n int) []inputPair {
	inputs := make([]inputPair, n)
	for i := 0; i < n; i++ {
		a := rand.Intn(10000) + 1
		b := rand.Intn(10000) + 1
		inputs[i] = inputPair{a, b}
	}
	return inputs
}
