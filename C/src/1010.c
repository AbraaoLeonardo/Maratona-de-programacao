#include <stdio.h>

int main(){
    int quantity, id;
    float price, total_to_pay = 0;
    for(int i = 0; i < 2; i++){
        scanf("%i %i %f",&id,&quantity,&price);
        total_to_pay += quantity*price
    }
    printf("VALOR A PAGAR: R$ %.2f\n",(total_to_pay));
    return 0;
}