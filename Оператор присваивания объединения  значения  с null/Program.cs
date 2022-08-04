namespace Оператор_присваивания_объединения__значения__с_null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //??= - заместо null присваивает иное значение для переменной

            string str = null;

            str ??= string.Empty; //str присваиваеся значение за место null; можно делать всё через одну переменную

            Console.WriteLine("Длина строки: " + str.Length);

            //Пример с массивами 
            int[] myArr = GetArray(); // данному массиву присваивается значение 0

            myArr ??= new int[0]; //Проверка на null и присвоение массива на ноль элементов

            Console.WriteLine("Кол-во элементов в массиве: " + myArr.Length);
        }

        static int[] GetArray()
        {
            int[] myArrray = null;

            return myArrray;
        }
    }
}