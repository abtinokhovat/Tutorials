package main

import "fmt"

type HasItemState struct {
	machine *VendingMachine
}

func (i *HasItemState) addItem(count int) error {
	fmt.Printf("%d items added\n", count)
	i.machine.incrementItemCount(count)
	return nil
}

func (i *HasItemState) requestItem() error {
	if i.machine.itemCount == 0 {
		i.machine.setState(i.machine.noItem)
		return fmt.Errorf("machine is empty")
	}
	fmt.Println("item requested")
	i.machine.setState(i.machine.itemRequested)
	return nil
}

func (i *HasItemState) insertMoney(count int) error {
	return fmt.Errorf("please select item first")
}

func (i *HasItemState) dispenseItem() error {
	return fmt.Errorf("please select item first")
}
