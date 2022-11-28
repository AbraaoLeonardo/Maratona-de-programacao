from math import sqrt
a, b, c = input().split(" ")
a, b, c = float(a), float(b), float(c)
root = b*b-a*4*c
if (root < 0 or a == 0):
    print("Valores invalidos")
else:
    r1 = (-b+sqrt(root))/(2*a)
    r2 = (-b-sqrt(root))/(2*a)
    print(f"R1 = {r1:.5f}")
    print(f"R2 = {r2:.5f}")
