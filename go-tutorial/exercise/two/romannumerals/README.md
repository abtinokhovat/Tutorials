# Approach
<!-- Describe your first thoughts on how to solve this problem. -->
Considering the roman numbers table we continue.

| Roman Numeral | Arabic Number |
|---------------|---------------|
| I             | 1             |
| V             | 5             |
| X             | 10            |
| L             | 50            |
| C             | 100           |
| D             | 500           |
| M             | 1000          |

We can start with simple calculation with test cases.

```
2500  = 2000 (2 * 1000) + 500 (500)                                        -> MM + D                      = MMD
2378  = 2000 (2 * 1000) + 300 (3 * 100) + 50 + 20 (2 * 10) + 5 + 3 (3 * 1) -> MM + CCC + L + XX + V + III = MMCCCLXXVIII
```

Okay, hmm?? So we can break our number to pieces of roman number and then sum all the resulted value for our number correct?

We can iterate over our mapping that we created and when our value was bigger increment our index.
```
for i := 0; input != 0; {
		now := m[i]
		if input >= now.number {
			str.WriteString(now.sign)
			input -= now.number
		} else {
			i++
		}
	}
```

Actually this is somehow correct until we encounter `4ish` or `9ish` numbers like: `923`, `944`
Here our algorithm don't work anymore. 

```
9     = 5 + 4                    -> V + IV             = IX
4     = 1 + 3                    -> I + III            = IV
934   = 900 + 30 + 4             -> CM + XXX + IV      = CMXXXIV
437   = 400 + 30 + 7             -> CD + XXX + VII     = CDXXXVII
944   = 900 + 40 + 4             -> CM + XL + IV       = CMXLIV
```

We can tweak our table a little bit like below to get the correct answers in these cases also.

| Roman Numeral | Arabic Number |
|---------------|---------------|
| I             | 1             |
| IV            | 4             |
| V             | 5             |
| IX            | 9             |
| X             | 10            |
| XL            | 40            |
| L             | 50            |
| XC            | 90            |
| C             | 100           |
| CD            | 400           |
| D             | 500           |
| CM            | 900           |
| M             | 1000          |

We add 9ish and 4ish values in table and the problem is solved.

# Complexity
- Time complexity:
- O(n)
<!-- Add your time complexity here, e.g. $$O(n)$$ -->

- Space complexity:
- O(1)
<!-- Add your space complexity here, e.g. $$O(n)$$ -->

# Code
```
import (
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

func intToRoman(input int) string {
    if input > 3999 || input <= 0 {
		return ""
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

	return str.String()
    
}
```