namespace Ступенчатые__Зубчатые__массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Разное количество элементов в строке

            //Объявление зубчатого массива
            int[][] staircaseArray = new int[3][]; // - две квадратные скобки означают то, что мы хотим создать массив массивов
            int[,] rectangleArray = new int[12,2];
          
            Console.WriteLine("\t\tСтупенчатый массив (Массив массивов):\n" + staircaseArray.Rank + " - Количество измерений; " + staircaseArray.Length + " - длина массива");
            Console.WriteLine("\t\tПрямоугольный массив:\n" + rectangleArray.Rank + " - Количество измерений; " + rectangleArray.Length + " - длина массива");

            //Выделение памяти для элементов зубчатого массива:
            staircaseArray[0] = new int[2];
            staircaseArray[1] = new int[5];
            staircaseArray[2] = new int[12];

            staircaseArray[0][1] = 22; //Присвоение значения элементу массива в массиве

            Console.WriteLine("\nЭлемент массива 0 под номером 1 :" + staircaseArray[0][1]);

            //Заполнение ступенчатого массива случайными числами
            Random rand = new Random();

            for (int i = 0; i < staircaseArray.Length; i++) // К-во элементов (массивов) внутри ступенчатого массива
            {
                for (int j = 0; j < staircaseArray[i].Length ; j++) //К-во элементов в каждом вложенном массиве
                {
                    staircaseArray[i][j] = rand.Next(100);
                }
            }

            Console.WriteLine("\n\t\t\t Случайно сгенерированный ступенчатый массив");
            //Вывод элементов в консоль: 
            for (int i = 0; i < staircaseArray.Length; i++) 
            {
                for (int j = 0; j < staircaseArray[i].Length; j++) 
                {
                    Console.Write(staircaseArray[i][j]+ "\t");
                }
                Console.WriteLine();
            }
        }
    }
}