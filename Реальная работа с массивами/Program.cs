using System.Linq;

namespace Реальная_работа_с_массивами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Все массивы - наследники класса Array в C#, поэтому мы можем использовать статические методы этого класса

            int[] myArray = { 12, 123, 3213, 123123, 123, 123, 123, 12312, 13, 211, 412, 41, 12, 45, 131, 233, 1412, 4 };

            int result = myArray.Max();
        }
    }
}