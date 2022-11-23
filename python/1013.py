a, b, c = input().split(" ")
a, b, c = int(a), int(b), int(c)
maior = (a+b+abs(a-b))/2
result = int((maior+c+abs(maior-c))/2)
print(f"{result} eh o maior")
