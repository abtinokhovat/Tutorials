package main

import "fmt"

type HasMoneyState struct {
	machine *VendingMachine
}

func (s *HasMoneyState) addItem(count int) error {
	return fmt.Errorf("item dispense in progress")
}

func (s *HasMoneyState) requestItem() error {
	return fmt.Errorf("item already requested")
}

func (s *HasMoneyState) insertMoney(money int) error {
	return fmt.Errorf("money already inserted")
}

func (s *HasMoneyState) dispenseItem() error {
	fmt.Println("dispensing the item")
	s.machine.itemCount = s.machine.itemCount - 1
	if s.machine.itemCount == 0 {
		s.machine.setState(s.machine.noItem)
		return nil
	}

	s.machine.setState(s.machine.hasItem)
	return nil
}
