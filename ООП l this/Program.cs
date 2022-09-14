namespace ООП_l_this
{
    class Student
    {
        public Student(string lastName, DateTime birthday):this(lastName) //Использоваие this в конструкторах
        {
            //this - обращается к полям объекта класса внутри него, а не снаружи
            this.birthday = birthday;

            //Обработка параметра lastName делегируется другому конструктору
        }

        public Student(string lastName)
        {
            this.lastName = lastName;
        }

        private string lastName;
        private DateTime birthday;

        public void Print()
        {
            Console.WriteLine($"Фамилия {lastName}, Дата рождения {birthday}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //this - нельзя использовать в методах с модификатором static. Static методы не требуют создания объекта (экземпляра) класса (Пример: Console.Writeline)

            var studentik = new Student("Иванов", new DateTime(2000, 12, 30));
            studentik.Print();

            var studento4ka = new Student("Петрова", new DateTime(2001, 2, 20));
            studento4ka.Print();
        }
    }
}