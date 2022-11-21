#include <stdio.h>

int main(){
    int hour,number;
    float pay;
    scanf("%i\n%i\n%f",&number,&hour,&pay);
    printf("NUMBER = %i\n",number);
    printf("SALARY = U$ %.2f\n",hour*pay);
    return 0;
}