#include <stdio.h>

int main() {
  int seconds, hour;
  scanf("%i", &seconds);
  hour = seconds / 3600;
  seconds %= 3600;
  printf("%i:%i:%i\n", hour, seconds / 60, seconds % 60);
  return 0;
}