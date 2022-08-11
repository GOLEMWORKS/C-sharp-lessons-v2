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

        static int[] StringToIntArrayParse(string[] array)//Самописный Array.Convert
        {
            int[] intArray = new int[array.Length];
            int n;

            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    int.TryParse(array[i], out n);                 
                    intArray[i] = n;
                }
                catch (Exception)//Проверка на наличие элементов массива, которые нельзя конвертировать
                {
                    n = 0;
                    continue;
                }
            }

            return intArray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через запятую или пробел: ");
            string[] unparsedString = Console.ReadLine().Split(',',' ');//Split позволяет разделить строку по символам
            int[] parsedStringToInt = StringToIntArrayParse(unparsedString);

            Console.WriteLine("Сумма чисел: " + Sum(parsedStringToInt));
        }          
    }
}