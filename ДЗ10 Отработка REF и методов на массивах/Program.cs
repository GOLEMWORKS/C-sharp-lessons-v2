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
                        ArrayDisplay(firstTaskArray);
                        
                            Console.WriteLine("");

                            Console.WriteLine("Введите новую длину для массива. По умолчанию длина установится на 1!");
                        
                            int newFirstTaskArraySize = IsNumber(Console.ReadLine());

                        myResize(ref firstTaskArray, newFirstTaskArraySize);

                            Console.WriteLine("Новый размер массива: " + firstTaskArray.Length);
                            
                        ArrayDisplay(firstTaskArray);


                        break;

                    case 2:
                            Console.WriteLine("Задание 2: Добавление элемента в конец, начало или по индеку в массив");

                            int[] secondTaskArray = RandomArray();
                        ArrayDisplay(secondTaskArray);
                            Console.WriteLine("\nДлина массива: " + secondTaskArray.Length);

                            Console.WriteLine("Укажите индекс элемента: ");
                            int indexInSecondTask = IsNumber(Console.ReadLine());

                            Console.WriteLine("Укажите значение элемента: ");
                            int valueInSecondTask = IsNumber(Console.ReadLine());

                        InsertByIndex(ref secondTaskArray, indexInSecondTask, valueInSecondTask);
                        ArrayDisplay(secondTaskArray);

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

            int[] array = new int[randomNumber.Next(1,10)];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(100);
            }

            return array;
        }

        static void ArrayDisplay<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
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

        static void myResize<T>(ref T[] array, int newSize)// generic - работает с любыми типами данных
        {

            switch (newSize > 0)
            {
                case true:
                    break;

                case false:
                    newSize = 1;
                    break; 
            }

            T[] newArray = new T[newSize];

                for (int i = 0; i < array.Length && i < newArray.Length; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray; // переопределяем ссылку на данные
             
        }

        static void InsertByIndex(ref int[] array, int index, int value)
        {
            int[] newArray;

            if (array.Length >= index)
            {
                newArray = new int[array.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }

                newArray[index] = value;

                for (int i = index; i < array.Length; i++)
                {
                    newArray[i + 1] = array[i];
                }

            }
            else
            {
                newArray = new int[array.Length + (index - array.Length + 1)];


                for (int i = 0; i < index && i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }

                newArray[index] = value;
            }

            array = newArray;
        }
        
    }
}