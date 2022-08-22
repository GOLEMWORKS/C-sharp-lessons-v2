namespace Арифметическое_переполнение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte agression = 1;

            byte democracyModifier = 2;//Максимальное значение типа данных byte = 255

            agression = (byte)(agression - democracyModifier); //В результате 
            Console.WriteLine(agression);
        }
    }
}