namespace oop.classes;

class Rectangle
{
    public float longeur;
    public float largeur;

    public float Surface()
    {
        return longeur * largeur;
    }

    public float Perimeter()
    {
        return (longeur + largeur) * 2;
    }
}