namespace Именованные_параметры
{
    internal class Program
    {

        static void TestMethod(int a, int b)
        {
            Console.WriteLine("Переменная a = " + a);
            Console.WriteLine("Переменная b = " + b);
        }
        static void Main(string[] args)
        {
            TestMethod(1, 2); //a = 1, b = 2
            Console.WriteLine();
            TestMethod(b: 2, a: 3);//Именновванный параметр. a = 3, b = 2
            Console.WriteLine();

            int firstNum = 4;
            int secondNum = 2;

            TestMethod(b: firstNum, a: secondNum);//Можно передавать переменные
        }
    }
}