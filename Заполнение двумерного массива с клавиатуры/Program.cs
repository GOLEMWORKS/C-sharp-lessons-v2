namespace Заполнение_двумерного_массива_с_клавиатуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                uint arrayLength, arrayHeigth; // т.к к-во строк и столбцов не может быть отрицательным
                int[,] keyboardArray;

                Console.WriteLine("Введите количество рядов в массиве: ");
                try
                {
                    arrayHeigth = uint.Parse(Console.ReadLine());

                    Console.WriteLine("Введите количество колонок в массиве: ");

                    arrayLength = uint.Parse(Console.ReadLine());

                    if(arrayLength*arrayHeigth >= 30)
                    {
                        Console.WriteLine("Вы действительно хотите ввести в ручную " + (arrayHeigth*arrayLength) + " символов? Введите да или нет");
                        switch(Console.ReadLine())
                        {
                            case "да":
                                {
                                    Console.WriteLine("Моё дело предупредить, заполняй: ");
                                }
                                break;
                            case "нет":
                                continue; // break не имеет смысла т.к. после оператора continue программа возвращается к началу (Циклу while)
                            default:
                                Console.WriteLine("Не понял ответа. Введите в следующий раз да или нет!");
                                Console.ReadLine();
                                continue; // break не имеет смысла т.к. после оператора continue программа возвращается к началу (Циклу while), а не прдолжается с исключением
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целое положительное число!");
                    Console.ReadLine();
                    continue;
                }

                keyboardArray = new int[arrayHeigth,arrayLength];

                for (int i = 0; i < keyboardArray.GetLength(0); i++)
                {
                    for (int j = 0; j < keyboardArray.GetLength(1); j++)
                    {
                        try
                        {
                            Console.WriteLine("Введите элемент массива, расположенный в столбце " + i + " и строке " + j);
                            keyboardArray[i, j] = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ОШИБКА! Введено не целое число! Элемент [" + i + " ; " + j + "] пропущен!");
                            Console.ReadLine();
                            continue;
                        }
                    }
                }

                //Вывод данных из массива
                Console.WriteLine("\t\t\t---------Ваш массив----------");
                for (int y = 0; y < keyboardArray.GetLength(0); y++)
                {
                    for (int x = 0; x < keyboardArray.GetLength(1); x++)
                    {
                        Console.Write(keyboardArray[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}