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
            double d = 32.1;
            int i = 2;
            // Примеры явного (explicit) преобразования
            float f = (float)d;
            byte b = (byte)i;

            //Т.к. разные типы данных могут хранить разный диапазон значений, поэтому при приведении типа данных с большим диапазоном значений к типу данных
            //с меньшим следует применять явное (explicit) преобразование, если ситуация обратная, то используется неявное (implicit) преобразование  

            TestFloat((float)b); // Мы допускаем потенциальную утечку данных, но говорим компилятору, что переменная точно войдёт в диапазон

            //Явное преобразовани = Сужающее. Явно большой объект в меньшую коробку
            //Неявное преобразование = Расштряющее. Маленький объект в большую коробку

            //Сумма элементов с разными типами данных
            int firstValue = 2;
            float secondValue = 3.12F;

            Console.WriteLine(firstValue + secondValue);//int преобразуется в float и происходит сложение float и float
            int result = (int)(firstValue + secondValue);//В результате мы потеряем дробную часть

           //Выполнить конвертацию string в int через явное преобразование нельзя, поэтому используется класс Convert или метод Parse
        }

        static void TestFloat(float insertValue)
        {
            Console.WriteLine(insertValue);
        }
    }
}