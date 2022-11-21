package main

import "fmt"

func main() {
	var x, y float64
	fmt.Scan(&x)
	fmt.Scan(&y)
	var media = (x*3.5 + y*7.5) / 11
	fmt.Printf("MEDIA = %.5f\n", media)
}
