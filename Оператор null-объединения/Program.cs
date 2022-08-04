namespace Оператор_null_объединения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //?? "сахар"

            string str = null;

            Console.WriteLine(str?? "Данных нет"); //переменная null объединение и значение которое будет при null (тот же тип, что и у )

            //Console.WriteLine("Количество символов в строке: " + str.Length); - выдаст null reference exceprion, дабы этого избежать:

            string res = str ?? string.Empty; // либо через пустые кавычки ""
            Console.WriteLine("Длина строки: " + res.Length); //Можно через уловный null, но он изучен будет позже
        }
    }
}