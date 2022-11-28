#include <math.h>
#include <stdio.h>

int main() {
  float a, b, c, root, r1, r2;
  scanf("%f %f %f", &a, &b, &c);
  root = b * b - 4 * a * c;
  if (root < 0 || a == 0)
    printf("Impossivel calcular\n");
  else {
    r1 = (-b + sqrtf(root)) / (2 * a);
    r2 = (-b - sqrtf(root)) / (2 * a);
    printf("R1 = %.5f\n", r1);
    printf("R2 = %.5f\n", r2);
  }
  return 0;
}