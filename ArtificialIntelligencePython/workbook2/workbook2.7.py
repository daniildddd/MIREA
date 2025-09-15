import pandas as pd
import math

# Создаем две точки (Series)
a = pd.Series([1, 2, 3])
b = pd.Series([4, 5, 6])

distance = 0
for i in range(len(a)):
    distance += (a[i] - b[i]) ** 2
distance = math.sqrt(distance)

print("Точка a:")
print(a)
print("Точка b:")
print(b)
print("Евклидово расстояние между a и b:", distance)