import numpy as np
import matplotlib.pyplot as plt
from scipy.integrate import simpson

# Создание массива x от 0 до 10 с шагом 1
x = np.arange(0, 11, 1)

# Пример функции (замените на вашу функцию)
y = np.abs(np.cos(x * np.exp(np.cos(x) + np.log(x + 1))))
# Вычисление площади с помощью правила трапеций
area = simpson(y, x)

# Визуализация графика с заливкой площади
plt.fill_between(x, y, alpha=0.3)  # Заливка области под кривой
plt.plot(x, y, marker='o')         # Линия графика с точками
plt.title(f'Площадь под кривой: {area}')
plt.xlabel('x')
plt.ylabel('y')
plt.grid(True)
plt.show()