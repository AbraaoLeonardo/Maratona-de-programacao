package main

import "fmt"

func main() {
	var R float64
	fmt.Scan(&R)
	var area float64 = 3.14159 * R * R
	fmt.Printf("A=%.4f\n", area)
}
