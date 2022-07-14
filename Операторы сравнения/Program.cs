using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операторы_сравнения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    > Больше
                    < Меньше
                    == Равно
                    != НЕ равно
                    >= Меньше или равно
                    <= Больше иили равно
             
             */

            int a, b;
            bool res, parse;
            string str;

            Console.WriteLine("Введите первое число (a): ");
            str = Console.ReadLine();

            parse = int.TryParse(str, out a);
            if (parse)
            {
                Console.WriteLine("Введите второе число (b): ");
                str = Console.ReadLine();

                parse = int.TryParse(str, out b);

                if(parse)
                {
                    res = a == b;
                    Console.WriteLine("a==b " + res);

                    res = a != b;
                    Console.WriteLine("a!=b " + res);

                    res = a <= b;
                    Console.WriteLine("a<=b " + res);

                    res = a >= b;
                    Console.WriteLine("a>=b " + res);
                }

                else
                {
                    Console.WriteLine(str + " - не является числом типа int");
                }

            }

            else
            {
                Console.WriteLine(str + " - не является числом типа int");
            }
        }
    }
}