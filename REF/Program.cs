﻿namespace REF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Передача аргументов по ссылке и REF

            int a = 2;

            Foo(ref a);//Передача параметра происходит по ссылке, а не по значению, от чего значение изменится

            Console.WriteLine(a);

            MyStruct myStruct = new MyStruct();
            StructChange(ref myStruct);
            Console.WriteLine(myStruct.a); //Результат -2 с использованием ref, 0 без него

            MyClass myClass = new MyClass();
            ClassChange(myClass);
            Console.WriteLine(myClass.classa); // Без ref выведет 4 (т.к.)классы - это ссылочные типы

            int[] myArray = { 1,4,5,6};
            ArrayChange(ref myArray);
            Console.WriteLine((myArray?[0])??0); // Без ref выдаёт 1, но с ref - значение, которое есть у нас в методе
            //Когда обращаемся к элементу массива, то работаем с данными из управляемой кучи по ссылке, но если работаем с самой ссылкой, то
            //при её изменении мы работаем только с ней, но область в памяти остаётся и всё ещё доступна. Стираем ссылку у одного из ярлыков etc.
            //Через ref мы меняем ссылку по ссылке. При передачи в параметр - меняется данные, но если передать с ref ссылку, то можно
            //менять саму ссылку

            // Проверка на null и вывод значения по умолчанию в массивах пример
        }

        static void Foo(ref int a) // Типовое использование ref, без него выводится 2, с ним -5
        {
            a = -5;
        }
        //Благоаря ref можно возвращать несколько значений из одного метода, НО НЕ ЗЛОУПОТРЕБЛЯЯ! Это нарушение принципа solid
        //Пригодится при взаимодействии методов и структур

        static void StructChange(ref MyStruct myStruct)
        {
            myStruct.a = -2;
        }

        static void ClassChange(MyClass myClass)
        {
            myClass.classa = 4;
        }

        static void ArrayChange(ref int[] a) //ref для ссылочных типов влияет на саму ссылку к данным
        {
            a = null;
        }
    }

    struct MyStruct // Структуры,разъяснение по ним появится позже в ООП. Относятся к действительным типам
    {
        public int a;
        public double b;
        public float c;
    }

    class MyClass //Классы, появится в ООП. Относятся к ссылочным типам
    {
        public int classa;
        public double classb;
        public float classc;
    }
}