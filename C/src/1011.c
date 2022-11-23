#include <stdio.h>

int main(){
    float R, pi = 3.14159;
    scanf("%f",&R);
    float volume = R*R*R*pi*(4.0*3);
    printf("VOLUME = %.3f",volume);
    return 0;
}
