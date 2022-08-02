namespace NULL
{
    internal class Program
    {

        //null - только с ссылочными и nullable типами

        class MyClass
        {

        }

        struct MyStruct
        {

        }

        static void Main(string[] args)
        {
            //Структурные и значимые типы по умолчанию
            bool a; //false (По умолчанию)

            int b; //0

            double d; // 0

            //Ссылочные типы null

            //null - пустая ссылка, отсутствие данных в куче
            Random random; //null

            int[] arr; //null

            MyClass myClass; //null

            MyStruct myStruct; // По умолчанию

            int[] arr2 = new int[2]; //Если выделить память, то результат будет заполненный массив значимыми типами со значением по умолчанию

            arr2 = null; //Разрыв связи через null. В C++ - это утечка памяти, в C# - память в куче очистится Garbage Collector (GC)

            Foo();// Покидаем область видимости функции Foo с ссылочным типом данных; Ссылки нету, а данные есть, эти данные будут удалены GC 

            //null reference exception - выводится из-за отсутствия данных по указанной ссылке
        }

        static void Foo()
        {
            int rr; // После выхода из функции исчезнет

            int[] r = new int[21];
        }
    }
}