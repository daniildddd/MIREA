import pandas as pd

url = "https://raw.githubusercontent.com/akmand/datasets/master/iris.csv"
df = pd.read_csv(url)

print("Первые 5 строк данных:")
print(df.head())
print("\nНазвания колонок:")
print(df.columns)

# Нормализация первого признака (sepal_length_cm) с минимальным преобразованием
# Минимальное преобразование(x - min) / (max - min)
min_val = df['sepal_length_cm'].min()
max_val = df['sepal_length_cm'].max()
df['sepal_length_normalized'] = (df['sepal_length_cm'] - min_val) / (max_val - min_val)

# Нормализация второго признака (sepal_width_cm) с z-масштабированием
# Z-масштабирование(x - mean) / std
mean_val = df['sepal_width_cm'].mean()
std_val = df['sepal_width_cm'].std()
df['sepal_width_z_scaled'] = (df['sepal_width_cm'] - mean_val) / std_val

# Посмотрим на результаты
print("\nРезультаты нормализации:")
print(df[['sepal_length_cm', 'sepal_length_normalized', 'sepal_width_cm', 'sepal_width_z_scaled']].head())

print("\nПроверка нормализации:")
print("Минимальное значение sepal_length_normalized:", df['sepal_length_normalized'].min())
print("Максимальное значение sepal_length_normalized:", df['sepal_length_normalized'].max())
print("Среднее значение sepal_width_z_scaled:", df['sepal_width_z_scaled'].mean())
print("Стандартное отклонение sepal_width_z_scaled:", df['sepal_width_z_scaled'].std())