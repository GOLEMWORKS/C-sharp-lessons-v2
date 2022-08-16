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
                        break;
                    default:
                        Console.WriteLine("Неизвестный номер задания");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}