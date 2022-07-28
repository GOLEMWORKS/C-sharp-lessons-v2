namespace Заполнение_двумерного_массива_случайными_числами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                uint arrayLength, arrayHeigth; // т.к к-во строк и столбцов не может быть отрицательным

                Console.WriteLine("Введите количество рядов в массиве: ");
                try
                {
                    arrayHeigth = uint.Parse(Console.ReadLine());

                    Console.WriteLine("Введите количество колонок в массиве: ");

                    arrayLength = uint.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целое положительное число!");
                    Console.ReadLine();
                    continue;
                }

                Random random = new Random(); // Генератор случайных чисел

                // Заполнение массива случайными числами и вывод - в разных циклах. На основе solid, single responsobility в ООП;


                //Заполнение массива случайными числами
                int[,] randomNumbersArray = new int[arrayHeigth, arrayLength ];

                for (int i = 0; i < randomNumbersArray.GetLength(0); i++) // i - y; j - x т.к. особо никто не замарачивается с изменением имён переменных
                {
                    for (int j = 0; j < randomNumbersArray.GetLength(1); j++)
                    {
                        randomNumbersArray[i, j] = random.Next(100);//Если пустно то делает абсолютно случайные и огромные числа. Внутри указано максимальное значение.
                    }
                }


                //Вывод данных из массива
                Console.WriteLine("\t\t\t---------Ваш массив----------");
                for (int y = 0; y < randomNumbersArray.GetLength(0); y++)
                {
                    for (int x = 0; x < randomNumbersArray.GetLength(1); x++)
                    {
                        Console.Write(randomNumbersArray[y,x] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}