namespace Массивы_третьей_и_более_мерности
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] newThreeDimArray = new int[4,3,5];

            //Инициализация вручную:
            int[,,] secondThreeDimArray = 
            {
                {
                    {1,2,5 },
                    {3,6,2 },
                    {2,7,9 }
                },
                {
                    {6,2,1 },
                    { 8,4,3},
                    { 7,2,5}
                },
                {
                    {12,3,5},
                    { 8,2,9},
                    { 0,2,4}
                }
            };

            //(Чем больше измерений, тем больше циклов)

            Console.WriteLine("\n\t\t Трёхмерный прямоугольный массив");

            //Заполнение массива случайными числами
            Random rand = new Random();

            for (int i = 0; i < newThreeDimArray.GetLength(0); i++) 
            {
                for (int j = 0; j < newThreeDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < newThreeDimArray.GetLength(2); k++)
                    {
                        newThreeDimArray[i, j, k] = rand.Next(100);
                    }
                }
            }


            //Вывод массива

            for (int i = 0; i < newThreeDimArray.GetLength(0); i++)
            {
                Console.WriteLine("Page #" + (i + 1));

                for (int j = 0; j < newThreeDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < newThreeDimArray.GetLength(2); k++)
                    {
                        Console.Write(newThreeDimArray[i,j,k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\t\t Трёхмерный зубчатый массив");

            //Заполнение случайными числами, массивы вложенные в массив имеют случайную длину

            int[][][] threeDimStairArray = new int[rand.Next(2, 6)][][]; // 2 - минимальное значение, через запятую 6 - максимальное

            for (int i = 0; i < threeDimStairArray.Length; i++)
            {
                threeDimStairArray[i] = new int[rand.Next(4, 8)][];

                for (int j = 0; j < threeDimStairArray[i].Length; j++)
                {
                    threeDimStairArray[i][j] = new int[rand.Next(3, 7)];
                    for (int k = 0; k < threeDimStairArray[i][j].Length; k++)
                    {
                        threeDimStairArray[i][j][k] = rand.Next(100);
                    }
                }
            }

            for (int i = 0; i < threeDimStairArray.Length; i++)
            {
                Console.WriteLine("Page #" + (i + 1));
                for (int j = 0; j < threeDimStairArray[i].Length; j++)
                {
                    for (int k = 0; k < threeDimStairArray[i][j].Length; k++)
                    {
                        Console.Write(threeDimStairArray[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}