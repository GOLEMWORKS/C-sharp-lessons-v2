namespace ООП_l_Перегрузка_конструкторов_класса
{
    class Point
    {
        // перегрузка конструкторов класса:
        public Point(int x, int y) //После добавления данного конструктора исчез неявный конструктор по умолчанию, поэтому для пользования ним нужно будет его снова указать
        {
            _x = x;
            _y = y;
        }

        public Point() //Конструктор без параметров, так называемый "По умолчанию"
        {
            //Поставлю изначальное значение у параметров перемиенных как 1
            _x = _y = 1;
        }

        //Для копирования данных из одного объекта класса в другой
        //можно использовать конструктор с объектом этого класса
        public Point(Point point)
        {
            _x = point._x;
            _y = point._y;
        }

        private int _x;
        private int _y;

        public void PrintPoint()
        {
            Console.WriteLine($"X: {_x} \t Y: {_y}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var newPoint = new Point(4,5); //С указанными данными
            newPoint.PrintPoint();

            var secondPoint = new Point(); //Без указанных данных
            secondPoint.PrintPoint();
        }
    }
}