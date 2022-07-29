namespace ДЗ9_Методы
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание 1: Вывод строки из символов, количество и тип символа указывает пользователь" +
                        "\nЗадание 2: Поиск элемента массива (int) и возвращение первого найденного индекса элемента" +
                        "\nВведите номер задания:");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            string s;
                            int c;

                            Console.WriteLine("Введите символ:");
                            s = Console.ReadLine();

                            try
                            {
                                Console.WriteLine("Сколько раз он должен повторяться:");
                                c = int.Parse(Console.ReadLine());
                                SymbolsLine(c, s);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Введите целое число!");
                            }

                            Console.ReadLine();
                        }
                        break;

                    case "2":
                        Console.WriteLine("Ниже представлен массив из 20 символов. Введите число, индекс которого (при наличии) будет выведен в консоль:");
                        int length = 20, number, index;

                        Random random = new Random();

                        int[] arrayHW = new int[length];

                        for (int i = 0; i < length; i++)
                        {
                            arrayHW[i] = random.Next(100);
                        }

                        for (int i = 0; i < length; i++)
                        {
                            Console.Write(arrayHW[i] + " ");
                        }
                        Console.WriteLine();

                        try
                        {
                            Console.WriteLine("Введите число: ");
                            number = int.Parse(Console.ReadLine());
                            index = ArrayElement(arrayHW, number);

                            if (index == -1)
                            {
                                Console.WriteLine("Искомый элемент отсутствует в массиве!");
                            }
                            else
                            {
                                Console.WriteLine("Индекс искомого элемента: " + index);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Вы ввели неверный индекс элемента!");
                            Console.ReadLine();
                            continue;
                        }

                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Введён неверный номер задания!");
                        break;
                }
            }
        }

        //Метод, который выводит строку из символов, количество и тип символа которых указывает пользователь
        static void SymbolsLine(int count, string symbol)
        {
            for (int i = 0; i < count ; i++)
            {
                Console.Write(symbol);
            }
        }

        static int ArrayElement(int[] a,int index)
        {
            int num;
            num = Array.IndexOf(a, index);

            return num;
        }
    }
}