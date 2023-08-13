package exercise

import "fmt"

type Clock struct {
	minutes int
}

const (
	hourMinutes = 60
	dayMinutes  = hourMinutes * 24
)

func normalize(minutes int) Clock {
	if minutes < 0 {
		return Clock{dayMinutes + (minutes % dayMinutes)}
	} else if minutes >= hourMinutes {
		return Clock{minutes % dayMinutes}
	}
	return Clock{minutes}
}

func New(h, m int) Clock {
	return normalize((h * hourMinutes) + m)
}

func (c Clock) Add(m int) Clock {
	return normalize(c.minutes + m)
}

func (c Clock) Subtract(m int) Clock {
	return normalize(c.minutes - m)
}

func (c Clock) String() string {
	return fmt.Sprintf("%02d:%02d", c.minutes/hourMinutes, c.minutes%hourMinutes)
}
