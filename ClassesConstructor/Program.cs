namespace ClassesConstructor
{
    internal class Program
    {
        private class Rectangle
        {
            public int x;
            public int y;
            public int width;  
            public int height;

            internal Rectangle(int x, int y, int width, int height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 5, 100, 100);

            Console.WriteLine($"x : {rect.x}, " +
                $"y: {rect.y}, " +
                $"width : {rect.width}, " +
                $"height : {rect.height}");
        }
    }
}