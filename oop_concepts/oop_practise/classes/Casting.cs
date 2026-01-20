namespace oop_practise.classes
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }
    }

    public class Paragraph : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
}
