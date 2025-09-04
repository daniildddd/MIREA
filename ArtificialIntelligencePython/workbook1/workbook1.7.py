x = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]

# Метод двух указателей
left = 0
right = len(x) - 1

while left < right:
    # Если оба индекса четные, меняем элементы местами
    if left % 2 == 0 and right % 2 == 0:
        x[left], x[right] = x[right], x[left]
        left += 1
        right -= 1
    # Если левый индекс нечетный, двигаем левый указатель
    elif left % 2 != 0:
        left += 1
    # Если правый индекс нечетный, двигаем правый указатель
    elif right % 2 != 0:
        right -= 1

print(x)