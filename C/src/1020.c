#include <stdio.h>

int main() {
  int days, years;
  scanf("%i", &days);
  years = days / 365;
  days %= 365;
  printf("%i ano(s)\n", years);
  printf("%i mes(es)\n", days / 30);
  printf("%i dia(s)\n", days % 30);
  return 0;
}