import numpy as np
import matplotlib.pyplot as plt 
# Создаем массив случайных значений из интервала (0; 1)
np.random.seed(42)  # для воспроизводимости результатов
array = np.random.uniform(0, 1, 20)
print(array)
# # Рассчитываем среднее и медиану
mean_value = np.mean(array)
median_value = np.median(array)

print(f"Среднее значение: {mean_value:.4f}")
print(f"Медианное значение: {median_value:.4f}")
print(f"Разница: {abs(mean_value - median_value):.4f}")

# Строим точечную диаграмму рассеяния
plt.figure(figsize=(10, 6))
plt.scatter(range(len(array)), array, alpha=0.5, s=10)
plt.axhline(mean_value, color='red', linestyle='--', label=f'Среднее: {mean_value:.4f}')
plt.axhline(median_value, color='green', linestyle='--', label=f'Медиана: {median_value:.4f}')
plt.xlabel('Индекс элемента')
plt.ylabel('Значение')
plt.legend()
plt.grid(True, alpha=0.3)
plt.show()