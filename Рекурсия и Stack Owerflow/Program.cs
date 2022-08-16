namespace Рекурсия_и_Stack_Owerflow
{
    internal class Program
    {
        static void RecursionTestStart()
        {
            Console.WriteLine("Recursion test is running!");
            RecursionTestStart(); //Рекурсия - вызов метода внутри самого себя
            //Рекурсия ограничена размером стека, поэтому всегда нужно
            //указывать условия выхода из рекурсии, дабы не нарваться на Stack Owerflow
            //Лучше рекурсию не использовать, если в методе много переменных и данных, т.к. это влияет на производительность
        }
        static void Main(string[] args)
        {
            //RecursionTestStart();
            RecursionBreak(1);
        }

        static void RecursionBreak(int i)
        {
            Console.WriteLine("Рекурсия идёт уже " + i + " шагов.");
            if (i >= 4)
            {
                return;//Выход из рекурсии при выполнении определённого условия
            }

            i++;
            RecursionBreak(i);
        }
    }
}