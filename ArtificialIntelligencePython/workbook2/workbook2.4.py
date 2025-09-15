import numpy as np

# Создаем матрицу 5x5 из нулей
matrix = np.zeros((5, 5), dtype=int)

# Делаем границы равными 1
for i in range(5):
    for j in range(5):
        # Если это первая или последняя строка, либо первый или последний столбец
        if i == 0 or i == 4 or j == 0 or j == 4:
            matrix[i, j] = 1

print("Матрица с 0 внутри и 1 на границах:")
print(matrix)