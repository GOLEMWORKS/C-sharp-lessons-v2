namespace Одномерный_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray; //Объявление массива

            myArray = new int[5]; //Инициализация массива (Выделение места в оперативке для него)
            //Элементы начинаются с нуля!

            myArray[0] = 10;
            myArray[1] = 12;
            myArray[2] = 92;
            myArray[3] = 50;
            myArray[4] = 32;

            //Вывод массива в столбик

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            } 

            Console.WriteLine("\nВсего элементов в массиве: " + myArray.Length);

            //Инициализация Массива 

            int[] mySecondArray = new int[5] {1,2,3,4,5}; // в фигурных скобках может быть ровно столько элементов, сколько задано при инициализации (int[5])

            int[] myThirdArray = {1,2,4}; // Создаётся массив на то количество элементов, которое указано в фигурных скобках. Можно не указывать тип данных и метод new

            int[] myFourthArray = Enumerable.Range(4,12).ToArray(); // Присваивает элементам массива значения начиная с 4х. Всего элементов в массва 12
        }
    }
}