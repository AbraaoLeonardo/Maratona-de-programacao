#include <stdio.h>

int main(){
    int distance;
    float spend_fuel;
    scanf("%i\n%f",&distance,&spend_fuel);
    float comsuption = distance/spend_fuel;
    printf("%.3f km/l\n",comsuption);
    return 0;
}