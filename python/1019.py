seconds = int(input())
hours = seconds//3600
seconds = seconds % 3600
print(f"{hours}:{seconds//60}:{seconds%60}")
