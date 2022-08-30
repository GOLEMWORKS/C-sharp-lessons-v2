using System.Drawing;

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
            p1.color = DotColor.Blue;
            Console.WriteLine($"X: {p1.x} & Y: {p1.y} | Color: {p1.color}");

            var p2 = new Point();
            p2.x = 2;
            p2.y = 6;
            Console.WriteLine($"X: {p2.x} & Y: {p2.y} | Color: {p2.color}"); //Если не указывать цвет, то выдастся первый (нулевой в данном случае) элемент энама

            //Если указать что p = null, то класс, как и любой ссылочный тип данных, потеряет связь с реальными данными и при присваивании
            //значений объектам этого класса будет выдан NullReferenceException

            //-----------------------STUDENT----------------

            var firstStudent = GetStudent();
            PrintInfo(firstStudent);
        }

        //-------------STUDENT Методы------------
        static Student GetStudent()
        {
            var student = new Student();

            student.firstName = "Владимир";
            student.middleName = "Александрович";
            student.lastName = "Коротких";
            student.age = 18;
            student.id = Guid.NewGuid(); //Получение особого id
            student.group = "ИСР21-1";

            return student;
        }

        static void PrintInfo(Student student)
        {
            Console.WriteLine("\t\tИнформация о студенте:");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.middleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа: {student.group}");
            Console.WriteLine($"ID: {student.id}");
        }
    }

    class Point//ССЫЛОЧНЫЙ ТИП ДАННЫХ. Шаблон или схема
    {
        //public НЕ ИСПОЛЬЗУЕМ В РЕАЛЬНОСТИ!!! ТОЛЬКО В ОБУЧЕНИИ!!!
        public int x; //Внутри класса переменные называются полями класса
        public int y;
        public DotColor color; //Поле цвета точки, которое указывается через энам
    }

    enum DotColor
    {
        Red,
        Green,
        Blue,
        Orange,
        Yellow
    }

    //----------------------------------------------- STUDENT в отдельном файле
}