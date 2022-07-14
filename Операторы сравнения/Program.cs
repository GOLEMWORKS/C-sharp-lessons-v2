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

            a = 5;
            b = 5;

            bool res = a == b;

            Console.WriteLine(res);
        }
    }
}