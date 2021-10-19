using System;
//пространоство имен
namespace ConsoleSetting
{
    //класс программы
    class Program
    {
        //точка начала выполнения команды
       static void Main(string[] args)
       {
        // переменная предоставляющая текст в 16-ти значном коде
        string name = "Преподаватель";
        //вывод на консоль
        Console.WriteLine($"{name}");
        Console.WriteLine("Доцент кафедры Социально-Экономических Наук");
        Console.WriteLine("Стаж работы: 20 лет");
        Console.WriteLine("Начало занятий: 9:00");
        Console.WriteLine("Окончание занятий: 16:00");
        Console.WriteLine("Дополнительные занятия: 17:00-18:00");
            //переменная используемая для математических измерений
            double x, y, z, r, k, f, m, n;
            x = 9;
            y = 16;
            z = 17;
            r = 18;
            k = (y - x) + r - z;
            Console.WriteLine("количество рабочих часов в день: " + k);
            f = (k * 6) * 4;
            Console.WriteLine("количество рабочих часов в месяц: " +  f);
            m = 135;
            n = m * f;
            Console.WriteLine("стоимость рабочего часа: 135. Заработная плата в месяц: " +  n);


       }
    } 
}









