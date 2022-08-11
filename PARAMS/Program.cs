namespace PARAMS
{
    internal class Program
    {
        //Используется для воизбежания перегрузок методов, за счёт приёма методом любого количества параметров
        /*
        static int Sum(int a, int b) - обычный метод
        {
            return a + b; 
        }
        */

        //Метод с использованием params:

        static int Sum(params int[] parameters) //params всегда последний параметр в методе. Только один params в методе!!!
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] numbersForSum = { 1, 4, 5, 2 };
            Console.WriteLine("Сумма чисел: " + Sum(numbersForSum));
        }          
    }
}