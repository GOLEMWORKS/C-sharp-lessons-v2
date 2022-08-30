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

            Console.WriteLine($"{p1.x} & {p1.y}");
        }
    }

    class Point//ССЫЛОЧНЫЙ ТИП ДАННЫХ
    {
        public int x; //Внутри класса переменные называются полями класса
        public int y;
    }
}