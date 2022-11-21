package main

import (
	"fmt"
)

func main() {
	var x int
	var y int
	fmt.Scanln(&x)
	fmt.Scanln(&y)
	var z int = x + y
	fmt.Printf("X = %d\n", z)
}
