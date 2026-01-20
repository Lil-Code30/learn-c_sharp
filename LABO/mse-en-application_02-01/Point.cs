namespace mse_en_application_02_01;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public double Distance(Point p)
    {
        double dx = p.X - this.X;
        double dy = p.Y - this.Y;
        
        double distance = Math.Sqrt((dx * dx) + (dy * dy));
        
        return distance;
    }

    public void Deplacer(int deltaX, int deltaY)
    {
        this.X += deltaX;
        this.Y += deltaY;
    }

    public void Afficher()
    {
        Console.WriteLine($"({this.X}, {this.Y})");
    }
    
}