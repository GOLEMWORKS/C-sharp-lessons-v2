using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Конвертация_строки__parse_и_tryparse_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Простейший пример перевода строки в число методом Parse
            string str = "12";
            int a = int.Parse(str);
            Console.WriteLine("Первое число: " + a);

            //Перевод строки в дробное число с указанием локального разделителя
            string str1 = "1.2";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double b = double.Parse(str1, numberFormatInfo); //обязательно указать объект numberformatInfo в параметры Parse!!!
            Console.WriteLine("Второе число: " + b);



            //Испоьзование TryParse
            string str2 = "2б2";

            int c;

            //После конвертации TryParse возвращает булевый результат, либо переменную. При ошибке конвертации выдаёт ноль!
            bool result = int.TryParse(str2, out c); //Что парсим первое, куда подставляем - второе!

            //Логика получения через TryParse
            if(result) 
            {
                Console.WriteLine("Конвертация прошла успешно, полученное число = " + c);
            }
            else
            {
                Console.WriteLine("Не удалось сконвертировать.");
            }
        }
    }
}
