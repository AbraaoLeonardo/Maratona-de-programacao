#include <stdio.h>
#include <stdlib.h>

int main(){
    int a,b,c;
    scanf("%i %i %i",&a,&b,&c);
    float maior = (a+b+abs(a-b))/2;
    int resultado = (c+maior+abs(c-maior))/2;
    printf("%i eh o maior\n",resultado);
    return 0;
}