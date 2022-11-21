package main

import "fmt"

func main() {
	var a, b, c, d int
	fmt.Scan(&a)
	fmt.Scan(&b)
	fmt.Scan(&c)
	fmt.Scan(&d)
	var result int = a*b - c*d
	fmt.Printf("DIFERENCA = %v\n", result)
}
