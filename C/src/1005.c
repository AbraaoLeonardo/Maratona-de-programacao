#include <stdio.h>

int main(){
    float x,y;
    scanf("%f\n%f",&x,&y);
    float media = (3.5*x+7.5*y)/11;
    printf("MEDIA = %.5f\n",media);
    return 0;
}