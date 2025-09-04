using System;

class Program
{
    static void Main()
   {
      Console.Write("Введите номер дня недели, с которого начинается май (1-7): ");
      if (int.TryParse(Console.ReadLine(), out int startDay) || startDay<1 || startDay > 7)
      {
         Console.WriteLine("Не верное число");
       }
      else
      {
         Console.WriteLine("Не удалось прочитать число");
      }
      Console.Write("Введите номер дня месяца (1-31): ");
      if (int.TryParse(Console.ReadLine(), out int day) || day < 1 || day > 31)
      {
            Console.WriteLine("Не верное число");
       }
      else
      {
         Console.WriteLine("Не удалось прочитать число");
      }
      // Определяем день недели
      //из начального дня недели и из дня введенего вычитаем единицу потому что начинаем отсчёт с нуля
      //0 понедельник, 6 - суббота
      int dayOfWeek = (startDay-1 +day - 1) % 7;
 Console.WriteLine(dayOfWeek);
      // Проверка на праздник или выходной
      bool isHoliday = dayOfWeek >= 0 && dayOfWeek < 5;

      if ( isHoliday)
        
         Console.WriteLine("Будний день");
      else
          Console.WriteLine("Выходной день");
   }
}
