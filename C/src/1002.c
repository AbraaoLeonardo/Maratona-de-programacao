#include <stdio.h>

int main(){
    long double R;
    scanf("%Lf",&R);
    long double area = R*R*3.14159;
    printf("A=%.4Lf\n",area);
    return 0;
}