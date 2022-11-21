#include <stdio.h>

int main(){
    float x,y,z;
    scanf("%f\n%f\n%f",&x,&y,&z);
    float media = (2*x+3*y+5*z)/10;
    printf("MEDIA = %.1f\n",media);
    return 0;
}