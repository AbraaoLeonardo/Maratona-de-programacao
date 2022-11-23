#include <math.h>
#include <stdio.h>

int main() {
  double a, b, c, d, result, distance;

  scanf("%lf %lf", &a, &c);
  scanf("%lf %lf", &b, &d);

  result = (b - a) * (b - a) + (d - c) * (d - c);

  distance = sqrt(result);

  printf("%.4lf\n", distance);
  return 0;
}