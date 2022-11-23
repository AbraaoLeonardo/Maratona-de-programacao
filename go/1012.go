package main

import "fmt"

func main() {
	var sideA, sideB, sideC float64
	fmt.Scanln(&sideA, &sideB, &sideC)
	fmt.Printf("TRIANGULO: %.3f\n", (sideA * sideC / 2))
	fmt.Printf("CIRCULO: %.3f\n", (3.14159 * sideC * sideC))
	fmt.Printf("TRAPEZIO: %.3f\n", (sideC * (sideA + sideB) / 2))
	fmt.Printf("QUADRADO: %.3f\n", (sideB * sideB))
	fmt.Printf("RETANGULO: %.3f\n", (sideA * sideB))
}
