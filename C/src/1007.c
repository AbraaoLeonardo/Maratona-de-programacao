#include <stdio.h>

int main(){
    int a,b,c,d;
    scanf("%i\n%i\n%i\n%i",&a,&b,&c,&d);
    int diferenca = a*b-c*d;
    printf("DIFERENCA = %i\n",diferenca);
    return 0;
}