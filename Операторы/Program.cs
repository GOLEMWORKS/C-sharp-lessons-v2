using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Операторы, которые взаимодействуют с числами относятся к бинарным
            //% - деление по модулю 

            int a = 12;
            int b = 5;

            double d = (double) a / b; /*Если числа являются целыми, то после их деления результат будет округляться! Поэтому числам присваивается тип, поддерживающий запись через запятую,
                                        *Либо выполнить операцию приведения! 
                                        */
            int c = a % b;  
            Console.WriteLine("Результат деления - десятичная дробь: " + d +
                              " \nОстаток от деления " + a + " и " + b + " : " + c);
        }
    }
}
