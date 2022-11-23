package main

import "fmt"

func main() {
	var seconds int
	fmt.Scan(&seconds)
	hours := seconds / 3600
	seconds = seconds % 3600
	minutes := seconds / 60
	seconds = seconds % 60
	fmt.Printf("%d:%d:%d\n", hours, minutes, seconds)
}
