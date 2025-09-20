using System;

class Program
{
    static void Main()
    {
        int startDay;
        while (true)
        {
            Console.Write("Введите номер дня недели, с которого начинается месяц (1-пн, ...7-вс) ");
            if (int.TryParse(Console.ReadLine(), out startDay) && startDay >= 1 && startDay <= 7)
            {
                break;
            }
            Console.WriteLine("Неверное число. Пожалуйста, введите число от 1 до 7.");
        }

        int day;
        while (true)
        {
            Console.Write("Введите день месяца ");
            if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31)
            {
                break;
            }
            Console.WriteLine("Неверное число. Пожалуйста, введите число от 1 до 31.");
        }

        Console.WriteLine("---Проверяем выходной ли день ---");
        
        int dayOfWeek = (startDay - 1 + day - 1) % 7;
        bool isWeekend = dayOfWeek == 5 || dayOfWeek == 6;

        if (isWeekend)
        {
            Console.WriteLine("Выходной день");
        }
        else
        {
         Console.WriteLine("Будний день");
        }
    }
}