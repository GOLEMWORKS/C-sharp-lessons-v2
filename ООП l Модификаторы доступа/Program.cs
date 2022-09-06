namespace ООП_l_Модификаторы_доступа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Модификаторы public и private (Используются при инкапсуляции)
            //public - доступно снаружи класса
            //private - доступно только внутри класса
            var point = new Point();

            point.PrintY(); //Публичный метод, в котором находится приватная переменная
            Console.WriteLine();
            point.PrintPoint(); //Опосредовано вызываем приватный метод PrintX
        }
    }

    class Point
    {
        public int x = 4;
        private int y = 44;
        int z = 12; //По умолчанию используется модификатор private

        private void PrintX() //Вредный пример, нарушающий инкапсуляцию
        {
            Console.WriteLine($"X {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y {y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }
}