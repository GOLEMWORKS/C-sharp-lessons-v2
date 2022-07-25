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

                                    Console.WriteLine("Введите длину массива(целое число!!!): ");
                                    length = int.Parse(Console.ReadLine());

                                    double[]firstArray = new double[length];// метод объявления массива, double в данном случае подходит!

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
                        
                    case "2":
                                try
                                {
                                    int length;
                                    
                                    Console.WriteLine("Введите длину массива(целое число!!!): ");
                                    length = int.Parse(Console.ReadLine());

                                    double[] secondArray = new double[length];// Можно оставлять и firstArray, но для удобства ориентирования использую иное название

                                    for (int i = 0; i < length; i++)
                                    {
                                        Console.WriteLine("Введите элемент под номером " + i);
                                        secondArray[i] = double.Parse(Console.ReadLine());
                                    }
                                    Console.WriteLine("----------Ваш массив в обратном порядке:------------");
                                    for (int i = (secondArray.Length - 1); i >= 0; i--) // обязательно отними единицу т.к. длина будет больше чем номер элемента!!
                                    {
                                        Console.WriteLine(i + ": " + secondArray[i]);
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

                    case "3":
                                try
                                {
                                        int length, decimalSum;

                                        decimalSum = 0;

                                        Console.WriteLine("Введите длину массива(целое число!!!): ");
                                        length = int.Parse(Console.ReadLine());

                                        int[] thirdArray = new int[length];// int т.к. только целые числа чётны или нечётны

                                        for (int i = 0; i < length; i++)
                                        {
                                            Console.WriteLine("Введите элемент под номером " + i);
                                            thirdArray[i] = int.Parse(Console.ReadLine());
                                        }
                                        Console.WriteLine("--------Cумма чётных чисел в массиве:--------");
                                        for (int i = 0; i < thirdArray.Length; i++)
                                        {
                                                if (thirdArray[i] % 2 == 0)
                                                {
                                                     decimalSum += thirdArray[i];
                                                }

                                                else
                                                {
                                                    continue;
                                                }
                                        }
                                        Console.WriteLine(decimalSum);

                                        Console.ReadLine();

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Вы ввели не числовое значение! \nНажмите enter для перезапуска программы.");
                                    Console.ReadLine();
                                    continue;
                                }
                        break;

                    case "4":
                                try
                                {
                                    int length;

                                    Console.WriteLine("Введите длину массива(целое число!!!): ");
                                    length = int.Parse(Console.ReadLine());

                                    double[] fourthArray = new double[length];// метод объявления массива, double в данном случае подходит!

                                    for (int i = 0; i < length; i++)
                                    {
                                        Console.WriteLine("Введите элемент под номером " + i);
                                        fourthArray[i] = double.Parse(Console.ReadLine());
                                    }
                                    Console.WriteLine("--------Наименьшее число массива:------------");

                                    Array.Sort(fourthArray);//Сортировка методом Sort

                                    Console.WriteLine(fourthArray[0]);   

                                    Console.ReadLine();

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Вы ввели не числовое значение! \nНажмите enter для перезапуска программы.");
                                    Console.ReadLine();
                                    continue;
                                }
                        break;


                        default:
                            Console.WriteLine("Задания под таким номером не существует, попробуйте снова!");
                            Console.ReadLine();
                        break;  
                }

            }
        }
    }
}