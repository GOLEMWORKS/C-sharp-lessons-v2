namespace Цикл_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1000;
            while (count > 0)//Выполняется до тех пор пока выполняется условие в скобках
            {
                count = count - 7;
                Console.WriteLine(count);
            }
        }
    }
}