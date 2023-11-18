package main

import "fmt"

type VendingMachine struct {
	itemCount int
	itemPrice int

	currentState State

	hasItem       State
	itemRequested State
	hasMoney      State
	noItem        State
}

func newVendingMachine(itemCount, itemPrice int) *VendingMachine {
	v := &VendingMachine{
		itemCount: itemCount,
		itemPrice: itemPrice,
	}
	hasItemState := &HasItemState{
		machine: v,
	}

	itemRequestedState := &ItemRequestedState{
		machine: v,
	}

	hasMoneyState := &HasMoneyState{
		machine: v,
	}

	noItemState := &NoItemState{
		machine: v,
	}

	v.setState(hasItemState)
	v.hasItem = hasItemState
	v.itemRequested = itemRequestedState
	v.hasMoney = hasMoneyState
	v.noItem = noItemState
	return v
}

func (v *VendingMachine) requestItem() error {
	return v.currentState.requestItem()
}

func (v *VendingMachine) addItem(count int) error {
	return v.currentState.addItem(count)
}

func (v *VendingMachine) insertMoney(money int) error {
	return v.currentState.insertMoney(money)
}

func (v *VendingMachine) dispenseItem() error {
	return v.currentState.dispenseItem()
}

func (v *VendingMachine) setState(s State) {
	v.currentState = s
}

func (v *VendingMachine) incrementItemCount(count int) {
	fmt.Printf("adding %d items\n", count)
	v.itemCount = v.itemCount + count
}
