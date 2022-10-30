using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_l_Extension_методы_Extenssions //Изменяем namespace дабы не засорять общее пространство имён проекта своими методами расширения
{
    static class MyExtensions //Обязательно статическое!
    {
        //Пример extension метода
        public static void PrintInfo(this DateTime dateTime) //Указываем через this тип данных и переменную
        {
            Console.WriteLine(dateTime);
        }

        public static bool IsThisDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek; //Проверка на соответствие текущего дня недели, указанному в методе
        }
    }
}
