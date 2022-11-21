package main

import "fmt"

func main() {
	var x, y int
	fmt.Scan(&x)
	fmt.Scan(&y)
	fmt.Printf("PROD = %v\n", (x * y))
}
