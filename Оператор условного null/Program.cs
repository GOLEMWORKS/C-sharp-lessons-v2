namespace Оператор_условного_null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //?. - условный null

            int[] mainArray = GetArray();
            Console.WriteLine("Сумма элементов массива: " + (mainArray?.Sum()??0)); //mainArray?. - синтаксис условного null, после него для указания метода не требуется дополнительной точки
            //Код после вопросительного знака выполняться не будет, если у запрашиваемой информации в значении null
            //Т.к. после проверки и нахождания null в mainArray?.Sum() будет подставлен null, то используется оператор сравнения с null и указывается
            //Значение по умолчанию, при этом выражение берётся в скобки (Для корректной конкатенации)
        }

        static int[] GetArray()
        {
            int[] myArray = null; //{ 1, 2, 3, 5}
            return myArray;
        }
    }
}