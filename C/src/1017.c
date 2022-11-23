#include <stdio.h>

int main() {
  float hour, speed;
  scanf("%f\n%f", &hour, &speed);
  float spent_fuel = hour * speed / 12;
  printf("%.3f\n", spent_fuel);
  return 0;
}