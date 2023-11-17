package main

import "fmt"

type Reception struct {
	next Department
}

func (r *Doctor) execute(p *Patient) {
	if p.doctorCheckedUpDone {
		fmt.Println("Doctor checkup already done.")
		r.next.execute(p)
	}

	fmt.Println("Doctor checking patient.")
	p.doctorCheckedUpDone = true
	r.next.execute(p)
}

func (r *Doctor) setNext(next Department) {
	r.next = next
}
