package main

import (
	"fmt"
	"math"
)

func main() {
	var a, b, c, root, r1, r2 float64
	fmt.Scanf("%f %f %f", &a, &b, &c)
	root = b*b - 4*a*c
	if root < 0 || a == 0 {
		fmt.Println("Impossivel calcular")
	} else {
		r1 = (-b + math.Sqrt(root)) / (2 * a)
		r2 = (-b - math.Sqrt(root)) / (2 * a)
		fmt.Printf("R1 = %.5f\n", r1)
		fmt.Printf("R2 = %.5f\n", r2)
	}
}
