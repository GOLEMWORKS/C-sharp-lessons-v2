namespace ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //реальное использование
            //while (true)
            //{
            //    var key = Console.ReadKey().Key; //Key - это enum

            //    int keyCode = (int)key; //Преобразуем полученный код в тип данных int

            //    Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

            //    if (key == ConsoleKey.Enter)
            //    {
            //        Console.WriteLine("Нажат Enter");
            //    }
            //}

            var dayOfWeek = DaysOfWeek.Monday;

            int dayCode = (int)DaysOfWeek.Monday;//Приводим enum к типу int 

            Console.WriteLine($"День {dayOfWeek}, {dayCode} на неделе");

            //Узнаём тип enum'a. Дефолтный тип данных - int. Можно менять на любой другой тип, который может принимать целые числа
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DaysOfWeek)));

            //Приводим DaysOFWeek к типу Int 
            Console.WriteLine((DaysOfWeek)3 );

            //Следующий день
            var nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);
        }

        //Создание enum'а
        enum DaysOfWeek : byte //Если не указывать нумерацию в энаме, то отсчёт пойдёт с нуля. Через двоеточие указывается тип данных энама
        {
            Monday = 1, //Отсчёт дней начался с первого
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        //Метод для получения следующего дня
        static DaysOfWeek GetNextDay(DaysOfWeek day)
        {
            if (day < DaysOfWeek.Sunday)
                return day + 1;

            return DaysOfWeek.Monday;
        }
    }
}