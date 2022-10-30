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

            //Либо

            DateTime.Now.PrintInfo();

            //Проверка на день недели
            Console.WriteLine(currentDateTime.IsThisDayOfWeek(DayOfWeek.Friday));
            //Структура currentDateTime через extension метод IsThisDayOfWeek проверяет соответствие текущего дня недели, указанному в его скобках, а именно
            //DayOfWeek.Friday - пятница. DayOfWeek - это enum

            //При вызове extension метода отображается только второй параметр. Первый параметр не отображается т.к. служит для определения объекта
            //взаимодействия метода

            if (currentDateTime.IsThisDayOfWeek(DayOfWeek.Saturday))
            {
                Console.WriteLine("Ура, воскресенье!!!");
            }
            else
            {
                Console.WriteLine("Сегодня не Воскресенье :(");
            }
        }
    }
}