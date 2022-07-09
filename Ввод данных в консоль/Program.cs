using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ввод_данных_в_консоль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string data = Console.ReadLine();

            Console.WriteLine("Привет " + data);
        }
    }
}
