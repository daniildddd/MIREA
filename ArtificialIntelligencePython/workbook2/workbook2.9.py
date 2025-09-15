import pandas as pd

# Загружаем данные о титаниках (в них есть информация о классе пассажиров)
url = "https://raw.githubusercontent.com/mwaskom/seaborn-data/master/titanic.csv"

df = pd.read_csv(url)
print("Данные успешно загружены!")

# 1 Анализ характеристик фрейма данных
print("\n=== АНАЛИЗ ХАРАКТЕРИСТИК ФРЕЙМА ДАННЫХ ===")
print("\nПервые 5 строк данных:")
print(df.head())

print("\nИнформация о данных:")
print(df.info())

print("\nОсновные статистические характеристики числовых данных:")
print(df.describe())

print("\nРазмер фрейма данных:", df.shape)
print("Названия колонок:", list(df.columns))

# 2 Выбор отдельных данных и срезов
print("\n=== ВЫБОР ОТДЕЛЬНЫХ ДАННЫХ И СРЕЗОВ ===")
print("\nПервые 10 строк:")
print(df.head(10))

print("\nКолонки 'age' и 'fare':")
print(df[['age', 'fare']].head())

print("\nСтроки с 5 по 10:")
print(df.iloc[5:11])

# 3 Отбор строк на основе условия (пассажиры первого класса)
first_class_passengers = df[df['class'] == 'First']

print("Новый фрейм данных с пассажирами первого класса:")
print(first_class_passengers)
print(f"\nРазмер нового фрейма: {first_class_passengers.shape}")