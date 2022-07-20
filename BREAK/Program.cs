namespace BREAK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //break прерывает любой цикл

            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();
                if (msg == "exit")
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}