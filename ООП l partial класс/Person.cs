using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_l_partial_класс
{
    partial class Person //Название класса не зависит от названия файла
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Person(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
