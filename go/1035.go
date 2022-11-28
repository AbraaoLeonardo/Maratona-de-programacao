package main

import "fmt"

func main() {
	var a, b, c, d int
	fmt.Scanf("%d %d %d %d", &a, &b, &c, &d)
	var aux int = 0
	if d > a && b > c {
		if d+c > b+a {
			if c > 0 && d > 0 {
				if a%2 == 0 {
					aux = 1
				}
			}
		}
	}
	if aux == 0 {
		fmt.Println("Valores não aceitos")
	} else {
		fmt.Println("Valores aceitos")
	}
}
