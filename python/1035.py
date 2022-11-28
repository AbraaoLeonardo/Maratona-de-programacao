a, b, c, d = input().split(" ")
a, b, c, d = int(a), int(b), int(c), int(d)
valor_aceito = "Valores nao aceitos"
if d > a and b > c:
    if a+b < c+d:
        if (c > 0 and d > 0):
            if a % 2 == 0:
                valor_aceito = "Valores aceitos"
print(valor_aceito)
