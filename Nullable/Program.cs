namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nullable типы данных

            string str = null; // null с ссылочными типами данных

            //int i = null; - не работает. Значимые типы не могут иметь значение null

            DateTime? dateTime = null; //Указав знак вопроса после значимого типа мы делаем его nullable и можем ему присвоить значение null
        }
    }
}