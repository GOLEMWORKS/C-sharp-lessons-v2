namespace Цикл_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int max = int.Parse(Console.ReadLine());

            while (max > count)//Выполняется до тех пор пока выполняется условие в скобках
            {
                Console.WriteLine(count);
                count = count + 2;
            }
        }
    }
}