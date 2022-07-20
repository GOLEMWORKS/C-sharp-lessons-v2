namespace Вложенные_циклы__Конструкции_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Цикл 1, итерация " + i);
                
                for (int a = 1; a <= 5; a++) //Переменная-итератор вложенного цикла должна быть иной нежели во внешнем
                { 
                    Console.WriteLine("\tЦикл 2, итерация " + a);

                    for (int b = 1; b <= 2; b++)
                    {
                        Console.WriteLine("\t\tЦикл 3, итерация " + b);
                    }
                }
            }

            Console.WriteLine("Рисование четырёхугольника в консоли:\n");


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("Х");
                }
                Console.WriteLine();//переход на новую строку каждые 20 отрисованных линий
            }
        }
    }
}