﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_l_Extension_методы
{
    static class MyExtensions //Обязательно статическое!
    {
        //Пример extension метода
        public static void PrintInfo(this DateTime dateTime) //Указываем через this тип данных и переменную
        {
            Console.WriteLine(dateTime);
        }
    }
}
