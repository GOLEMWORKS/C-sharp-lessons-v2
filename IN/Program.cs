namespace IN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ключевое слово in - модификатор для параметров при передаче в метод
            //Доступно с версии 7.2
            int a = 5;
            inTest(a);// не нужно дополнительно указывать in внутри

        }

        static void inTest(in int value)
        {
            //value = 5; - мы не можем записать данные. Только прочитать
            Console.WriteLine(value);
        }

        //ewq
    }
}