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

            //После прелбразования значимого типа в nullable появляются 2 дополнительных поля HasValue и Value
            Console.WriteLine(dateTime.HasValue); //Вернёт false
            //Console.WriteLine(dateTime.Value); // Реальные данные, которые есть в переменной, если их нет, то InvalidOperationException

            //типичные операции при работе с nullable
            int? i = null;

            //Проверка значения на null
            Console.WriteLine(i == null); //True
            Console.WriteLine(i.HasValue); //False

            //Дополнительный метод GetValueOrDefault для nullable типов данных
            Console.WriteLine(i.GetValueOrDefault()); //0 (Возврат значения по умолчанию для указанного типа данных)
            Console.WriteLine(i.GetValueOrDefault(12)); //12

            //Оператор объединения с null (Если в переменной null то вернёт то, что с права)
            Console.WriteLine(i ?? 12); // 12, если в переменной есть значение, отличное от null, то вернётся именно 

            //Узнаём значение поля
            //Console.WriteLine(i.Value); //InvalidOperationException(В случае с null), либо значение переменной (Если значение не null)
            Console.WriteLine(i); // Не выведется ничего, но при каких-либо действиях с переменной требуется всегда проверка на null, для избежания ошибок

            //Если сложить nullable тип со значимым, при этом nullable будет иметь значение null, то результат будет тоже null, НЕ ЗАВИСИМО ОТ ЗНАЧИМОЙ ПЕРЕМЕННОЙ
            int b = 12;
            Console.WriteLine(i + b); //null (Пустая строка в консоли)
            //При сравнении null с любым действительным значением, то мы получим false
            Console.WriteLine(i == b); //false
            Console.WriteLine(i < b); //false
            Console.WriteLine(i > b); //false

            //При использовании nullable переменных в программе следует всегда проверять их на null, во избежание ошибок!!!
        }
    }
}