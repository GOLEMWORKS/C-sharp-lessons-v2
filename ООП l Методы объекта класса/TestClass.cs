using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_l_Методы_объекта_класса
{
    internal class TestClass
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string email;

        public void Print()
        {
            //Нарушение принципа solid
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Почта: {email}");
        }

        public string GetName()
        {
            return $"{firstName} {lastName}";
        }
    }
}
