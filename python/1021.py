deposito = input()
notes, moedas = deposito.split(".")
notes = int(notes)
moedas = int(moedas)

print("NOTAS")
print(f"{notes // 100} nota(s) de R$ 100.00")
notes %= 100
print(f"{notes // 50} nota(s) de R$ 50.00")
notes %= 50
print(f"{notes // 20} nota(s) de R$ 20.00")
notes %= 20
print(f"{notes // 10} nota(s) de R$ 10.00")
notes %= 10
print(f"{notes // 5} nota(s) de R$ 5.00")
notes %= 5
print(f"{notes // 2} nota(s) de R$ 2.00")
notes %= 2
print("MOEDAS")
print(f"{notes} moeda(s) de R$ 1.00")
print(f"{moedas // 50} moeda(s) de R$ 0.50")
moedas %= 50
print(f"{moedas // 25} moeda(s) de R$ 0.25")
moedas %= 25
print(f"{moedas // 10} moeda(s) de R$ 0.10")
moedas %= 10
print(f"{moedas // 5} moeda(s) de R$ 0.05")
moedas %= 5
print(f"{moedas} moeda(s) de R$ 0.01")
