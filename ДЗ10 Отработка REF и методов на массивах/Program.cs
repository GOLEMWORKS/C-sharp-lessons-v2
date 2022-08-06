namespace ДЗ10_Отработка_REF_и_методов_на_массивах
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание 1: Изменение кол-ва элементов в массиве через метод Resize" +
                    "\nЗадание 2: Добавление элемента в конец, начало или по индеку в массив" +
                    "\nЗадание 3: Удаление элемента с конца, начала или по индеку в массиве");
                Console.WriteLine("\n\t\tВведите номер задания:");

                int taskNum;
                try
                {
                    taskNum = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите числовое значение!");
                    Console.ReadLine();
                    continue;
                }

                switch (taskNum)
                {
                    case 1:
                        Console.WriteLine("Задание 1: Изменение кол-ва элементов в массиве через метод Resize");
                        break;

                    case 2:
                        Console.WriteLine("Задание 2: Добавление элемента в конец, начало или по индеку в массив");
                        break;

                    case 3:
                        Console.WriteLine("Задание 3: Удаление элемента с конца, начала или по индеку в массиве");
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверный номер задания, попробуйте снова!");
                        break;
                }





                Console.ReadLine();
            }
        }
    }
}