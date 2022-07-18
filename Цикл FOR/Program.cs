namespace Цикл_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Улучшенная версия цикла while, но всё зависит от случая!

            Console.Clear();
            //1000-7 через цикл for
            for (int i = 1000; i > 0; i -= 7) // i - счётчик(итератор), i < lenght - ограничение, условие
            {
                Console.WriteLine(i);
            }

            int length;

            //for в try catch
            try
            {
                Console.WriteLine("Введите максимальное количество итераций цикла: ");
                length = int.Parse(Console.ReadLine());

                for (int i = 0; i <= length; i++) // переменные i & length(Любое название) доступна только внутри цикла for в котором объявлена
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введён неверный тип данных!");
            }
        }
    }
}