package main

import "fmt"

func main() {
	var x, y, z float64
	fmt.Scan(&x)
	fmt.Scan(&y)
	fmt.Scan(&z)
	var average float64 = (2*x + 3*y + 5*z) / 10
	fmt.Printf("MEDIA = %.1f\n", average)
}
