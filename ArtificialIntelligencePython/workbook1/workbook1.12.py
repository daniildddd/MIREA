import math

x = float(input("Введите число x: "))
y = float(input("Введите число y: "))

print("Доступные команды:")
print("  add - сложение (x + y)")
print("  sub - вычитание (x - y)")
print("  mul - умножение (x * y)")
print("  div - деление (x / y)")
print("  pow - возведение в степень (x^y)")
print("  exp - экспонента (e^(x+y))")
print("  sin - синус (sin(x+y))")
print("  cos - косинус (cos(x+y))")

op = input("Введите операцию: ").strip().lower()

if op == "add":
    print(x + y)
elif op == "sub":
    print(x - y)
elif op == "mul":
    print(x * y)
elif op == "div":
    print("Ошибка" if y == 0 else x / y)
elif op == "pow":
    print(x ** y)
elif op == "exp":
    print(math.exp(x + y))
elif op == "sin":
    print(math.sin(x + y))
elif op == "cos":
    print(math.cos(x + y))
else:
    print("Ошибка")