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
                Console.Write("\n\t\tВведите номер задания: ");

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
                        Console.WriteLine("Задание 1: Изменение кол-ва элементов в массиве через метод myResize");
                        
                            int[] firstTaskArray = RandomArray();

                            Console.WriteLine("Текущий массив состоит из " + firstTaskArray.Length + " элементов");
                            foreach (var item in firstTaskArray)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine("");

                        Console.WriteLine("Введите новую длину для массива. По умолчанию длина установится на 1!");
                        
                        int newFirstTaskArraySize = IsNumber(Console.ReadLine());

                        myResize(ref firstTaskArray, newFirstTaskArraySize);

                        Console.WriteLine("Новый размер массива: " + firstTaskArray.Length);
                            foreach (var item in firstTaskArray)
                            {
                                Console.Write(item + " ");
                            }

                        
                        break;

                    case 2:
                        Console.WriteLine("Задание 2: Добавление элемента в конец, начало или по индеку в массив");

                        int[] secondTaskArray = RandomArray();


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

        static int[] RandomArray()
        {
            Random randomNumber = new Random();

            int[] array = new int[randomNumber.Next(10)];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(100);
            }

            return array;
        }

        static int IsNumber(string s)
        {
            try
            {
                int a = int.Parse(s);
                return a;
            }
            catch (Exception)
            {
                int defNum = 1;
                return defNum;
            }
        }

        static void myResize(ref int[] array, int newSize)// Самописный аналог resize
        {

            switch (newSize > 0)
            {
                case true:
                    break;

                case false:
                    newSize = 1;
                    break; 
            }

            int[] newArray = new int[newSize];

            if (array.Length < newSize)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray; // переопределяем ссылку на данные
            }
            else if (array.Length > newSize)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray; 
            }   
        }
        
    }
}