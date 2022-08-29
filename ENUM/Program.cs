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

            //Проверка на переполнение и приведение типов в энамах
            int val = 5; //любое число больше 7 и выдаёт ошибку

            dayOfWeek = (DaysOfWeek)val;

            if (Enum.IsDefined(typeof (DaysOfWeek), val))
            {
                dayOfWeek = (DaysOfWeek)val;
            }
            else
            {
                throw new Exception("Invalid Enum Value"); // Вывод ошибки при отсутствии в энаме элемента с этим номером
            }

            //Все доступные значения энама

            var getValues = Enum.GetValues(typeof(DaysOfWeek));
            foreach (var item in getValues)
            {
                Console.WriteLine(item);
            }

            //Парсинг энамов
            string inputStr = Console.ReadLine();
            var whichDayInWeek = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), inputStr, ignoreCase: true); // Добавление нового дня недели через энам парс
            Console.WriteLine($"День {whichDayInWeek}, его номер {(int)whichDayInWeek}"); //Выводит номер и название указанного дня, если он существует в энаме
            //Существует и Enum.TryParse

            //Использование Switch для работы с enum
            switch (whichDayInWeek) // Автоматически подставляет всё содержимое энама
            {
                case DaysOfWeek.Monday:
                    break;
                case DaysOfWeek.Tuesday:
                    break;
                case DaysOfWeek.Wednesday:
                    break;
                case DaysOfWeek.Thursday:
                    break;
                case DaysOfWeek.Friday:
                    break;
                case DaysOfWeek.Saturday:
                    break;
                case DaysOfWeek.Sunday:
                    break;
                default:
                    break;
            }
        }

        //Создание enum'а
        enum DaysOfWeek //Если не указывать нумерацию в энаме, то отсчёт пойдёт с нуля. Через двоеточие указывается тип данных энама ( : byte etc.)
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