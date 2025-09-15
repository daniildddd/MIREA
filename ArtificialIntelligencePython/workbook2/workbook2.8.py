import pandas as pd

# Используем рабочую ссылку на CSV файл с данными о ирисах
url = "https://raw.githubusercontent.com/mwaskom/seaborn-data/master/iris.csv"

df = pd.read_csv(url)
print("Данные успешно загружены!")
print("\nПервые 5 строк данных:")
print(df.head())

print("\nИнформация о данных:")
print(df.info())

print("\nОсновные статистические характеристики:")
print(df.describe())
