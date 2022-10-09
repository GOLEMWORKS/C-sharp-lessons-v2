namespace ООП_l_Статические_методы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Влияние static на свойства и методы класса

            var classExOne = new MyClass(); 

            //classExOne.FooPSV(); - не вызовется, т.к. статические методы не вызываются на уровне экземпляра класса!!!
            MyClass.FooPSV(); //Вызывается на уровне класса, а не его экземпляра!


            //Статические свойства взаимодействуют только с классами, а не с их экземлярами (Аналогично методам)
            MyClass.ThirdInt = 12;
            MyClass.FourthInt = 32;


            //Класс со счётчиком экземпляров.
            var ex1 = new MyClassCounter();
            var ex2 = new MyClassCounter();
            var ex3 = new MyClassCounter();

            Console.WriteLine(MyClassCounter.Counter); //Статическое свойство
            Console.WriteLine(MyClassCounter.GetCounter()); //Статический метод
            Console.WriteLine(ex1.GetObjectsCount()); //Не статический метод, для получения информации о кол-ве объектов класса, через один объект
            Console.WriteLine(ex1.ObjectsCount); //Обращаемся к не статическому свойству (На уровне экземпляра класса)
        }
    }

    class MyClass
    {
        private static int firstInt; //ОБЩЕЕ ДЛЯ ВСЕХ ЭКЗЕМПЛЯРОВ КЛАССА

        private int secondInt;


        //Статическое свойство класса
        private static int thirdInt;

        public static int ThirdInt
        {
            get { return thirdInt; }
            set { thirdInt = value; }
        }

        public static int FourthInt { get; set; } //Аналогично с автосвойствами

        public static void FooPSV() //Можно использовать метод без создания экземпляра класса. Аналогично общий метод для всех экземпляров класса
        {
            Console.WriteLine("FooPSV");

            //В методе можно использовать тоько статические члены класса
            firstInt = 1;
            Console.WriteLine(firstInt);

            //Обычно статические методы используются для создания инструметария, на пример: Сортировка, вывод на консоль и т.д.
            //Теряется возможность использования полиморфизма!!!
        }

        public void BarPV()
        {
            Console.WriteLine("BarPV");
            Console.WriteLine(firstInt);
        }
    }

    class MyClassCounter
    {
        private static int counter;

        public static int Counter
        {
            get { return counter; }
            //Сеттер убран для того, чтобы нельзя было изменить счётчик.
            //Для использования сеттера внутри класса требуется приписать к нему модификатор private
            //Для сохранения инкапсуляции
        }

        public int ObjectsCount
        {
            get { return counter; }
            //Сеттер убран для того, чтобы нельзя было вообще взаимодействовать с полем
            //counter через свойства
        }


        public MyClassCounter()
        {
            counter++;
        }

        public static int GetCounter()
        {
            return counter;
        }

        public int GetObjectsCount()
        {
            return counter;
        }
    }
}