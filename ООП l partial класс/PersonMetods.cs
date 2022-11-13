using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_l_partial_класс
{
    partial class Person //Название аналогично первому классу, одно пространство имён, ключевое слово partial => это часть класса Person, в которую вынесены методы
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
