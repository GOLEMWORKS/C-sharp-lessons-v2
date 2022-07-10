using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конвертация_типов_данных__Перевод_строки_в_число._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //конвертация строки в другие типы данных

            string str;
            int a, b;


            try
            {
                Console.WriteLine("Введите первое число:");
                str = Console.ReadLine();

                a = Convert.ToInt32(str);


                Console.WriteLine("Введите второе число:");
                str = Console.ReadLine();

                b = Convert.ToInt32(str);

                int sum = a + b;
                int dif = a - b;
                int mul = a * b;
                int div = b / a;

                Console.WriteLine("Действия с числами " + a + " и " + b + ":" +
                    "\n Сумма: " + sum +
                    "\n Разность: " + dif +
                    "\n Произведение: " + mul +
                    "\n Частное: " + div);
            }
            
            catch (System.FormatException)
            {
                Console.WriteLine("Неверные символы. Введите целое число!");
            }
        }
    }
}
