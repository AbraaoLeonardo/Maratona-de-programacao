package main

import (
	"fmt"
	"math"
)

func main() {
	var a, b, c, d float64
	fmt.Scanln(&a, &c)
	fmt.Scanln(&b, &d)
	distance := math.Sqrt((b-a)*(b-a) + (d-c)*(d-c))
	fmt.Printf("%.4f", distance)
}
