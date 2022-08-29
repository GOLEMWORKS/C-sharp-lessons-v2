namespace ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //реальное использование
            while (true)
            {
                var key = Console.ReadKey().Key;

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Нажат Enter");
                }
            }
        }
    }
}