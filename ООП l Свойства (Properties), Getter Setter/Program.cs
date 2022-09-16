namespace ООП_l_Свойства__Properties___Getter_Setter
{
    class Point
    {
        private int x;  

        private int y; //Сниппет propfull

        public int Y //Properties (Свойства), get & set - аксессоры
        {
            get { return y; }
            set //В аксессоры можно добавлять 
            {
                if (value <1)
                {
                    y = 1;
                    return;

                }
                if (value > 5)
                {
                    y = 5;
                    return;
                }

                y = value; //value - входящий параметр. В зависимости от типа данных свойства и переменной принимает текущий тип данных
                           //Благодаря value у нас не будет никаких неоднозначностей в свойствах
            }
            //Частичная реализация get и set
            //Можно использовать либо один set либо один get

            //Аксессоры могут быть приватными
    }
        //Автоматические свойства используют неявно приватное поле и прочий код. Используется для того, чтобы сократить запись при отсутствии лишней логики
        public int Z { get; set; } //Сниппет - prop

        public void SetX(int x) //Сеттер (Помещает)
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }
            if(x > 5)
            {
                this.x = 5;
                return;
            }
            
            this.x = x;
        }

        public int GetX()//Геттер (Передаёт)
        {
            return x;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var newPoint1 = new Point();
            newPoint1.SetX(4);
            newPoint1.Y = 12;

            Console.WriteLine($"X: {newPoint1.GetX()}");
            Console.WriteLine($"Y: {newPoint1.Y}");
        }
    }
}