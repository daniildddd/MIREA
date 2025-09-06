using System;

class Calculator
{
    static void Main()
    {
        double memory = 0;
        bool useMemory = false;
        const double MIN_VALUE = -1000000000;
        const double MAX_VALUE = 1000000000;

        while (true)
        {
            double firstNumber;
            Console.WriteLine("Введите первое число или команду 'M', чтоб достать число из памяти:");
            string input = Console.ReadLine() ?? string.Empty;
            
            if (input.ToUpper() == "M" && useMemory)
            {
                firstNumber = memory;
                Console.WriteLine($"Достали из памяти число: {firstNumber}");
            }
            else if (!double.TryParse(input, out firstNumber))
            {
                Console.WriteLine("Неверный ввод. Введите число или достаньте из памяти число - 'M'.");
                continue;
            }
            
            // Проверка диапазона первого числа
            if (firstNumber < MIN_VALUE || firstNumber > MAX_VALUE)
            {
                Console.WriteLine($"Ошибка: Число {firstNumber} выходит за допустимые пределы [{MIN_VALUE}; {MAX_VALUE}]");
                continue;
            }

            Console.WriteLine("Введите операцию (+, -, *, /, %, 1/x, x^2, sqrt, M+, M-):");
            string operation = Console.ReadLine() ?? string.Empty;
            
            double secondNumber;
            if (operation == "1/x" || operation == "x^2" || operation == "sqrt" || operation == "M+" || operation == "M-")
            {
                secondNumber = 0;
            }
            else
            {
                Console.WriteLine("Введите второе число или 'M', чтоб достать число из памяти:");
                input = Console.ReadLine() ?? string.Empty;
                
                if (input.ToUpper() == "M" && useMemory)
                {
                    secondNumber = memory;
                    Console.WriteLine($"Достали из памяти число: {secondNumber}");
                }
                else if (!double.TryParse(input, out secondNumber))
                {
                    Console.WriteLine("Неверный ввод. Введите число или достаньте из памяти число - 'M'.");
                    continue;
                }
                
                // Проверка диапазона второго числа
                if (secondNumber < MIN_VALUE || secondNumber > MAX_VALUE)
                {
                    Console.WriteLine($"Ошибка: Число {secondNumber} выходит за допустимые пределы [{MIN_VALUE}; {MAX_VALUE}]");
                    continue;
                }
            }

            double result = 0;
            switch (operation)
            {
                case "+": 
                    result = firstNumber + secondNumber;
                    break;
                case "-": 
                    result = firstNumber - secondNumber;
                    break;
                case "*": 
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Нельзя делить на ноль.");
                        continue;
                    }
                    result = firstNumber / secondNumber;
                    break;
                case "%": 
                    result = firstNumber % secondNumber;
                    break;
                case "1/x": 
                    result = 1 / firstNumber;
                    break;
                case "x^2": 
                    result = firstNumber * firstNumber;
                    break;
                case "sqrt":
                    if (firstNumber < 0)
                    {
                        Console.WriteLine("Нельзя вычислить корень из отрицательного числа.");
                        continue;
                    }
                    result = Math.Sqrt(firstNumber);
                    break;
                case "M+":
                    if (!useMemory)
                    {
                        Console.WriteLine("Память пуста.");
                        continue;
                    }
                    result = firstNumber + memory;
                    break;
                case "M-":
                    if (!useMemory)
                    {
                        Console.WriteLine("Память пуста.");
                        continue;
                    }
                    result = firstNumber - memory;
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    continue;
            }

            // Проверка результата на диапазон
            if (result < MIN_VALUE || result > MAX_VALUE)
            {
                Console.WriteLine($"Ошибка: Результат {result} выходит за допустимые пределы [{MIN_VALUE}; {MAX_VALUE}]");
                continue;
            }

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Сохранить в память результат? (Д/Н)");
            if (Console.ReadLine()?.ToUpper() == "Д")
            {
                // Проверка на переполнение и корректность при сохранении
                if (double.IsInfinity(result))
                {
                    Console.WriteLine("Ошибка: Результат слишком большой для сохранения в памяти.");
                }
                else if (double.IsNaN(result))
                {
                    Console.WriteLine("Ошибка: Результат не является числом.");
                }
                else if (result < MIN_VALUE || result > MAX_VALUE)
                {
                    Console.WriteLine($"Ошибка: Результат {result} выходит за допустимые пределы [{MIN_VALUE}; {MAX_VALUE}]");
                }
                else
                {
                    memory = result;
                    useMemory = true;
                    Console.WriteLine("Сохранено в памяти");
                }
            }

            Console.WriteLine("Завершить выполнение программы? (Д/Н)");
            if (Console.ReadLine()?.ToUpper() == "Д") break;
        }
    }
}
// нужно три файла - .cs
//.csproj
//README(в котором пишем
//1)ФИО
//2) Три ограничения
//3)Три ошибки

// Ограничения по операциям, ограничения по вводимому числу, ограничения математические(деление на ноль и меньше равно нулю считать из такого числа корень)

// написать редми
// функционал описать(соответствует практическому заданию)
// возможные ошибки
// ограничения

// github 
// залить на гит
// в телеграм кидаем ссылку
// 

