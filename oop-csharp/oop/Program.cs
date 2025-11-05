using oop.classes;

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle();
        r1.longeur = 3;
        r1.largeur = 2;

        Console.WriteLine($"La Surface est : {r1.Surface()}");
    }
}