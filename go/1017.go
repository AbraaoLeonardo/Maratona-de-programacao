package main

import "fmt"

func main() {
	var hour, speed int
	fmt.Scan(&hour)
	fmt.Scan(&speed)
	var fuel_spent float64 = float64(hour) * float64(speed) / 12
	fmt.Printf("%.3f\n", fuel_spent)
}
