import numpy as np

# Создаем пустую матрицу 8x8
chessboard = np.empty((8, 8), dtype=int)

# Заполняем в шахматном порядке
for i in range(8):
    for j in range(8):
        # Если сумма индексов четная - ставим 1, иначе 0
        chessboard[i, j] = 1 if (i + j) % 2 == 0 else 0

print("Шахматная доска 8x8:")
print(chessboard)