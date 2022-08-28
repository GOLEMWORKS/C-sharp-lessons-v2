using System.Globalization;

namespace VAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var не является типом данных и служит для того, чтобы компилятор мог сам присвоить переменной определённый тип
           
            var i = 5; //Целое число типа int
            var s = "qweqe"; // Строка
            var f = new float[12]; //Массив типа float

            //var не снимает строгую типизацию с переменной и ей всё равно присваивается тип в зависимости от присвоенных данных и присвоить иной НЕЛЬЗЯ!

            Console.WriteLine(i.GetType() + " " +
                              s.GetType() + " " +
                              f.GetType() + " " );

            //var нельзя присвоить значение null, но если переменная является ссылочным типом или nullable, то такое возможно
            var n = "qqq"; //var n = null - ошибка!
            n = null;

            //правильное использование var
            var d = new Dictionary<int,string>(); //Сокращает запись. Оригинал:  Dictionary<int,string> d = new Dictionary<int,string>();    
            var random = new Random(); // Ещё один пример

            //Использование для создания анонимных типов
            var a = new {Name = "Bebra", Age = 32 };

            //Использование с LINQ
            int[] someNums = { 12, 123, 2313, 31, 3, 12, 434, 23, 55, 45112, 756};

            var res = from j in someNums where j > 15 select j; //Выборка через LINQ

            foreach (var item in res)
            {
                Console.WriteLine($"{item}\t");
            }

            Console.WriteLine();

            Console.WriteLine($"Тип данных res: {res.GetType()}"); //$ - позволяет обращаться к переменной и её методам внутри строки 
        }
    }
}