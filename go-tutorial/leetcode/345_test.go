package leetcode

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestReverseVowels(t *testing.T) {
	testCases := []struct {
		str string
		out string
	}{
		{str: "hello", out: "holle"},
		{str: "leetcode", out: "leotcede"},
		{str: "divorce", out: "devorci"},
		{str: "aA", out: "Aa"},
		{
			str: "Marge, let's \"went.\" I await news telegram.",
			out: "Marge, let's \"went.\" i awaIt news telegram.",
		},
		{
			str: "u'o;B,vKO\"?,.;?fGI 9;`9T`Z,;iqsn4A.:;'H3s8E9. B4TxfOiB'wvM?q'k:Q`J\"E1T7lo e7c!?glI66?JZh\"6 !C,aK! 1J?f9'`SX4Q!Q4XS`'9f?J1 !Ka,C! 6\"hZJ?66Ilg?!c7e ol7T1E\"J`Q:k'q?Mvw'BiOfxT4B .9E8s3H';:.A4nsqi;,Z`To`;o IGf?;.,?\"OKv,B;o'u",
			out: "u'o;B,vKO\"?,.;?fGI 9;`9T`Z,;oqsn4o.:;'H3s8i9. B4TxfAEB'wvM?q'k:Q`J\"O1T7li E7c!?glo66?JZh\"6 !C,eK! 1J?f9'`SX4Q!Q4XS`'9f?J1 !KI,C! 6\"hZJ?66alg?!c7a Il7T1e\"J`Q:k'q?Mvw'BoEfxT4B .9i8s3H';:.O4nsqE;,Z`TA`;i IGf?;.,?\"OKv,B;o'u",
		},
	}

	for _, tc := range testCases {
		t.Run(tc.str, func(t *testing.T) {
			res := reverseVowels(tc.str)
			assert.Equal(t, tc.out, res)
		})
	}
}
