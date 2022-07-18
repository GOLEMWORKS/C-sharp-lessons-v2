namespace Цикл_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Улучшенная версия цикла while, но всё зависит от случая!


            //1000-7 через цикл for
            for (int i = 1000; i > 0; i -= 7) // i - счётчик(итератор), i < lenght - ограничение, условие
            {
                Console.WriteLine(i);
            }
        }
    }
}