namespace ООП_l_Статические_поля_классов
{
    class MyClass
    {
        public int a;

        public static int b;

        private static int c;//Можно использовать и модификаторы

        public void PrintC()
        {
            Console.WriteLine(c);
        }

        public void SetC(int c)
        {
            MyClass.c = c; //С this Не работает т.к. нету экземпляра класса
        }
    }
    //Статические переменные не требуют экземпляра класса, а нестатические наоборот! Им нужен экземпляр класса для функционирования!
    internal class Program
    {
        static void Main(string[] args)
        {
            //Поля у объектов независимы друг от друга в оперативной памяти
            var myClass1 = new MyClass();
            myClass1.a = 12;

            var myClass2 = new MyClass();
            myClass2.a = 34;

            //У статических память даётся одна на всех. Каждый объект будет работать с одной
            //и той же областью в памяти. Нам не требуется создавать экземпляр класса!

            //myClass1.b - не сущаствует, обращаться нужно на уровне самого класса, а не его экземпляра
            MyClass.b = 32;

            var myClass3 = new MyClass();
            myClass3.SetC(4);
            myClass3.PrintC();//Выведет 4

            var myClass4 = new MyClass();
            myClass4.PrintC();//Выведет 4

            //b - общая у всех экземпляров класса, т.к. статическая переменная находится на уровне самого класса, поэтому
            //её изменения будут влиять на все экземпляры!!!
        }
    }
}