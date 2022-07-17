namespace ДЗ6_Подсчёт_чётный_и_нечётных_чисел_с_вводом_данных_от_пользователя
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int min, max, oddNumbersSum, evenNumbersSum;
                uint oddNumbersCounter, evenNumbersCounter; // счётчики, отрицательного значения быть не может!


                Console.Clear();
                try
                {
                    Console.WriteLine("Введите начало промежутка:");
                    min = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите конец промежутка:");
                    max = int.Parse(Console.ReadLine());

                    if (min > max) 
                    {
                        Console.WriteLine("Промежуток не может начинаться с большего числа и оканчиваться меньшим!");
                        Console.ReadLine();
                        continue;// пропуск последующего кода и начало программы заново
                    }
                        
                }
                catch (Exception) //проверка вводимых чисел
                {
                    Console.WriteLine("Введите целые числа в значение промежутка");
                    Console.ReadLine();
                    continue;// пропуск последующего кода и начало программы заново
                }

                oddNumbersCounter = 0; //нечётные
                evenNumbersCounter = 0; //чётные

                oddNumbersSum = 0; //Сумма нечётных
                evenNumbersSum = 0; //Сумма чётных
                
                while (min < max)
                {
                    min++;// увеличивает значение каждую итерацию цикла

                    switch(min % 2)
                    {
                        case 0:
                            evenNumbersSum += min;  //Замена evenNumbersSum = evenNumbersSum + min
                            evenNumbersCounter++; // Счётчик чётных
                            break;
                        case 1:
                            oddNumbersSum += min;
                            oddNumbersCounter++; // Счётчик нечётных
                            break;

                    }
                }

                //счётчики
                Console.WriteLine("Чётных чисел: " + evenNumbersCounter + "; Их сумма: " + evenNumbersSum);
                Console.WriteLine("Нечётных чисел: " + oddNumbersCounter + "; Их сумма: " + oddNumbersSum);
                Console.ReadLine();
            }


        }
    }
}