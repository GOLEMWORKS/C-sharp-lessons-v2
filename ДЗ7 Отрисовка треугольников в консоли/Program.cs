namespace ДЗ7_Отрисовка_треугольников_в_консоли
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите высоту фигуры:");
                int height = int.Parse(Console.ReadLine());


                //Console.WriteLine("Введите ширину фигуры:");
                //int width = int.Parse(Console.ReadLine());
                Console.WriteLine("1");
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j <= i; j++) // Количество знаков в строке = номеру строки
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("2");

                for (int i = 0; i < height; i++)
                {
                    for (int j = height; j > i; j--) // Количество знаков обратно пропорционально номеру строки
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("3");

                for (int i = 0; i < height; i++)
                {
                    for (int j = height; j > i; j--) //2
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++) // 1
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("4");

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j <= i; j++) // Количество знаков в строке = номеру строки
                    {
                        Console.Write(" ");//1
                    }
                    for (int j = height; j > i; j--) //2
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введён неверный тип данных!");
            }
        }
    }
}