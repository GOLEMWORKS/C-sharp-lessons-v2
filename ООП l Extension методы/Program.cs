namespace ООП_l_Extension_методы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Добавление нового функционала, не меняя
            //структуры класса. Используются для работы с
            //недоступными для редактирования класса

            //Наследование от классов и рациональность этого

            DateTime currentDateTime = DateTime.Now;
            currentDateTime.PrintInfo();
        }
    }
}