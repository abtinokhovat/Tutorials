package main

import "fmt"

type ItemRequestedState struct {
	machine *VendingMachine
}

func (s *ItemRequestedState) addItem(count int) error {
	return fmt.Errorf("item Dispense in progress")
}

func (s *ItemRequestedState) requestItem() error {
	return fmt.Errorf("item already requested")
}

func (s *ItemRequestedState) insertMoney(money int) error {
	if s.machine.itemPrice > money {
		return fmt.Errorf("insufficient fund, the price is: %d", s.machine.itemPrice)
	}
	fmt.Println("money received")
	s.machine.setState(s.machine.hasMoney)
	return nil
}

func (s *ItemRequestedState) dispenseItem() error {
	return fmt.Errorf("please insert the money first")
}
