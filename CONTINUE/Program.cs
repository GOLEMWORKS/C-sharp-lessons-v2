namespace CONTINUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // continue позволяет пропутить итерацию цикла, при этом не выходя из него!

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue; // Пропуск итерации двойки
                }

                Console.WriteLine(i);
            }
        }
    }
}