valuer_to_pay = 0
for i in range(2):
    id, quantity, price = input().split(" ")
    valuer_to_pay += int(quantity)*float(price)

print(f"VALOR A PAGAR: R$ {valuer_to_pay:.2f}")
