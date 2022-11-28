#include <stdio.h>

int main() {
  int quantity, product;
  float price[5] = {4, 4.5, 5, 2, 1.5};

  scanf("%i %i", &product, &quantity);
  printf("Total: R$ %.2f\n", (quantity * price[product - 1]));
  return 0;
}