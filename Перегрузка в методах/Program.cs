namespace Перегрузка_в_методах
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // Перегрузка - это реализация одного и тогоже метода несколькими одинаковыми способами. У Console.WriteLine() их 17

            // Самописные методы с перегрузкой:
            int res = Sum(1 , 3 , 5); //vs подсказывает, что у данного метода есть варианты которые принимают 2 параметра и 3 (В данном случае)
            Console.WriteLine(res);

            double dres = Sum(1.2 , 3.1);
            Console.WriteLine("\n" + dres);
        }

        // Добавления описания методам через три чёрточки. Подобное описание можно присваивать и классам!

        /// <summary>
        /// Принимает целые числа (2) и складывает их
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b) //Первая перегрузка с приёмом двух чисел
        {
            return a + b;
        }

        /// <summary>
        /// Принимает целые числа (3) и складывает их
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c) //Вторая перегрузка с приёмом трёх чисел
        {
            return a + b + c;
        }

        /// <summary>
        /// Принимает дробные числа (2) и складывает их
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b) // Третья перегрузка с приёмом дробный чисел
        {
            return a + b;
        }
    }
}