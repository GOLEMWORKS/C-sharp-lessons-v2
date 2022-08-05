namespace Реальная_работа_с_массивами //System.Linq уже установлен в .NET 6.0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Все массивы - наследники класса Array в C#, поэтому мы можем использовать статические методы этого класса

            int[] myArray = { 12, 123, 3213, 1231,23, 123, 123, 123, 12312, 13, 211, 412, 41, 12, 45, 131, 233, 1412, 4 };

            Console.WriteLine(  myArray.Max() ); // наибольшее число в массиве

            Console.WriteLine( myArray.Where(i => i % 2 == 0).Sum() ); //сумма всех чётных элементов в одну строчку

            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min()); //минимальное нечётное из массива

            int[] mySeccondArray = myArray.Distinct().ToArray();//Только уникальные элементы массива в другом массиве

            int[] myThirdArray = myArray.OrderBy(i => i).ToArray(); //Сортировка в новый массив. Order by descending - сортировка по убыванию

            Array.Sort(myArray); // сортировка через Array и метод Sort

            Array.Find(myArray, i => i <70); // Поиск элементов в массиве по условию. Вынесет первый элемент, удовлетворяющий условию. FindLast - выведет удовлетворяющий условию с конца

            Array.FindAll(myArray, i => i < 70); // Поиск и вывод в отдельный массив всех элементов, соответствующих условию

            Array.FindIndex(myArray, i => i == 12); //Вывод индекса элемента массива (просто число). Если числа в массиве нет, то индекс будет -1. Метод с препиской Last с конца ищет, без преписки с начала

            myArray.Where(i => i < 70).First();//Поиск числа через Linq. Last - последнее. Если в массиве нет нужного элемента, то выдаёт exception
            myArray.Where(i => i % 2 != 0).FirstOrDefault(); // Если нет в массиве требуемого элемента, то выведет стандартное значение для этого типа данных (null, 0 etc.)

            //Linq работает с листами и словарями! (List & Dictionary)

            //Для создания массивов с разными типами данных можно использовать тип object
            object[] objectArray = { 1, "we", 4 };
        }
    }
}