package main

import "fmt"

func main() {
	var R float64
	pi := 3.14159
	fmt.Scan(&R)
	volume := pi * R * R * R * (4 / 3.0)
	fmt.Printf("VOLUME = %.3f\n", volume)
}
