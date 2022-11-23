notes = int(input())
print(notes)
print(f"\n{notes // 100} nota(s) de R$ 100,00")
notes %= 100
print(f"{notes // 50} nota(s) de R$ 50,00")
notes %= 50
print(f"{notes // 20} nota(s) de R$ 20,00")
notes %= 20
print(f"{notes // 10} nota(s) de R$ 10,00")
notes %= 10
print(f"{notes // 5} nota(s) de R$ 5,00")
notes %= 5
print(f"{notes // 2} nota(s) de R$ 2,00")
notes %= 2
print(f"{notes} nota(s) de R$ 1,00")
