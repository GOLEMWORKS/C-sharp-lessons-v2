using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Объявление_и_инициализация_переменных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // = - это оператор присваивания
            int a = 5;
            int b = 2;

            //Для быстрого написания комманды можно использовать cw + двойной таб
            Console.WriteLine("Вывод двух значений по порядку:" + a + b);
            Console.WriteLine("Сумма двух значений:" + (a + b));

            //Логические переменные
            Console.WriteLine("\nВывод логические переменных:");
            bool variable = false;
            bool variable2 = true;
            Console.WriteLine(variable + " " + variable2); //Если не использовать "", то будет попытка суммировать и выведет ошибку!

            //Дробные числа
            Console.WriteLine("\nДробные числа:");
            double d = 1.22;
            Console.WriteLine(d);

            //char & string
            Console.WriteLine("Char & string");
            string s = "stroka";
            char c = 'a';
            Console.WriteLine(s + c);//"Суммирует" строки
        }
    }
}
