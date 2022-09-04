namespace ООП_l_Методы_объекта_класса
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var TestInfo = GetClassInfo();
            TestInfo.Print(); //Метод Print вызывается именно у конкретного экземпляра класса

            Console.WriteLine(TestInfo.GetName()); //Метод с возвращаемым значением
        }
        static TestClass GetClassInfo()
        {
            var TestClass = new TestClass();

            TestClass.id = Guid.NewGuid();
            TestClass.firstName = "Владимир";
            TestClass.lastName = "Коротких";
            TestClass.email = "Bebra@mail.ru";

            return TestClass;
        }
    }
}