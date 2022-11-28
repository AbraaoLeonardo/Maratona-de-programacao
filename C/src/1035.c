#include <stdio.h>

int main() {
  int a, b, c, d, aux = 0;
  scanf("%i %i %i %i", &a, &b, &c, &d);
  if (d > a && b > c)
    if (d + c > b + a)
      if (c > 0 && d > 0)
        if (a % 2 == 0)
          aux = 1;

  if (aux == 0)
    printf("Valores não aceitos\n");
  else
    printf("Valores aceitos\n");
  return 0;
}