namespace Взаимодействие_массивов_и_циклов._Вывод_массивов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1,2,412,123,21,312,321,12};

            Console.WriteLine("№ | Число");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(i + ": " + myArray[i]);
            }
        }
    }
}