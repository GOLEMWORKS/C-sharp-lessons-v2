namespace Преобразование__привидение__типов_данных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12; //работает. Пример нявного (implicit) преобразования(Компиляор сам преобразовал типы данных)
            //double a = 5,2 - не работает
            TestFloat(a);
        }

        static void TestFloat(float insertValue)
        {
            Console.WriteLine();
        }
    }
}