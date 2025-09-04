import numpy as np
import matplotlib.pyplot as plt
import math

# Создаем массив x от 1 до 10 с 10 значениями
x = np.linspace(1, 10, 10)

# Вычисляем значения функции 
y = np.sqrt(1 + np.exp(np.sqrt(x)) + np.cos(x**2))/np.abs(1 - np.sin(x)**3) + np.log(np.abs(2*x))

# Извлекаем первую половину массива
half_length = len(y) // 2
y_slice = y[:half_length]
x_slice = x[:half_length]

# Строим графики
plt.figure(figsize=(10, 5))

# Линейный график для полного массива
plt.plot(x, y,color='blue')

# Точечный график для среза
plt.scatter(x_slice, y_slice, color='red', label='Первая половина', zorder=5)

# Настройки графика
plt.title('')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.grid(True)
plt.show()