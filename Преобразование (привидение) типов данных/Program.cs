﻿namespace Преобразование__привидение__типов_данных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12; //работает. Пример нявного (implicit) преобразования(Компиляор сам преобразовал типы данных)
            //double a = 5,2 - не работает
            TestFloat(a);

            //Явное (explicit) преобразование делается самим программистом
            double b = 32.1;
            float f = (float)b;// Пример явного (explicit) преобразования

            //Т.к. разные типы данных могут хранить разный диапазон значений, поэтому при приведении типа данных с большим диапазоном значений к типу данных
            //с меньшим следует применять явное (explicit) преобразование, если ситуация обратная, то используется неявное (implicit) преобразование  

            TestFloat((float)b); // Мы допускаем потенциальную утечку данных, но говорим компилятору, что переменная точно войдёт в диапазон

            //Явное преобразовани = Сужающее. Явно большой объект в меньшую коробку
            //Неявное преобразование = Расштряющее. Маленький объект в большую коробку
        }

        static void TestFloat(float insertValue)
        {
            Console.WriteLine(insertValue);
        }
    }
}