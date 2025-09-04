using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Доступные номиналы (в порядке убывания)
        Dictionary<int, int> banknotes = new Dictionary<int, int>
        {
            {5000, 0},
            {2000, 0},
            {1000, 0},
            {500,  0},
            {200,  0},
            {100,  0}
        };

        Console.WriteLine("Введите сумму для снятия (не более 150000 рублей):");
        if (!int.TryParse(Console.ReadLine(), out int amount) || amount <= 0)
        {
            Console.WriteLine("Ошибка: введите положительное число.");
            return;
        }

        if (amount > 150000)
        {
            Console.WriteLine("Ошибка: нельзя снять больше 150000 рублей за раз.");
            return;
        }

        if (amount % 100 != 0)
        {
            Console.WriteLine("Ошибка: сумма должна делиться на 100.");
            return;
        }

        int remaining = amount;

        // Жадный алгоритм
        foreach (var denom in new List<int>(banknotes.Keys))
        {
            int count = remaining / denom;
            if (count > 0)
            {
                banknotes[denom] = count;
                remaining -= count * denom;
            }
        }

        // Проверяем, всё ли выдали
        if (remaining == 0)
        {
            Console.WriteLine($"Для суммы {amount} рублей нужно выдать:");
            foreach (var kvp in banknotes)
            {
                if (kvp.Value > 0)
                    Console.WriteLine($"{kvp.Value} × {kvp.Key} руб.");
            }
        }
        else
        {
            Console.WriteLine($"Невозможно выдать сумму {amount} рублей доступными купюрами.");
        }
    }
}
