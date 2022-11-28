package main

import "fmt"

func main() {
	var product, quantity int
	fmt.Scanf("%d %d", &product, &quantity)
	price := []float64{4, 4.5, 5, 2, 1.5}
	fmt.Printf("Total: R$ %.2f\n", float64(quantity)*price[product-1])
}
