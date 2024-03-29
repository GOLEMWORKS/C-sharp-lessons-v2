﻿namespace Цикл__FOR._Специфика_работы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                /*
                int length = int.Parse(Console.ReadLine());

                for (int i = 0; i < length; i++) - Все указанные в круглых скобках секции не обязательны! НО есть ограничения!
                {
                    Console.WriteLine(i);
                }
                
                Если сделать пустой цикл for (;;) то по итогу выйдет бесконечный цикл, это связано с отсутствием условия проверки (вторая секция) 
                Количество секций вариативно. Можно 1 2 или 3.
                 */

            int i = 0;
            for (; i < 3; i++)
            {
                Console.WriteLine("For 1 = " + i);
            }

            for (; i < 5; i++)
            {
                Console.WriteLine("For 2 = " + i);
            }  // один цикл начинает работу после другого

            Console.WriteLine("----------------------------------------------------");

            //Если оставить переменную, условие проверки и убрать секцию с инкрементом, то получаем бесконечный цикл. 

            //Инкремент можно ставить и во внутрь цикла:

            for (int a = 0; a < 5;)//Если ставим инкремент после вывода. i заменено на a т.к. выше переменная уже использвуется!
            {
                Console.WriteLine("Инкремент стоит после вывода - " + a);
                a++;
            }
            Console.WriteLine("----------------------------------------------------");
            for (int a = 0; a < 5;)//Если ставим инкремент перед выводом. i заменено на a т.к. выше переменная уже использвуется!
            {
                a++;
                Console.WriteLine("Инкремент стоит перед выводом - " + a);
            }

            Console.WriteLine("----------------------------------------------------");

            // Использование нескольких переменных и условий в цикле:
            //Переменную можно определять вне цикла, но при этом требуется указывать тип данных
            for (int a = 0, b = 12; a < 10 && b > 9; a++, b--)
            {
                Console.WriteLine("a: " + a + " b: " + b);
                Console.WriteLine("");
                //j++ или a++ 
            }

            Console.WriteLine("----------------------------------------------------");

            // Вывод цикла for в обратном порядке: 

            Console.WriteLine("Введите число, с которого начнётся отсчёт: ");
            try
            {
                int n = int.Parse(Console.ReadLine()); // Если нужно ограничить видимость переменной n, то вносим данное выражение в первую секцию!

                for (; n >= 0; n--)
                {
                    Console.WriteLine(n);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("ОШИБКА. Неверный тип данных!");
            }

            Console.WriteLine("----------------------------------------------------");

            for (int a = 0, b = 10; a <= 10 && b >= 0; a++, b--)
            {
                Console.WriteLine("a:" + a + " b: " + b);
            }
        }
    }
}