namespace ДЗ6_Подсчёт_чётный_и_нечётных_чисел_с_вводом_данных_от_пользователя
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int min, max, numberCheck;
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
                        continue;
                    }
                        
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целые числа в значение промежутка");
                    Console.ReadLine();
                    continue;
                }

                oddNumbersCounter = 0; //нечётные
                evenNumbersCounter = 0; //чётные
                
                while (max > min)
                {
                    min++;
                    numberCheck = min % 2;

                    switch(numberCheck)
                    {
                        case 0:
                            evenNumbersCounter++;
                            break;
                        case 1:
                            oddNumbersCounter++;
                            break;

                    }
                }

                Console.WriteLine("Чётных чисел: " + evenNumbersCounter);
                Console.WriteLine("Нечётных чисел: " + oddNumbersCounter);
                Console.ReadLine();
            }


        }
    }
}