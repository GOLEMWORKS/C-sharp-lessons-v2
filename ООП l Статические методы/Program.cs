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
        }
    }

    class MyClass
    {
        private static int firstInt; //ОБЩЕЕ ДЛЯ ВСЕХ ЭКЗЕМПЛЯРОВ КЛАССА

        private int secondInt;

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
}