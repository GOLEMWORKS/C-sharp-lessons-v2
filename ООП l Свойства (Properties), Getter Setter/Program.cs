namespace ООП_l_Свойства__Properties___Getter_Setter
{
    class Point
    {
        private int x;  

        private int y; //Сниппет propfull

        public int Y //Properties (Свойства)
        {
            get { return y; }
            set { y = value; }
        }


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