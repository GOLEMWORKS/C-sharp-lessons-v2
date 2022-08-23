namespace Арифметическое_переполнение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte agression = 1;

            byte democracyModifier = 2;//Максимальное значение типа данных byte = 255

            agression = (byte)(agression - democracyModifier); //При выполнении каких-либо арифметических операций все данные приводятся к типу int
            Console.WriteLine(agression);//В результате получаем 255
        }
    }
}