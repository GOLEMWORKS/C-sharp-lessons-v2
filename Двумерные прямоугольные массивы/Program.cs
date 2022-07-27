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

            Console.WriteLine(twoDimensionsArray[0,2]);

            //Инициализация 

            int[,] twoDimensionsArray2 = new int[,] // new int[,] - можно не указывать
            {
                {1, 22,12,4,1},  // Прямоугольный двумерный массив
                {1, 2,13,4,1},
                {12,42,4,5,98 },
                {12,42,4,5,98 },
                {12,42,4,5,98 }
            };

            Console.WriteLine("Инициализированный массив");
        }
    }
}