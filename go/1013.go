package main

import (
	"fmt"
	"math"
)

func main() {
	var a, b, c float64
	fmt.Scanln(&a, &b, &c)
	maior := (a + b + math.Abs(a-b)) / 2
	result := (maior + c + math.Abs(maior-c)) / 2
	fmt.Printf("%d eh o maior\n", int(result))
}
