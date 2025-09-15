import numpy as np

# Создаем массив
arr = np.array([3, 1, 4, 1, 5, 9, 2, 6, 5])

# Сортируем по убыванию
# Сначала сортируем по возрастанию, потом переворачиваем
sorted_arr = np.sort(arr)[::-1]

print("\nИсходный массив:")
print(arr)
print("Отсортированный по убыванию:")
print(sorted_arr)