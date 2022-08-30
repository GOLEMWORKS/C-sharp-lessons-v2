namespace ООП_l_Классы
{
    internal class Program
    {
        //Класс, объект класса, экземпляр класса
        static void Main(string[] args)
        {
            Point p1 = new Point();//Создания места в куче для объекта данного класса
            //р1 - это объект класса, с которым ведётся непосредственная работа
            p1.x = 4;
            p1.y = 2;
            Console.WriteLine($"X: {p1.x} & Y: {p1.y}");

            var p2 = new Point();
            p2.x = 2;
            p2.y = 6;
            Console.WriteLine($"X: {p2.x} & Y: {p2.y}");
        }
    }

    class Point//ССЫЛОЧНЫЙ ТИП ДАННЫХ. Шаблон или схема
    {
        public int x; //Внутри класса переменные называются полями класса
        public int y;
    }
}