namespace ДЗ11_Отработка_рекурсии
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\tДЗ11: ОТРАБОТКА РЕКУРСИИ" +
                    "\n Задание 1: Вывод массива с помощью рекурсии (Массив генерирую рандомно)" +
                    "\n Задание 2: Сумма элементов массива (Аналогично рандомного)" +
                    "\n Задание 3: Сумма цифр введённого числа");
                Console.Write(" Введите номер задания: ");
                int.TryParse(Console.ReadLine(), out int i);// Отработка перевода 
                switch (i)
                {
                    case 1:
                        Console.WriteLine(" Задание 1: Вывод массива с помощью рекурсии (Массив генерирую рандомно)");
                        int[] firstTaskArray = RandomIntArray();
                        ArrayDisplayByRecursion(firstTaskArray);
                        break;

                    case 2:
                        Console.WriteLine(" Задание 2: Сумма элементов массива (Аналогично рандомного)");
                        int[] secondTaskArray = RandomIntArray();
                        ArrayDisplayByRecursion(secondTaskArray);

                        Console.Write("\n Сумма элементов: ");
                        ArrayRecursionSum(secondTaskArray);
                        break;

                    case 3:
                        Console.WriteLine(3);
                        break;

                    default:
                        Console.WriteLine(" Неизвестный номер задания");
                        break;
                }

                Console.ReadLine();
            }
        }

        static int[] RandomIntArray()
        {
            int[] IntArray = new int[12];
            Random random = new Random();

            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] = random.Next(100);
            }

            return IntArray;
        }

        static void ArrayDisplayByRecursion(int[] Array, int i = 0)
        {
            if (i > (Array.Length - 1))
            {
                return;
            }
            Console.Write(Array[i] + " ");
            i++;
            ArrayDisplayByRecursion(Array, i);
        }

        static void ArrayRecursionSum(int[] Array,int counter = 0, int elementsSum = 0)
        {
            if (counter > (Array.Length - 1))
            {
                Console.WriteLine(elementsSum);
                return;
            }
           
            elementsSum += Array[counter];
            counter++;
            
            ArrayRecursionSum(Array, counter, elementsSum);
        }
    }
}