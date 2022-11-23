from math import sqrt
a, c = input().split(" ")
b, d = input().split(" ")
a, b, c, d = float(a), float(b), float(c), float(d)

distance = sqrt(((b-a)*(b-a)+(d-c)*(d-c)))
print(f"{distance:.4f}")
