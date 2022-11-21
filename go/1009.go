package main

import "fmt"

func main() {
	var name string
	var sallary, selling float64
	fmt.Scanln(&name)
	fmt.Scanln(&sallary)
	fmt.Scanln(&selling)
	sallary += selling * 0.15
	fmt.Printf("TOTAL = R$ %.2f\n", sallary)
}
