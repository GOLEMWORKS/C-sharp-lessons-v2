namespace Необязательные_параметры_метода
{
    internal class Program
    {
        static int Sum(int a, int b, bool isEnableLogging = false)//Если значение уже указанно, то при вызове метода этот параметр становится не обязательным!
        {
            int result = a + b;
            //Параметры по умолчанию ВСЕГДА В КОНЦЕ СПИСКА!
            if (isEnableLogging)
            {
                Console.WriteLine("Логирование включено!");
                Console.WriteLine("Первое слагаемое: " + a);
                Console.WriteLine("Второе слагаемое: " + b);
                Console.WriteLine("Результат: " + result);
            }
            return result;
        }


        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int firstSum);
            int.TryParse(Console.ReadLine(), out int secondSum);
            bool.TryParse(Console.ReadLine(), out bool enableLogging);

            Sum(firstSum, secondSum, enableLogging); 
        }
    }
}