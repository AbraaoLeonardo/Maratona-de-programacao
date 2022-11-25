#include <stdio.h>

int main() {
  int notes, moedas;
  scanf("%i.%i", &notes, &moedas);
  printf("NOTAS:\n");
  printf("%i nota(s) de R$ 100.00\n", notes / 100);
  notes %= 100;
  printf("%i nota(s) de R$ 50.00\n", notes / 50);
  notes %= 50;
  printf("%i nota(s) de R$ 20.00\n", notes / 20);
  notes %= 20;
  printf("%i nota(s) de R$ 10.00\n", notes / 10);
  notes %= 10;
  printf("%i nota(s) de R$ 5.00\n", notes / 5);
  notes %= 5;
  printf("%i nota(s) de R$ 2.00\n", notes / 2);
  notes %= 2;
  printf("MOEDAS:\n");
  printf("%i nota(s) de R$ 1.00\n", notes);
  printf("%i nota(s) de R$ 0.50\n", moedas / 50);
  moedas %= 50;
  printf("%i nota(s) de R$ 0.25\n", moedas / 25);
  moedas %= 25;
  printf("%i nota(s) de R$ 0.10\n", moedas / 10);
  moedas %= 10;
  printf("%i nota(s) de R$ 0.05\n", moedas / 5);
  moedas %= 5;
  printf("%i nota(s) de R$ 0.01\n", moedas);
  return 0;
}