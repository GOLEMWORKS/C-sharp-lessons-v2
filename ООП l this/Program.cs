namespace ООП_l_this
{
    class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            //this - обращается к полям объекта класса внутри него, а не снаружи
            this.lastName = lastName;
            this.birthday = birthday;
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
            var studentik = new Student("Иванов", new DateTime(2000, 12, 30));
            studentik.Print();

            var studento4ka = new Student("Петрова", new DateTime(2001, 2, 20));
            studento4ka.Print();
        }
    }
}