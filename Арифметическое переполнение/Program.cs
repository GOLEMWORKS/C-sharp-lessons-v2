namespace Арифметическое_переполнение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte agression = 1;

            byte democracyModifier = 2;//Максимальное значение типа данных byte = 255

            //agression = (byte)(agression - democracyModifier); //При выполнении каких-либо арифметических операций все данные приводятся к типу int
            //Console.WriteLine(agression);//В результате получаем 255

            //В свойствах проекта можно включить проверку на арифметическое переполнение, но это замедлит работу программы

            //checked - ключевое слово, которое позволяет проверить одну операцию в проекте на арифметическое переполнение
            //Для проверки нескольких операций нужно использовать фигурные скобки после checked { операции }
            //Если в проекте на глобальном уровне включена настройка на отработку переполнений, но нам не нужно проверять некоторые операции,
            //то используется ключевое слово unchecked (Синтаксис аналогичен checked)

            //Использование блока try catch с OverflowException
            try
            {
                agression = checked((byte)(agression - democracyModifier));
                Console.WriteLine(agression);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка переполнения!");
            }

            //Переполнения у float и double. У них не вызываются исключения, есть методы для их отратботки

            double a = 1.2 / 0.0;
            Console.WriteLine(double.IsInfinity(a)); //Вернёт true

            double b = 0.0 / 0.0;
            Console.WriteLine(double.IsNaN(b)); // Вернёт true // NaN - Not a Number

            //У float аналогичнго!

            //У типа данных decimal всегда вызывается исключение при переполнении т.к. он используется в основном для хранения денежных единиц 
        }
    }
}