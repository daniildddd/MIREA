import numpy as np

# Создаем матрицу с помощью arange и преобразуем в 5x5
matrix = np.arange(5)  # Создаем массив [0,1,2,3,4]
matrix = np.tile(matrix, (5, 1))  # Повторяем массив 5 раз по вертикали

print("\nМатрица 5x5 со значениями от 0 до 4:")
print(matrix)