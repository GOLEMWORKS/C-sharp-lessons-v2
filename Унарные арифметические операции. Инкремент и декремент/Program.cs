using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Унарные_арифметические_операции.Инкремент_и_декремент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Инкремент:
            
            int a = 0;

            a++;//Постфиксная форма --a; - префиксная

            Console.WriteLine(a);

            //Декремент

            int b  = 0;

            b--;

            Console.WriteLine(b);

            //постфиксная форма имеет меньший приоритет операции, а префиксная больший!

            int c = 0;
            Console.WriteLine("Постфиксная форма:" + c++); //Выводит в консоль C а потом прибавляет 1
            Console.WriteLine("Префиксная форма:" + ++c);//Прибавляет 1 к c = 1
            Console.ReadLine();
        }
    }
}
