namespace ДЗ8_Массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
        while(true) 
            {
                Console.Clear();
                Console.WriteLine("Список заданий:" +
                "\n1. Ввод в массив чисел с клавиатуры" +
                "\n2. Вывод массива в обратном порядке" +
                "\n3. Сумма чётных чисел в массиве" +
                "\n4. Наименьшее число в массиве");
                Console.WriteLine("Введите номер интересующего задания:");
                switch (Console.ReadLine())
                {
                    case "1": //Ввод чисел в массив с клавиатуры:
                        try
                        {
                            int length;
                            double n;

                            Console.WriteLine("Введите длину массива(целое число!!!): ");
                            length = int.Parse(Console.ReadLine());

                            double[]firstArray = new double[length];// метод объявления массива в цикле for

                            for (int i = 0; i < length; i++)
                            {
                                Console.WriteLine("Введите элемент под номером " + i);
                                firstArray[i] = double.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("--------------Ваш массив:----------------");
                            for(int i = 0; i < firstArray.Length; i++)
                            {
                                Console.WriteLine(i + ": " + firstArray[i]);
                            }
                            Console.ReadLine();

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Вы ввели не числовое значение! \nНажмите enter для перезапуска программы.");
                            Console.ReadLine();
                            continue;
                        }
                        break;


                }

            }



        }
    }
}