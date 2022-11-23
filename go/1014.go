package main

import "fmt"

func main() {
	var distance int
	var spend_fuel, comsuption float64
	fmt.Scan(&distance)
	fmt.Scan(&spend_fuel)
	comsuption = float64(distance) / spend_fuel
	fmt.Printf("%.3f km/l\n", comsuption)
}
