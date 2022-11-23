package main

import "fmt"

func main() {
	var total_to_pay float64 = 0
	for i := 0; i < 2; i++ {
		var id, quantity int
		var price float64
		fmt.Scanln(&id, &quantity, &price)
		total_to_pay += float64(quantity) * price
	}
	fmt.Printf("VALOR TOTAL A PAGAR = %.2f\n", total_to_pay)
}
