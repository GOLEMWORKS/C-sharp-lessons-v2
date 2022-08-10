namespace OUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Разница out и ref 
            //ref - значение будет передано по ссылке и мы его можем изменить внутри метода
            //out - при использовании переменной с данным словом в методе мы обязаны присвоить ей значение

            int a = 10;//Для out можно заранее присваивать значение, но после этого оно поменяется на то, что было в методе с модификатором out
            HowToRef(ref a);//10
            HowToOut(out a);//0

            int b;
            HowToOut(out b);// С ref такое не получится т.к. компилятор будет ругаться на неприсвоенную переменную

            HowToOut(out int c);// Можно объявлять переменные внутри метода(с 6й версии C#). Для ref требуется объявить переменную заранее!

            //Использование out на практике
            int.TryParse(Console.ReadLine(), out int parseResult); // Если будет строка, то результат выдастся значением по умолчанию (для Int = 0)
            Console.WriteLine(parseResult);// out гарантирует возвращение переменной 
        }

        static void HowToRef(ref int val)
        {
            Console.WriteLine(val);
        }

        static void HowToOut(out int val)
        {
            val = 0;//Без значения выдаёт ошибку
            Console.WriteLine(val);
        }

        //В остальном эти слова работают ОДИНАКОГО!
    }
}