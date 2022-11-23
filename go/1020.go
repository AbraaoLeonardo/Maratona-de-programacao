package main

import "fmt"

func main() {
	var days int
	fmt.Scan(&days)
	years := days / 365
	days %= 365
	fmt.Printf("%d ano(s)\n", years)
	fmt.Printf("%d mes(es)\n", days/365)
	fmt.Printf("%d dia(s)\n", days%365)
}
