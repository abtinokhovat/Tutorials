package main

type State interface {
	addItem(int) error
	requestItem() error
	insertMoney(int) error
	dispenseItem() error
}
