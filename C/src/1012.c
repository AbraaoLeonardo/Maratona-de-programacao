#include <stdio.h>

int main(){
    float sideA,sideB,sideC;
    scanf("%f %f %f",&sideA,&sideB,&sideC);
    printf("TRIANGULO: %.3f\n", (sideA * sideC / 2));
	printf("CIRCULO: %.3f\n", (3.14159 * sideC * sideC));
	printf("TRAPEZIO: %.3f\n", (sideC * (sideA + sideB) / 2));
	printf("QUADRADO: %.3f\n", (sideB * sideB));
	printf("RETANGULO: %.3f\n", (sideA * sideB));
    return 0;
}