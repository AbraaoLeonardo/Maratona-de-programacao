days = int(input())
years = days//365
days %= 365
print(f"{years} ano(s)\n{days//30} mes(es)\n{days%30} dia(s)")
