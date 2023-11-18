package main

import "fmt"

type NoItemState struct {
	machine *VendingMachine
}

func (i *NoItemState) addItem(count int) error {
	i.machine.incrementItemCount(count)
	i.machine.setState(i.machine.hasItem)
	return nil
}

func (i *NoItemState) requestItem() error {
	return fmt.Errorf("the machine is empty")
}

func (i *NoItemState) insertMoney(count int) error {
	return fmt.Errorf("the machine is empty")
}

func (i *NoItemState) dispenseItem() error {
	return fmt.Errorf("the machine is empty")
}
