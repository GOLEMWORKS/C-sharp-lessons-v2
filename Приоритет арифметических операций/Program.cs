using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приоритет_арифметических_операций
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приоритет арифметических операций в С#\nДоступные команды: !ариф; !bebra\nВведите команду:");

            // Однострочный комментарий

            /*
                Многострочный комментарий
                Да
                Воот
            */

            string key = Console.ReadLine();
            if (key == "!ариф")
            {


                //примеры, для получения их результата введи в консоль !ариф
                Console.WriteLine("\nАрифметические действия в C#:");
                int a = 10 + 2 - 3;
                int b = 10 * 3 / 2;
                int c = 10 + 3 / 2;
                int d = 10 / 2 + 3;

                Console.WriteLine("1 порядок: Умножение/Деление " +
                    "\n2 порядок: Сложение/Вычитание " +
                    "\nДействия одного порядка выполняются последовательно слева на право " +
                    "\nДля разграничения можно использовать скобки\n");


                int[] bebra = { a, b, c, d };

                int count = 0;
                foreach (int i in bebra)
                {
                    count++;
                    Console.WriteLine("Пример номер " + count + ": Результат " + i);
                }
            }
            else if (key == "!bebra")

            {
                Console.WriteLine("Чё звал сларк?");
            }
            else
            {
                Console.WriteLine(key + " - Не является валидной командой!");
            }
        }
    }
}
