#include <stdio.h>

int main(){
    char str[20];
    float salary,selling;
    scanf("%s\n%f\n%f",&str,&salary,&selling);
    float TotalToPay = salary + (selling*15)/100;
    printf("TOTAL = R$ %.2f\n",TotalToPay);
    return 0;
}