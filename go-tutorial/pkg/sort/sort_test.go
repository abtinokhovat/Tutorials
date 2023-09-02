package sort

import (
	"sort"
	"testing"
)

func BenchmarkSortingAlgorithms(b *testing.B) {
	testCases := []struct {
		name string
		arr  []int
	}{
		{"SmallRandom", []int{5, 3, 8, 1, 2}},
		{"MediumRandom", []int{64, 25, 12, 22, 11, 3, 2, 3, 1, 2, 4, 5, 5, 6}},
		{"LargeRandom", []int{238, 982, 743, 159, 362, 802, 679, 502, 394, 891}},
		{"NearlySorted", []int{1, 2, 2, 3, 3, 4, 5, 5, 6, 11, 12, 22, 25, 64}},
		{"Random", []int{3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48}},
		{"ReallyLarge", []int{94, 57, 11, 78, 39, 46, 71, 88, 26, 65,
			98, 17, 32, 53, 27, 90, 43, 59, 10, 23,
			85, 34, 50, 12, 73, 61, 29, 68, 80, 56,
			41, 84, 44, 60, 22, 74, 14, 64, 31, 20,
			99, 16, 47, 55, 76, 95, 21, 42, 62, 81,
			38, 19, 79, 35, 82, 13, 45, 66, 87, 54,
			89, 72, 24, 37, 63, 91, 69, 30, 83, 75,
			15, 28, 86, 51, 96, 58, 36, 25, 67, 48,
			49, 70, 93, 40, 18, 97, 33, 77, 52, 92,
			9, 3, 7, 6, 8, 2, 1, 5, 4, 0}},
	}

	for _, tc := range testCases {
		b.Run(tc.name, func(b *testing.B) {
			benchmarkSortingAlgorithms(b, tc.arr)
		})
	}
}

func benchmarkSortingAlgorithms(b *testing.B, arr []int) {
	b.Run("BubbleSort", func(b *testing.B) {
		for i := 0; i < b.N; i++ {
			BubbleSort(arr)
		}
	})

	b.Run("SelectionSort", func(b *testing.B) {
		for i := 0; i < b.N; i++ {
			SelectionSort(arr)
		}
	})

	b.Run("InsertionSort", func(b *testing.B) {
		for i := 0; i < b.N; i++ {
			InsertionSort(arr)
		}
	})

	b.Run("MergeSort", func(b *testing.B) {
		for i := 0; i < b.N; i++ {
			_ = MergeSort(arr)
		}
	})

	b.Run("QuickSort", func(b *testing.B) {
		for i := 0; i < b.N; i++ {
			QuickSort(arr)
		}
	})

	b.Run("HeapSort", func(b *testing.B) {
		for i := 0; i < b.N; i++ {
			HeapSort(arr)
		}
	})

	b.Run("GoSort", func(b *testing.B) {
		for i := 0; i < b.N; i++ {
			sort.Ints(arr)
		}
	})

	b.Run("CountingSort", func(b *testing.B) {
		for i := 0; i < b.N; i++ {
			CountingSort(arr)
		}
	})
}

//func measureMemoryUsage(b *testing.B) {
//	var mBefore, mAfter runtime.MemStats
//	runtime.GC()
//	runtime.ReadMemStats(&mBefore)
//
//	b.ResetTimer()
//
//	for i := 0; i < b.N; i++ {
//		// Simulate some memory-intensive operation
//		_ = make([]byte, 1024)
//	}
//
//	b.StopTimer()
//
//	runtime.GC()
//	runtime.ReadMemStats(&mAfter)
//
//	memUsed := mAfter.TotalAlloc - mBefore.TotalAlloc
//	fmt.Printf("Memory used during %s: %d bytes\n", b.Name(), memUsed)
//}
