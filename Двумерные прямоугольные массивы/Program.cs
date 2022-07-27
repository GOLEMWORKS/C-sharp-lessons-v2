namespace Двумерные_прямоугольные_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Индесы указываются с Y -> index = y;x
            // Прямоугольный массив - в каждом ряду и каждом столбце одинаковое количество элементов

            // Объявление двумерных массивов
            int[,] twoDimensionsArray = new int[3, 5]; //[Строки, колонки]
            twoDimensionsArray[0,2] = 1;

            Console.WriteLine(twoDimensionsArray[0,2] + "\n");

            //Инициализация 

            int[,] twoDimensionsArray2 = new int[,] // new int[,] - можно не указывать
            {
                {1, 22,12,4,1},  // Прямоугольный двумерный массив
                {1, 2,13,4,1},
                {12,42,4,5,98 },
                {12,42,4,5,98 },
                {1, 2,13,4,1},
                {12,42,4,5,98 },
                {65,432,45,6,2 }
            };

            //вывод двумерного массива строкой

            foreach (var item in twoDimensionsArray2) //Цикл для вывода всех элементов коллекции
            {
                Console.Write(item + " ");
            }

            //вывод двумерного массива табличкой
            Console.WriteLine(twoDimensionsArray2.Rank); // .Rank - показывает мерность массива
            Console.WriteLine("\nКоличество эл-в по вертикали:" + twoDimensionsArray2.GetLength(0)); // .GetLength - позволяет узнать к-во элементов в измерении. Нумерация начинается с нуля, поэтому первое измерение = 0, второе = 1
            Console.WriteLine("Количество эл-в по горизонтали:" + twoDimensionsArray2.GetLength(1));

            int ArrayHeight = twoDimensionsArray2.GetLength(0); // За место переменных можно вставлять код с методом GetLength прямо в цикл
            int ArrayWidth = twoDimensionsArray2.GetLength(1);

            Console.WriteLine("\nВывод массива twoDimensionsArray2");
            for (int y = 0; y < ArrayHeight; y++) // Вывод элементов по вертикали
            {
                for (int x = 0; x < ArrayWidth; x++) //Вывод элементов по горизонтали
                {
                    Console.Write(twoDimensionsArray2[y,x] + "\t"); // y - ряд; x - элемент в текущем ряду
                }
                Console.WriteLine();
            }
        }
    }
}