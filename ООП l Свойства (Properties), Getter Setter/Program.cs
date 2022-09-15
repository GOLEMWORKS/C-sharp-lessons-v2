namespace ООП_l_Свойства__Properties___Getter_Setter
{
    class Point
    {
        private int x;

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return x;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}