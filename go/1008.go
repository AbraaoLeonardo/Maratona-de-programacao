package main

import "fmt"

func main() {
	var number, hour int
	var price float64
	fmt.Scan(&number)
	fmt.Scan(&hour)
	fmt.Scan(&price)
	fmt.Printf("NUMBER = %v\n", number)
	var salary float64 = float64(hour) * price
	fmt.Printf("SALARY = U$ %.2f\n", salary)
}
