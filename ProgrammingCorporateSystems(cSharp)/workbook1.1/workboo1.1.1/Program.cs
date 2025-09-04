using System;

class Calculator
{
    static void Main()
    {
        double memory = 0;
        bool useMemory = false;

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
            Console.WriteLine("Введите операцию (+, -, *, /, %, 1/x, x^2, sqrt, M+, M-):");
            string operation = Console.ReadLine() ?? string.Empty;
            double secondNumber;
            if (operation == "1/x" || operation == "x^2" || operation == "sqrt" || operation == "M+" || operation == "M-")
            {
                //второе число для этих операций не нужно
                secondNumber = 0; 
            }
            else
            {
                Console.WriteLine("Введите второе число 'M', чтоб достать число из памяти:");
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
            }

            double result = 0;
            switch (operation)
            {
                case "+": result = firstNumber + secondNumber; break;
                case "-": result = firstNumber - secondNumber; break;
                case "*": result = firstNumber * secondNumber; break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Нельзя делить на ноль.");
                        continue;
                    }
                    result = firstNumber / secondNumber;
                    break;
                case "%": result = firstNumber % secondNumber; break;
                case "1/x": result = 1 / firstNumber; break;
                case "x^2": result = firstNumber * firstNumber; break;
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

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Сохранить в память результат? (Д/Н)");
            if (Console.ReadLine()?.ToUpper() == "Д")
            {
                memory = result;
                useMemory = true;
                Console.WriteLine("Сохранено в памяти");
            }

            Console.WriteLine("Завершить выполнение программы? (Д/Н)");
            if (Console.ReadLine()?.ToUpper() == "Д") break;
        }
    }
}