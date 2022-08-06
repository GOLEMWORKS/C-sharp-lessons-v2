namespace REF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Передача аргументов по ссылке и REF

            int a = 2;

            Foo(ref a);//Передача параметра происходит по ссылке, а не по значению, от чего значение изменится

            Console.WriteLine(a);

            MyStruct myStruct = new MyStruct();
            StructChange(ref myStruct);
            Console.WriteLine(myStruct.a); //Результат -2 с использованием ref, 0 без него
        }

        static void Foo(ref int a) // Типовое использование ref, без него выводится 2, с ним -5
        {
            a = -5;
        }
        //Благоаря ref можно возвращать несколько значений из одного метода, НО НЕ ЗЛОУПОТРЕБЛЯЯ! Это нарушение принципа solid
        //Пригодится при взаимодействии методов и структур

        static void StructChange(ref MyStruct myStruct)
        {
            myStruct.a = -2;
        }
    }

    struct MyStruct // Структуры,разъяснение по ним появится позже в ООП
    {
        public int a;
        public double b;
        public float c;
    }
}